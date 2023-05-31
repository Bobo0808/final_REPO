import { onMounted, ref, watch, toRaw, watchEffect } from 'vue';
import { playerRefs } from "../main.js";
import spriteStand from '../img/phaser/Sprite_stand.png';
import spriteWalk from '../img/phaser/Sprite_walk.png';
import helpMe from '../tiled/HELPME.json';
import npcStand from '../img/phaser/NPC01_stand.png';
import npcWalk from '../img/phaser/NPC01_walk.png';
import mapAni from "../tiled/mapani.png";
import arrow from "../img/phaser/J_Ur_u.png";

import Nurtured from '../music/Nurtured_in_Contemplation.mp3'
import wind from '../music/wind.mp3'
import froestSunWater from '../music/froestSunWater.mp3'
import water from '../music/water.mp3'
import lollipop from '../music/lollipop.mp3'
import mirror from '../music/mirror.mp3'

export const phas = () => {

    const closeableModal = ref(false);
    const dialogBox = ref(null);
    const dialogBody = ref(null);
    let isShowedDialog = false;
    const w = window.innerWidth;
    const h = window.innerHeight;
    // var server = 'wss://chickenlife20230522194335.azurewebsites.net/';
    // var server = 'wss://chickenlife.azurewebsites.net/';
    var server = 'wss://localhost:7093';
    var vWebSocket = null;
    var cursors;
    var AniLayer;
    let playerDom = {};
    let playerRef = {};
    let players = {};
    let wantdelplayers = [];
    let IDempty = true;
    let messageBuffer = '';
    let mapData = {};
    let isQueue = false;
    let polite;
    var playerName = {};
    var layer_collision = "";
    var musicStart;
    var musicSnow;
    var musicStore;
    var musicBridge;
    var musicIsland;
    var musicLilRoom;
    var playerName;
    var ads;
    var ADList = [];
    var ADImageStart = null;
    var ADImageMoney = null;
    var ADImageEle = null;
    var ADImageSports = null;
    var ADImageLife = null;
    var ADImageLil = null;
    const leftSideBtn = document.getElementById('leftSideBtn');
    const waypoint = document.getElementById('waypoint');
    const moneypoint = document.getElementById('moneypoint');
    const elecpoint = document.getElementById('elecpoint');
    const lifepoint = document.getElementById('lifepoint');
    const sportspoint = document.getElementById('sportspoint');
    const waitingLog = document.getElementById('waitingLog');
    const gameContainer = document.querySelector(".game-container");
    const myVideo = document.getElementById("myVideo");
    const remoteVideo = document.getElementById("remoteVideo");
    const btnCamera = document.getElementById('btnCamera');
    const btnMic = document.getElementById('btnMic');
    const btnLeave = document.getElementById('btnLeave');
    const btnStart = document.getElementById('joinBtn');
    const dialogBoo = document.getElementById('dialogBoo');
    const extendBtnContainer = document.getElementById('extendBtnContainer');
    btnCamera.addEventListener('click', muteCam);
    btnMic.addEventListener('click', muteMic);
    btnLeave.addEventListener('click', leaveRoom);
    var P_PubMap = "";
    // fetch('https://localhost:7093/api/Ads')
    //     .then(response => response.json())
    //     .then(data => {
    //         ads = data;
    //         console.log("data");
    //         console.log(data);
    //         ads.forEach(function (adimg) {
    //             if (adimg.ad_ID > 29) {
    //                 ADList.push(adimg.ad_ImageURL);
    //                 if (ADList[0]) { ADImageStart = ADList[0]; }
    //                 if (ADList[1]) { ADImageMoney = ADList[1]; }
    //                 if (ADList[2]) { ADImageEle = ADList[2]; }
    //                 if (ADList[3]) { ADImageSports = ADList[3]; }
    //                 if (ADList[4]) { ADImageLife = ADList[4]; }
    //                 if (ADList[5]) { ADImageLil = ADList[5]; }
    //             }
    //         });
    //         console.log("ADList");
    //         console.log(ADList);
    //     })
    //     .catch(error => {
    //     });

    const showDialog = () => {
        if (dialogBox.value) {
            dialogBox.value.style.display = 'flex';
            isShowedDialog = true;
        }
    };

    function hideDialog() {
        if (dialogBox.value) {
            dialogBox.value.style.display = 'none';
            isShowedDialog = false;
        }
        console.log(dialogBox.value)
    };

    const handleKeyPress = (event) => {
        if (event.key === 'Enter') {
            if (isShowedDialog) {
                hideDialog();
            } else {
                showDialog();
            }
        }
    };

    const sendMessage = () => {
        sendMsg();
    };
    document.addEventListener('keypress', handleKeyPress);
    dialogBox.value = document.getElementById('dialog-box');
    const dialogCloseBtn = document.getElementById('dialog-close-btn');
    dialogCloseBtn.addEventListener('click', hideDialog);
    const dialogInput = document.getElementById('dialog-input');
    dialogInput.addEventListener('keypress', (event) => {
        if (event.key === 'Enter') {
            sendMessage();
        }
    });




    function sendMsg() {
        var txtMsg = document.getElementById("dialog-input").value;
        if (txtMsg && txtMsg.length < 50) {
            let data = {
                "type": "Chat",
                "id": mapData.id,
                "data": txtMsg
            };
            vWebSocket.send(JSON.stringify(data));
            document.getElementById("dialog-input").value = "";
            setTimeout(function () {
                dialogBoo.scrollTop = dialogBoo.scrollHeight;
            }, 100);
        }
        else if (txtMsg.length === 0) {
            alert('聊天訊息不可以為空');
        }
        else {
            alert('不可超過50字');
        }
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
        players[data.id].destroy();
        delete players[data.id];
    }

    function isCompleteMessage(message) {
        try {
            JSON.parse(message);
            return true;
        } catch (error) {
            return false;
        }
    }

    async function sendQueueRequest() {
        btnStart.style.visibility = 'hidden';
        if (!isQueue) {
            let data = {
                "type": "Queue",
                "mapid": mapData.id,
            }
            vWebSocket.send(JSON.stringify(data))
            isQueue = true;
            console.log("wqwe");
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
        btnStart.style.visibility = 'visible';
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

    function cleanAllPlayers() {
        for (let i = 0; i < wantdelplayers.length; i++) {
            wantdelplayers[i].destroy();
        }
        players = [];
    }

    class gameStart extends Phaser.Scene {
        constructor() {
            super('gameStart');


        }
        AddPlayer(data) {

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

                this.player = this.physics.add.sprite(data.x, data.y, 'stand');
                this.player.anims.play('stand_anim', true);
                this.player.setScale(0.5);
                this.player.setSize(128, 128);
                this.player.setDepth(1);
                this.cameras.main.startFollow(this.player);
                this.physics.world.addCollider(this.player, layer_collision);
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
            if (data.id != playerRef.id) {
                players[data.id] = this.physics.add.sprite(9728, 6912, 'stand');
                players[data.id].anims.play('stand_anim', true);
                players[data.id].setScale(0.5);
                players[data.id].setSize(128, 128);
                players[data.id].setDepth(1);
                wantdelplayers.push(players[data.id]);
            }
        }
        sendDirection() {
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
        setDirection(result) {
            players[result.id].x = result.x;
            players[result.id].y = result.y;

            if (result.id != playerRef.id) {
                if (result.direction === "left") {
                    players[result.id].anims.play('walk_anim', true);
                    players[result.id].flipX = true;
                } else if (result.direction === "right") {
                    players[result.id].anims.play('walk_anim', true);
                    players[result.id].flipX = false;
                } else if (result.direction === "up") {
                    players[result.id].anims.play('walk_anim', true);
                } else if (result.direction === "down") {
                    players[result.id].anims.play('walk_anim', true);
                }
                else if (result.direction === "stop") {
                    players[result.id].anims.play('stand_anim', true);
                }
            }
        }

        handleArrowPress(xChange = 0, yChange = 0) {
            this.player.setVelocityX(500 * xChange);
            this.player.setVelocityY(500 * yChange);
            playerRef.x = this.player.x;
            playerRef.y = this.player.y;
            if (xChange === 1) {
                playerRef.direction = "right";
            }
            else if (xChange === -1) {
                playerRef.direction = "left";
            }
            else if (yChange === 1) {
                playerRef.direction = "down";
            }
            else if (yChange === -1) {
                playerRef.direction = "up";
            }
            else if (this.player.body.velocity.x === 0 && this.player.body.velocity.y === 0) {
                playerRef.direction = "stop";
            }


            this.sendDirection();
        }
        getMusicKey(musicObject) {
            if (musicObject.properties.music_start) {
                currentMusicKey = 'music_start';
                return 'music_start';
            } else if (musicObject.properties.music_snow) {
                currentMusicKey = 'music_snow';
                return 'music_snow';
            }
            else if (musicObject.properties.music_store) {
                currentMusicKey = 'music_store';
                return 'music_store';
            }
            else if (musicObject.properties.music_bridge) {
                currentMusicKey = 'music_bridge';
                return 'music_bridge';
            }
            else if (musicObject.properties.music_island) {
                currentMusicKey = 'music_island';
                return 'music_island';
            }
            else if (musicObject.properties.music_lilroom) {
                currentMusicKey = 'music_lilroom';
                return 'music_lilroom';
            }
            return '';
        }

        preload() {
            // fetch('https://localhost:7093/api/Ads')
            //     .then(response => response.json())
            //     .then(data => {
            //         ads = data;
            //         console.log("data");
            //         console.log(data);
            //         ads.forEach(function (adimg) {
            // if (adimg.ad_ID > 29) {
            //     ADList.push(adimg.ad_ImageURL);
            //     if (ADList[0]) { ADImageStart = ADList[0]; }
            //     if (ADList[1]) { ADImageMoney = ADList[1]; }
            //     if (ADList[2]) { ADImageEle = ADList[2]; }
            //     if (ADList[3]) { ADImageSports = ADList[3]; }
            //     if (ADList[4]) { ADImageLife = ADList[4]; }
            //     if (ADList[5]) { ADImageLil = ADList[5]; }
            //     if (ADImageStart) {
            //         console.log("222ADImageStart");
            //         console.log(ADImageStart);
            //         this.load.image("ADImageStart", ADImageStart);
            //         console.log("333ADImageStart");
            //     }
            // }
            // });
            // console.log("ADList");
            // console.log(ADList);
            // })
            // .catch(error => {
            // });

            this.load.image("tiles", mapAni);
            this.load.tilemapTiledJSON('map', helpMe);
            this.load.audio('musicStart', Nurtured);
            this.load.audio('musicSnow', wind);
            this.load.audio('musicStore', froestSunWater);
            this.load.audio('musicBridge', water);
            this.load.audio('musicIsland', lollipop);
            this.load.audio('musicLilRoom', mirror);
            this.load.spritesheet('stand', '../img/phaser/Sprite_stand.png', {
                frameWidth: 128, frameHeight: 128
            });
            this.load.spritesheet('walk', '../img/phaser/Sprite_walk.png', {
                frameWidth: 128, frameHeight: 128
            });
            this.add.image(0, 0, 'stand', 0)
            this.add.image(0, 0, 'walk', 0)
            console.log(spriteStand)

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
            }.bind(this));
        }
        create() {
            this.sound.add('musicStart').play({ volume: 0.3, loop: true });
            const map = this.make.tilemap({ key: "map", tileWidth: 32, tileHeight: 32 });
            const tileset = map.addTilesetImage("mapani", "tiles", 32, 32, 0, 0);
            const layer_sea = map.createLayer("sea", tileset, 0, 0);
            const layer_island = map.createLayer("island", tileset, 0, 0);
            const layer_03 = map.createLayer("03", tileset, 0, 0);
            const layer_04 = map.createLayer("04", tileset, 0, 0);
            const layer_Detph1 = map.createLayer("Detph1", tileset, 0, 0);
            const layer_Detph2 = map.createLayer("Detph2", tileset, 0, 0);
            musicStart = this.sound.add('musicStart');
            musicSnow = this.sound.add('musicSnow');
            musicStore = this.sound.add('musicStore');
            musicBridge = this.sound.add('musicBridge');
            musicIsland = this.sound.add('musicIsland');
            musicLilRoom = this.sound.add('musicLilRoom');


            layer_collision = map.createLayer("collision", tileset, 0, 0);
            layer_sea.setScale(1.5);
            layer_island.setScale(1.5);
            layer_03.setScale(1.5);
            layer_04.setScale(1.5);
            layer_Detph1.setScale(1.5);
            layer_Detph2.setScale(1.5);
            layer_collision.setScale(1.5);
            layer_collision.setCollisionBetween(2710, 2715);
            layer_collision.setAlpha(0);
            layer_Detph1.setDepth(2);
            layer_Detph2.setDepth(3);


            //建立一個web socket 連線
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
                    "id": playerRefs.value.user.a_ID
                };
                vWebSocket.send(JSON.stringify(data));
            })
            //接收到訊息時
            vWebSocket.addEventListener('message', (e) => {
                messageBuffer = e.data;
                // 如果接收到的訊息還不完整，則繼續等待
                if (!isCompleteMessage(messageBuffer)) {
                    return;
                }

                let result = JSON.parse(messageBuffer);
                messageBuffer = '';
                switch (result.type) {
                    case "Load":
                        console.log("Load");
                        // leftSideBtn.visibility = 'visible';
                        // waypoint.visibility = 'visible';
                        // moneypoint.visibility = 'visible';
                        // elecpoint.visibility = 'visible';
                        // lifepoint.visibility = 'visible';
                        // sportspoint.visibility = 'visible';
                        myVideo.style.visibility = 'hidden';
                        remoteVideo.style.visibility = 'hidden';
                        btnCamera.style.visibility = 'hidden';
                        btnMic.style.visibility = 'hidden';
                        btnLeave.style.visibility = 'hidden';
                        waitingLog.style.visibility = 'hidden';
                        extendBtnContainer.style.visibility = 'hidden'
                        if (this.player) {
                            this.player.destroy();
                        }
                        cleanAllPlayers();
                        for (let i = 0; i < result.client.length; i++) {
                            this.AddPlayer(result.client[i]);
                        }
                        LoadMap(result);
                        P_PubMap = mapData.src;
                        break;
                    case "Chat":
                        //訊息屬性Chat

                        const content = document.getElementById("dialog-body");
                        const timecontent = document.getElementById("dialog-time");
                        var today = new Date();
                        var date = today.getDate();
                        var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
                        var dateTime = date + ' ' + time;
                        let message = `${result.client.name}: ${result.content}`;
                        timecontent.innerText = timecontent.innerText + '\r\n' + dateTime;
                        console.log(content)
                        content.innerText = content.innerText + '\r\n' + message;
                        break;
                    case "Connect":
                        //訊息屬性是Connect
                        if (IDempty) {
                            playerRef.id = result.id;
                            IDempty = false;
                        }

                        this.AddPlayer(result);
                        console.log(result.id + " has logged in")
                        break;
                    case "Disconnect":
                        remoteVideo.style.visibility = 'hidden';
                        dcPlayer(result.PlayerRef)
                        break
                    case "Movement":
                        this.setDirection(result);


                        break
                    case "Match":
                        isQueue = false;
                        alert("配對成功!");
                        // leftSideBtn.visibility = 'hidden';
                        // waypoint.visibility = 'hidden';
                        // moneypoint.visibility = 'hidden';
                        // elecpoint.visibility = 'hidden';
                        // lifepoint.visibility = 'hidden';
                        // sportspoint.visibility = 'hidden';
                        extendBtnContainer.visibility = 'visible';
                        myVideo.style.visibility = 'visible';
                        remoteVideo.style.visibility = 'visible';
                        btnCamera.style.visibility = 'visible';
                        btnMic.style.visibility = 'visible';
                        btnLeave.style.visibility = 'visible';
                        waitingLog.style.visibility = 'hidden';
                        LoadMap(result);
                        this.player.destroy();
                        cleanAllPlayers();
                        for (let i = 0; i < result.client.length; i++) {
                            this.AddPlayer(result.client[i]);
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
                        waitingLog.style.visibility = 'visible';
                        isQueue = true;
                        break
                    case "Peer":
                        result.description = JSON.parse(result.description);
                        result.candidate = JSON.parse(result.candidate);
                        MatchPlayer(result);
                        break
                }
            })

            //關閉連線時
            vWebSocket.addEventListener("close", (_e) => {
                IDempty = true;
                console.log("connection closed");
            });
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
            cursors = this.input.keyboard.createCursorKeys();
        }

        update() {
            if (this.player != null) {
                this.player.setVelocityY(0);
                this.player.setVelocityX(0);
                var keyW = this.input.keyboard.addKey('W');
                var keyS = this.input.keyboard.addKey('S');
                var keyA = this.input.keyboard.addKey('A');
                var keyD = this.input.keyboard.addKey('D');

                if (cursors.up.isDown) {
                    this.handleArrowPress(0, -1);
                    if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                        this.player.anims.play('walk_anim');
                    }
                    this.cameras.main.scrollY -= 4;
                }
                else if (cursors.down.isDown) {
                    this.handleArrowPress(0, 1);
                    if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                        this.player.anims.play('walk_anim');
                    }
                    this.cameras.main.scrollY += 4;
                }
                else if (cursors.left.isDown) {
                    this.handleArrowPress(-1, 0);
                    if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                        this.player.anims.play('walk_anim');
                    }
                    this.cameras.main.scrollX -= 4;
                    this.player.flipX = true;
                }
                else if (cursors.right.isDown) {
                    this.handleArrowPress(1, 0);
                    if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                        this.player.anims.play('walk_anim');
                    }
                    this.cameras.main.scrollX += 4;
                    this.player.flipX = false;
                }
                else {
                    this.handleArrowPress(0, 0);
                    this.player.anims.play('stand_anim', true);
                }
            }
        }
        render() {
            this.debug.cameraInfo(this.cameras.main, 32, 32);
        }
    }
    function teleport(target) {
        var points = {
            start: { x: 9728, y: 6912 },
            money: { x: 4576, y: 2496 },
            elec: { x: 9568, y: 2400 },
            sports: { x: 5248, y: 11520 },
            life: { x: 4576, y: 6816 }
            // lilRoom: { x: 8795, y: 10810 }
            // lilRoom2: { x: 8735, y: 10810 }
            // 45
        };
        var musicbase = {
            start: 'musicStart',
            money: 'musicSnow',
            elec: 'musicStore',
            sports: 'musicBridge',
            life: 'musicIsland',
        }
        var waypoint = points[target];
        var musicPlay = musicbase[target];
        if (waypoint) {
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
                    this.sound.stopAll();
                    this.sound.add(musicPlay).play({ volume: 0.3, loop: true });
                    this.tweens.add({
                        targets: this.mask,
                        alpha: 0,
                        duration: 500,
                        onComplete: function () {
                            this.mask.destroy();
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
    var game;
    game = new Phaser.Game(config);
    // watchEffect(() => {
    //     if (playerRefs.value.isPlay) {
    //         game = new Phaser.Game(config);
    //     }

    // });



}
