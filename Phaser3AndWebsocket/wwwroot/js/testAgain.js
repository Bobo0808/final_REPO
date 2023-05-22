
const w = window.innerWidth;
const h = window.innerHeight;
var server = 'wss://localhost:7093'; //如果開啟了https則這裡是wss
var vWebSocket = null;
var cursors;
var AniLayer;
let playerDom = {}; //所有角色的資訊
let playerRef = {};//自己角色的資訊
let players = {};
let IDempty = true;
let messageBuffer = '';
let mapData = {};
let isQueue = false;
let polite;
const gameContainer = document.querySelector(".game-container");
const myVideo = document.getElementById("myVideo");
const remoteVideo = document.getElementById("remoteVideo");
const btnCamera = document.getElementById('btnCamera');
const btnMic = document.getElementById('btnMic');
const btnLeave = document.getElementById('btnLeave');
btnCamera.addEventListener('click', muteCam);
btnMic.addEventListener('click', muteMic);
btnLeave.addEventListener('click', leaveRoom);
var P_PubMap = "";

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
    console.log(player)
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
    playerRef.x = xChange;
    playerRef.y = yChange;
    sendDirection();
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

function AddPlayer(data) {
    console.log("player" + playerRef.id, "data" + data.id);
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
        // characterElement.classList.add("you");
    }
    players[data.id] = {
        id: data.id,
        name: data.name,
        gender: data.gender,
        direction: data.direction,
        color: data.color,
        x: data.x,
        y: data.y
    }


    if (playerRef.id === playerDom.id) {
        //每當有連線 不是自己的id的話就創建新角色
        this.player = this.physics.add.sprite(13152, 9216, 'stand');
        this.player.anims.play('stand_anim', true);
        this.player.setScale(0.5);
        this.player.setSize(128, 128);
        console.log("ID是" + playerRef.id);
    } else {
        // this.player.setPosition(13152, 9216);
        console.log("faill");
    }
    // if (playerRef.id != playerDom.id) {

    // }

    // this.player.setCollideWorldBounds(true);

}

class gameStart extends Phaser.Scene {
    constructor() {
        super('gameStart');


    }

