
var server = 'wss://localhost:7184'; //如果開啟了https則這裡是wss
var vWebSocket = null;
let totalPlayer = {}; //所有角色的資訊
let playerID; //自己角色的ID
let IDempty = true;
const gameContainer = document.querySelector(".game-container");
window.onload = function () {
    //建立一個web socket 連線
    vWebSocket = new WebSocket(server + '/ws');
    document.getElementById("dialog-send-btn").addEventListener("click", sendMsg);
    //如果連線成功
    vWebSocket.onopen = function (e) {
        console.log('connection start ...');
        console.log(e);
        console.log(vWebSocket);
        var content = document.getElementById("lbMsg");
    }
    //接收到訊息時
    vWebSocket.onmessage = function (e) {
        console.log('Recevied Message:' + e.data);
        let result = JSON.parse(e.data);
        if (e.data) {
            switch (result.type) {
                case "Load":
                    console.log(result);
                    for (let i = 0; i < result.client.length; i++) {
                        AddPlayer(result.client[i]);
                    }
                    break;
                case "Chat":
                    //訊息屬性Chat
                    const content = document.getElementById("dialog");
                    const timecontent = document.getElementById("dialog-time");
                    var today = new Date();
                    var date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();
                    var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
                    var dateTime = date + ' ' + time;
                    let message = `${result.client.Uid}: ${result.content}`;
                    timecontent.innerText = timecontent.innerText + '\r\n' + dateTime;
                    content.innerText = content.innerText + '\r\n' + message;
                    break;
                case "Connect":
                    //訊息屬性是Connect
                    if (IDempty) {
                        playerID = result.Uid;
                        IDempty = false;
                    }
                    AddPlayer(result);
                    console.log(result.Uid + " has logged in")
                    break;
                case "Disconnect":
                    dcPlayer(result.PlayerRef)
                    break
                case "Movement":
                    //訊息屬性是Movement
                    break
            }

        }
    }
    //關閉連線時
    vWebSocket.onclose = function (e) {
        console.log("connection closed");
    }
};

function sendMsg() {
    var txtMsg = document.getElementById("dialog-input").value;
    if (txtMsg) {
        var data = {
            "type": "Chat",
            "data": txtMsg
        };
        vWebSocket.send(JSON.stringify(data));
    }
}

function AddPlayer(data) {
    const characterElement = document.createElement("div")
    characterElement.setAttribute('id', `${data.Uid}`)
    characterElement.classList.add("Character", "grid-cell");
    if (data.Uid === playerID) {
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
    totalPlayer[data.Uid] = characterElement;

    characterElement.querySelector(".Character_name").innerText = data.name;
    characterElement.setAttribute("data-color", data.color);
    characterElement.setAttribute("data-direction", data.direction);
    const left = 16 * data.x + "px";
    const top = 16 * data.y - 4 + "px";
    characterElement.style.transform = `translate3d(${left}, ${top}, 0)`;
    gameContainer.appendChild(characterElement);
}
function LoadMap() {

}

function dcPlayer(data) {
    gameContainer.removeChild(totalPlayer[data.Uid]);
    delete totalPlayer[data.Uid];
}