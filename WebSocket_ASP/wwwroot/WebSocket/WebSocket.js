

var server = 'wss://chickenlife20230522194335.azurewebsites.net/'; //如果開啟了https則這裡是wss
var vWebSocket = null;
let playerDom = {}; //所有角色的資訊
let playerRef = {};//自己角色的資訊
let players = {};
let IDempty = true;
let messageBuffer = '';
let mapData = {};
let isQueue = false;
console.log(server);
let polite;
const myVideo = document.getElementById("myVideo");
const remoteVideo = document.getElementById("remoteVideo");
const btnCamera = document.getElementById('btnCamera');
const btnMic = document.getElementById('btnMic');
const btnLeave = document.getElementById('btnLeave');

btnCamera.addEventListener('click', muteCam);
btnMic.addEventListener('click', muteMic);
btnLeave.addEventListener('click', leaveRoom);

const gameContainer = document.querySelector(".game-container");
window.onload = function () {
    //建立一個web socket 連線
    vWebSocket = new WebSocket(server + '/WebSocket');
    document.getElementById("dialog-send-btn").addEventListener("click", sendMsg);
    document.getElementById('joinBtn').addEventListener("click", sendQueueRequest);


    //如果連線成功
    vWebSocket.onopen = function (e) {
        console.log('connection start ...');
        console.log(e);
        console.log(vWebSocket);
        let data = {
            "type": "Connect",
        };
        vWebSocket.send(JSON.stringify(data));
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
                myVideo.style.visibility = 'hidden';
                remoteVideo.style.visibility = 'hidden';
                btnCamera.style.visibility = 'hidden';
                btnMic.style.visibility = 'hidden';
                btnLeave.style.visibility = 'hidden';
                while (gameContainer.firstChild) {
                    gameContainer.removeChild(gameContainer.lastChild);
                }
                for (let i = 0; i < result.client.length; i++) {
                    AddPlayer(result.client[i]);
                }
                console.log(result);
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
                console.log(result);
                //訊息屬性是Connect
                if (IDempty) {
                    playerRef.id = result.id;
                    IDempty = false;
                }
                AddPlayer(result);
                console.log(result.id + " has logged in")
                break;
            case "Disconnect":
                remoteVideo.style.visibility = 'hidden';
                console.log(result);
                dcPlayer(result.PlayerRef)
                break
            case "Movement":
                //訊息屬性是Movement
                console.log(result);
                setDirection(result)
                break
            case "Match":
                // alert("配對成功")
                isQueue = false;
                while (gameContainer.firstChild) {
                    gameContainer.removeChild(gameContainer.lastChild);
                }
                alert("操你媽");
                myVideo.style.visibility = 'visible';
                remoteVideo.style.visibility = 'visible';
                btnCamera.style.visibility = 'visible';
                btnMic.style.visibility = 'visible';
                btnLeave.style.visibility = 'visible';


                LoadMap(result);
                for (let i = 0; i < result.client.length; i++) {
                    AddPlayer(result.client[i]);
                }
                if (playerRef.gender == 1) {
                    polite = false;
                }
                else if (playerRef.gender == 2) {
                    polite = true;
                }
                mediaOn();

                break
            case "Wait":
                console.log("等待配對")
                isQueue = true;
                break
            case "Peer":
                // console.log(result.candidate);
                result.description = JSON.parse(result.description);
                result.candidate = JSON.parse(result.candidate);
                MatchPlayer(result);
                break
        }

    }
    new KeyPressListener("ArrowUp", () => handleArrowPress(0, -1))
    new KeyPressListener("ArrowDown", () => handleArrowPress(0, 1))
    new KeyPressListener("ArrowLeft", () => handleArrowPress(-1, 0))
    new KeyPressListener("ArrowRight", () => handleArrowPress(1, 0))

    //關閉連線時
    vWebSocket.onclose = function (e) {
        IDempty = true;
        console.log("connection closed");
    };
}

function sendMsg() {
    var txtMsg = document.getElementById("dialog-input").value;
    if (txtMsg) {
        let data = {
            "type": "Chat",
            "id": mapData.id,
            "data": txtMsg
        };
        vWebSocket.send(JSON.stringify(data));
    }
}