    preload() {
        vWebSocket = new WebSocket(server + '/WebSocket');
        document.getElementById("dialog-send-btn").addEventListener("click", sendMsg);
        document.getElementById('joinBtn').addEventListener("click", sendQueueRequest);


        //如果連線成功
        vWebSocket.addEventListener('open', (e) => {
            console.log('connection start ...');
            console.log(e);
            console.log(vWebSocket);
            let data = {
                "type": "Connect",
            };
            vWebSocket.send(JSON.stringify(data));
            AddPlayer();
        })
        // this.AddPlayer({
        //     id: playerRef.id,
        //     name: playerRef.name,
        //     gender: playerRef.gender,
        //     direction: playerRef.direction,
        //     color: playerRef.color,
        //     x: playerRef.x,
        //     y: playerRef.y
        // });
        //接收到訊息時
        vWebSocket.addEventListener('message', (e) => {
            messageBuffer = e.data;
            console.log("messageBuffer=e.data=" + messageBuffer);
            // 如果接收到的訊息還不完整，則繼續等待
            if (!isCompleteMessage(messageBuffer)) {
                return;
            }

            let result = JSON.parse(messageBuffer);
            messageBuffer = '';
            switch (result.type) {
                case "Load":
                    console.log("Load");
                    myVideo.style.visibility = 'hidden';
                    remoteVideo.style.visibility = 'hidden';
                    btnCamera.style.visibility = 'hidden';
                    btnMic.style.visibility = 'hidden';
                    btnLeave.style.visibility = 'hidden';
                    while (gameContainer.firstChild) {
                        gameContainer.removeChild(gameContainer.lastChild);
                    }
                    for (let i = 0; i < result.client.length; i++) {
                        this.AddPlayer(result.client[i]);
                    }
                    console.log(result);
                    LoadMap(result);
                    P_PubMap = mapData.src;
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
                    this.setDirection(result)
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
                    this.mediaOn();

                    break
                case "Wait":
                    console.log("等待配對")
                    isQueue = true;
                    break
                case "Peer":
                    // console.log(result.candidate);
                    result.description = JSON.parse(result.description);
                    result.candidate = JSON.parse(result.candidate);
                    this.MatchPlayer(result);
                    break
            }
        })

        // new KeyPressListener("ArrowUp", () => handleArrowPress(0, -1))
        // new KeyPressListener("ArrowDown", () => handleArrowPress(0, 1))
        // new KeyPressListener("ArrowLeft", () => handleArrowPress(-1, 0))
        // new KeyPressListener("ArrowRight", () => handleArrowPress(1, 0))

        //關閉連線時
        vWebSocket.addEventListener("close", (e) => {
            IDempty = true;
            console.log("connection closed");
        });

        this.load.image("tiles", "/wwwroot/tiled/mapani.png");
        console.log(mapData.id);
        if (mapData.id === 'PubMap') {
            this.load.tilemapTiledJSON('map', '/wwwroot/tiled/HELPME.json');
        }
        else {
            console.log('MapJsonStillWrong');
            this.load.tilemapTiledJSON('map', '/wwwroot/tiled/HELPME.json');
        }

        // this.load.spritesheet('water', '/tiled/water.png', {
        //     frameWidth: 32, frameHeight: 32
        // });

        this.load.spritesheet('stand', '/wwwroot/img/phaser/Sprite_stand.png', {
            frameWidth: 128, frameHeight: 128
        });
        this.load.spritesheet('walk', '/wwwroot/img/phaser/Sprite_walk.png', {
            frameWidth: 128, frameHeight: 128
        });
        this.load.spritesheet('Npc01Stand', '/wwwroot/img/phaser/NPC01_stand.png', {
            frameWidth: 128, frameHeight: 128
        });
        this.load.spritesheet('Npc01Walk', '/wwwroot/img/phaser/NPC01_walk.png', {
            frameWidth: 128, frameHeight: 128
        });

        this.load.on('complete', function () {
            this.anims.create({
                key: 'stand_anim',
                frames: this.anims.generateFrameNumbers('stand', { start: 0, end: 7 }),
                frameRate: 10,
                repeat: -1
            });

            this.anims.create({
                key: 'walk_anim',
                frames: this.anims.generateFrameNumbers('walk', { start: 0, end: 7 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'Npc01Stand_anim',
                frames: this.anims.generateFrameNumbers('Npc01Stand', { start: 0, end: 7 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'Npc01Walk_anim',
                frames: this.anims.generateFrameNumbers('Npc01Walk', { start: 0, end: 7 }),
                frameRate: 10,
                repeat: -1
            });
            // this.anims.create({
            //     key: 'bgWater',
            //     frames: this.anims.generateFrameNumbers('water', { start: 0, end: 15 }),
            //     frameRate: 10,
            //     repeat: -1
            // })

        }.bind(this));
    }
    create() {



        //建立一個web socket 連線





        const map = this.make.tilemap({ key: "map", tileWidth: 32, tileHeight: 32 });
        const tileset = map.addTilesetImage("mapani", "tiles", 32, 32, 0, 0);
        // const layer = map.createLayer("bg", tileset, 0, 0);
        // AniLayer = map.createLayer("ani", tileset);
        // const waterObj = this.add.sprite(1584, 1584, 'Water');
        // waterObj.play('bgWater');
        const layer_sea = map.createLayer("sea", tileset, 0, 0);
        const layer_island = map.createLayer("island", tileset, 0, 0);
        const layer_03 = map.createLayer("03", tileset, 0, 0);
        const layer_04 = map.createLayer("04", tileset, 0, 0);
        const layer_Detph1 = map.createLayer("Detph1", tileset, 0, 0);
        const layer_Detph2 = map.createLayer("Detph2", tileset, 0, 0);
        const layer_collision = map.createLayer("collision", tileset, 0, 0);
        layer_sea.setScale(2);
        layer_island.setScale(2);
        layer_03.setScale(2);
        layer_04.setScale(2);
        layer_Detph1.setScale(2);
        layer_Detph2.setScale(2);
        layer_collision.setScale(2);
        // layer_collision.setCollisionBetween(2710, 2715);
        layer_collision.setAlpha(0);
        layer_Detph1.setDepth(2);
        layer_Detph2.setDepth(3);
        this.player.setDepth(1);
        this.cameras.main.centerOn(1600, 1600);

        var teleportStart = document.getElementById('waypoint');
        teleportStart.addEventListener('click', function () { teleport.call(this, 'start'); }.bind(this));
        var teleportMoney = document.getElementById('moneypoint');
        teleportMoney.addEventListener('click', function () { teleport.call(this, 'money'); }.bind(this));
        var teleportelec = document.getElementById('elecpoint');
        teleportelec.addEventListener('click', function () { teleport.call(this, 'elec'); }.bind(this));
        var teleportSports = document.getElementById('sportspoint');
        teleportSports.addEventListener('click', function () { teleport.call(this, 'sports'); }.bind(this));
        var teleportlife = document.getElementById('lifepoint');
        teleportlife.addEventListener('click', function () { teleport.call(this, 'life'); }.bind(this));


        //吊橋
        // this.player = this.physics.add.sprite(6144, 9376, 'stand');

        //雪地
        // this.player = this.physics.add.sprite(6592, 14592, 'stand');


        //商店街
        // this.player = this.physics.add.sprite(6080, 3296, 'stand');

        //群島
        // this.player = this.physics.add.sprite(12736, 3296, 'stand');




        // this.player = this.physics.add.sprite(13152, 9216, 'stand');
        // this.player.anims.play('stand_anim', true);
        // //出生點
        // this.player.setScale(0.5);


        //創建粉紅熊熊NPC
        this.Npc01 = this.physics.add.sprite(1700, 1700, 'Npc01Stand');
        this.Npc01.anims.play('Npc01Stand_anim', true);
        // this.Npc01.setCollideWorldBounds(true);
        this.Npc01.setScale(0.5);
        this.Npc01.setSize(128, 128);


        cursors = this.input.keyboard.createCursorKeys();
        this.cameras.main.startFollow(this.player);


        this.physics.world.addCollider(this.player, layer_collision);
        // Houselayer.setCollisionByProperty({ collides: true });

        // Houselayer.setCollisionBetween(705, 871);

        // this.physics.world.addCollider(this.player, Houselayer);
        // this.physics.world.addCollider(this.Npc01, Houselayer);
        this.physics.world.addCollider(this.Npc01, this.player);


    }
    update() {
        console.log(this.player.x - 32, this.player.y - 32)
        this.player.setVelocityY(0);
        this.player.setVelocityX(0);
        this.Npc01.setVelocityY(0);
        this.Npc01.setVelocityX(0);

        var keyW = this.input.keyboard.addKey('W');
        var keyS = this.input.keyboard.addKey('S');
        var keyA = this.input.keyboard.addKey('A');
        var keyD = this.input.keyboard.addKey('D');

        if (cursors.up.isDown) {
            // this.player.y -= 4;
            this.player.setVelocityY(-800);
            if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                this.player.anims.play('walk_anim');
            }
            this.cameras.main.scrollY -= 4;
        }
        else if (cursors.down.isDown) {
            // this.player.y += 4;
            this.player.setVelocityY(+800);

            if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                this.player.anims.play('walk_anim');
            }
            this.cameras.main.scrollY += 4;
        }
        else if (cursors.left.isDown) {
            // this.player.x -= 4;
            this.player.setVelocityX(-800);

            if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                this.player.anims.play('walk_anim');
            }
            this.cameras.main.scrollX -= 4;
            this.player.flipX = true;
        }
        else if (cursors.right.isDown) {
            // this.player.x += 4;
            this.player.setVelocityX(+800);

            if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                this.player.anims.play('walk_anim');
            }
            this.cameras.main.scrollX += 4;
            this.player.flipX = false;
        }
        else {
            this.player.anims.play('stand_anim', true);
        }



        if (keyW.isDown) {
            // this.Npc01.y -= 4;
            this.Npc01.setVelocityY(-800);
            if (this.Npc01.anims.currentAnim !== this.anims.get('Npc01Walk_anim')) {
                this.Npc01.anims.play('Npc01Walk_anim');
            }
        }
        else if (keyS.isDown) {
            // this.Npc01.y += 4;
            this.Npc01.setVelocityY(+400);

            if (this.Npc01.anims.currentAnim !== this.anims.get('Npc01Walk_anim')) {
                this.Npc01.anims.play('Npc01Walk_anim');
            }
        }
        else if (keyA.isDown) {
            // this.Npc01.x -= 4;
            this.Npc01.setVelocityX(-400);

            if (this.Npc01.anims.currentAnim !== this.anims.get('Npc01Walk_anim')) {
                this.Npc01.anims.play('Npc01Walk_anim');
            }
            this.Npc01.flipX = true;
        }
        else if (keyD.isDown) {
            // this.Npc01.x += 4;
            this.Npc01.setVelocityX(+400);

            if (this.Npc01.anims.currentAnim !== this.anims.get('Npc01Walk_anim')) {
                this.Npc01.anims.play('Npc01Walk_anim');
            }
            this.Npc01.flipX = false;
        }
        else {
            this.Npc01.anims.play('Npc01Stand_anim', true);
        }


    }
    render() {
        this.debug.cameraInfo(this.cameras.main, 32, 32);
    }
}

