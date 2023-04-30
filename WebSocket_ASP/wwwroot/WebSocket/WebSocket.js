var server = 'wss://localhost:7184'; //如果開啟了https則這裡是wss
var vWebSocket = null;
let playerDom = {}; //所有角色的資訊
let playerRef = {};//自己角色的資訊
let players = {};
let IDempty = true;
let messageBuffer = '';
let mapData = {};

const gameContainer = document.querySelector(".game-container");
window.onload = function () {
    //建立一個web socket 連線
    vWebSocket = new WebSocket(server + '/ws');
    document.getElementById("dialog-send-btn").addEventListener("click", sendMsg);
    document.getElementById('joinBtn').addEventListener("click", sendQueueRequest);
    //如果連線成功
    vWebSocket.onopen = function (e) {
        console.log('connection start ...');
        console.log(e);
        console.log(vWebSocket);
    }
    //接收到訊息時
    vWebSocket.onmessage = function (e) {
        messageBuffer = e.data;
        // 如果接收到的訊息還不完整，則繼續等待
        if (!isCompleteMessage(messageBuffer)) {
            return;
        }

        let result = JSON.parse(messageBuffer);
        messageBuffer = '';

        switch (result.type) {
            case "Load":
                for (let i = 0; i < result.client.length; i++) {
                    AddPlayer(result.client[i]);
                }
                LoadMap(result);
                break;
            case "Chat":
                //訊息屬性Chat
                const content = document.getElementById("dialog");
                const timecontent = document.getElementById("dialog-time");
                var today = new Date();
                var date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();
                var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
                var dateTime = date + ' ' + time;
                let message = `${result.client.id}: ${result.content}`;
                timecontent.innerText = timecontent.innerText + '\r\n' + dateTime;
                content.innerText = content.innerText + '\r\n' + message;
                break;
            case "Connect":
                //訊息屬性是Connect
                if (IDempty) {
                    playerRef.id = result.id;
                    IDempty = false;
                }
                AddPlayer(result);
                console.log(result.id + " has logged in")
                break;
            case "Disconnect":
                dcPlayer(result.PlayerRef)
                break
            case "Movement":
                //訊息屬性是Movement

                setDirection(result)
                break
        }

    }
    new KeyPressListener("ArrowUp", () => handleArrowPress(0, -1))
    new KeyPressListener("ArrowDown", () => handleArrowPress(0, 1))
    new KeyPressListener("ArrowLeft", () => handleArrowPress(-1, 0))
    new KeyPressListener("ArrowRight", () => handleArrowPress(1, 0))

    //關閉連線時
    vWebSocket.onclose = function (e) {
        console.log("connection closed");
    };
}

function sendMsg() {
    var txtMsg = document.getElementById("dialog-input").value;
    if (txtMsg) {
        let data = {
            "type": "Chat",
            "data": txtMsg
        };
        vWebSocket.send(JSON.stringify(data));
    }
}

function sendDirection() {
    let player = {
        "type": "Movement",
        "data": {
            "type": "Movement",
            "id": playerRef.id,
            "name": playerRef.name,
            "direction": playerRef.direction,
            "color": playerRef.color,
            "x": playerRef.x,
            "y": playerRef.y
        }
    }
    let jtemp = JSON.stringify(player)
    vWebSocket.send(jtemp);
}

function setDirection(result) {
    players[result.id].direction = result.direction;
    players[result.id].x = result.x;
    players[result.id].y = result.y;
    const left = 16 * players[result.id].x + "px";
    const top = 16 * players[result.id].y - 4 + "px";
    playerDom[result.id].setAttribute("data-direction", players[result.id].direction);
    playerDom[result.id].style.transform = `translate3d(${left}, ${top}, 0)`;
}

function handleArrowPress(xChange = 0, yChange = 0) {
    const newX = playerRef.x + xChange;
    const newY = playerRef.y + yChange;
    if (!isSolid(newX, newY)) {
        playerRef.x = newX;
        playerRef.y = newY;
        if (xChange === 1) {
            playerRef.direction = "right";
        }
        if (xChange === -1) {
            playerRef.direction = "left";
        }
        sendDirection();
    }
}

function AddPlayer(data) {
    const characterElement = document.createElement("div")
    characterElement.setAttribute('id', `${data.id}`)
    characterElement.classList.add("Character", "grid-cell");
    if (data.id === playerRef.id) {
        playerRef = {
            id: data.id,
            name: data.name,
            direction: data.direction,
            color: data.color,
            x: data.x,
            y: data.y
        }
        characterElement.classList.add("you");
    }
    characterElement.innerHTML = (`
        <div class="Character_shadow grid-cell"></div>
        <div class="Character_sprite grid-cell"></div>
        <div class="Character_name-container">
          <span class="Character_name"></span>
        </div>
        <div class="Character_you-arrow"></div>
      `);
    players[data.id] = {
        id: data.id,
        name: data.name,
        direction: data.direction,
        color: data.color,
        x: data.x,
        y: data.y
    }
    playerDom[data.id] = characterElement;

    characterElement.querySelector(".Character_name").innerText = data.name;
    characterElement.setAttribute("data-color", data.color);
    characterElement.setAttribute("data-direction", data.direction);
    const left = 16 * data.x + "px"; //16=目前一格的區塊大小
    const top = 16 * data.y - 4 + "px";
    characterElement.style.transform = `translate3d(${left}, ${top}, 0)`;
    gameContainer.appendChild(characterElement);
}
function LoadMap(result) {
    mapData = {
        src: result.src,
        MinX: result.MinX,
        MaxX: result.MaxX,
        MinY: result.MinX,
        MaxY: result.MaxY,
        BlockedSpaces: result.BlockedSpaces
    };
}

function dcPlayer(data) {
    gameContainer.removeChild(playerDom[data.id]);
    delete playerDom[data.id];
}

function isCompleteMessage(message) {
    try {
        JSON.parse(message);
        return true;
    } catch (error) {
        console.log('false');
        return false;
    }
}

function isSolid(x, y) {
    let blockedNextSpace = false;
    for (let i = 0; i < mapData.BlockedSpaces.length; i++) {
        if (x == mapData.BlockedSpaces[i].x && y == mapData.BlockedSpaces[i].y) {
            blockedNextSpace = true;
        }
    }
    return (
        blockedNextSpace ||
        x >= mapData.MaxX ||
        x < mapData.MinX ||
        y >= mapData.MaxY ||
        y < mapData.MinY
    )
}

function sendQueueRequest() {
    let data = {
        "type": "Queue",
        "data": txtMsg
    };
    vWebSocket.send(JSON.stringify(data));
}