function sendDirection() {
    let player = {
        "type": "Movement",
        "mapid": mapData.id,
        "data": {
            "type": "Movement",
            "id": playerRef.id,
            "name": playerRef.name,
            "gender": playerRef.gender,
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
    characterElement.setAttribute('id', data.id)
    characterElement.classList.add("Character", "grid-cell");
    if (data.id === playerRef.id) {
        playerRef = {
            id: data.id,
            name: data.name,
            gender: data.gender,
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
        gender: data.gender,
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
        id: result.id,
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

async function sendQueueRequest() {
    if (!isQueue) {
        let data = {
            "type": "Queue",
            "mapid": mapData.id,
        }
        vWebSocket.send(JSON.stringify(data))
        isQueue = true;
    }
    else {
        alert("你已經在配對中")
    }
}




//===========================================================================================
// const peer = new RTCPeerConnection(server); // Webrtc配對用
let ice = {
    "iceServers": [
        { "url": "stun:stun.l.google.com:19302" },
    ]
};
let constraints = {
    audio: {
        channels: 2,
        autoGainControl: false,
        echoCancellation: false,
        noiseSuppression: false
    }, video: true
};

let localStream;
let remoteSteam;
let makingOffer = false;
let peerChanel = new RTCPeerConnection(ice);
let stream;
let MicOn = true;
let CamOn = true;

function muteMic() {
    stream.getAudioTracks()[0].enabled = !(stream.getAudioTracks()[0].enabled);
    MicOn = false;

}

function muteCam() {
    stream.getVideoTracks()[0].enabled = !(stream.getVideoTracks()[0].enabled);
    CamOn = false;

}

function leaveRoom() {
    try {
        stream.getTracks().forEach(track => track.stop());
        remoteVideo.srcObject = null;
    }
    finally {

        let data = {
            "type": "Leave",
            "mapid": mapData.id,
        }
        vWebSocket.send(JSON.stringify(data))
    }

}

async function mediaOn() {
    try {

        stream = await navigator.mediaDevices.getUserMedia(constraints);
        for (const track of stream.getTracks()) {
            peerChanel.addTrack(track, stream);
        }
        myVideo.srcObject = stream;
    } catch (err) {
        console.error(err);
    }
}

peerChanel.ontrack = ({ track, streams }) => {
    track.onunmute = () => {
        if (remoteVideo.srcObject) {
            return;
        }
        remoteVideo.srcObject = streams[0];
    }
}

peerChanel.onnegotiationneeded = async () => {
    try {
        makingOffer = true;
        await peerChanel.setLocalDescription();
        let data = {
            "type": "Description",
            "mapid": mapData.id,
            "description": peerChanel.localDescription,
            "candidate": "",
        }
        vWebSocket.send(JSON.stringify(data))
    } catch (err) {
        console.error(err);
    } finally {
        makingOffer = false;
    }
};

peerChanel.onicecandidate = ({ candidate }) => {
    let data = {
        "type": "Description",
        "mapid": mapData.id,
        "description": "",
        "candidate": candidate
    }
    vWebSocket.send(JSON.stringify(data))
};


let ignoreOffer = false;
async function MatchPlayer(data) {
    try {
        if (data.description) {
            const offerCollision = (data.description.type == "offer") &&
                (makingOffer || peerChanel.signalingState != "stable");

            ignoreOffer = !polite && offerCollision;
            if (ignoreOffer) {
                return;
            }

            await peerChanel.setRemoteDescription(data.description);
            if (data.description.type == "offer") {
                await peerChanel.setLocalDescription();
                let datatemp = {
                    "type": "Description",
                    "mapid": mapData.id,
                    "description": peerChanel.localDescription,
                    "candidate": ""
                }
                vWebSocket.send(JSON.stringify(datatemp))
            }
        } else if (data.candidate) {
            try {
                await peerChanel.addIceCandidate(data.candidate);
            } catch (err) {
                if (!ignoreOffer) {
                    throw err;
                }
            }
        }
    } catch (err) {
        console.error(err);
    }
}


// peerChanel.ondatachannel = e => {
//     const rc = e.channel;
//     rc.onmessage = e => {
//         console.log("hi");
//     }
// }