function teleport(target) {
    var points = {
        start: { x: 13152, y: 9216 },
        money: { x: 6080, y: 3296 },
        elec: { x: 6592, y: 14592 },
        sports: { x: 12736, y: 3296 },
        life: { x: 6144, y: 9376 }
    };
    var waypoint = points[target];
    if (waypoint) {
        var duration = 500;


        this.mask = this.add.graphics();
        this.mask.fillStyle(0x000000, 1);
        this.mask.fillRect(0, 0, w, h);


        this.tweens.add({
            targets: this.mask,
            alpha: 1,
            duration: 500,
            onComplete: function () {
                this.player.x = waypoint.x;
                this.player.y = waypoint.y;
                this.tweens.add({
                    targets: this.mask,
                    alpha: 0,
                    duration: 500,
                    onComplete: function () {
                        this.mask.destroy();
                        console.log("Teleportation complete!");
                    }.bind(this)
                });
            }.bind(this)
        });
    }
}
const config = {
    type: Phaser.AUTO,
    width: '100%',
    height: '100%',
    parent: 'gameArea',
    scene: [gameStart],
    scale: {
        mode: Phaser.Scale.FIT,
        autoCenter: Phaser.Scale.CENTER_BOTH
    },
    renderType: 2,
    backgroundColor: '#FFFFFF',
    physics: {
        default: 'arcade',
        arcade: {
            debug: true

        }
    }
};
const game = new Phaser.Game(config);