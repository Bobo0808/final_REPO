const joinBtn = document.querySelector('.joinBtn');
let pc;
const myVideo = document.querySelector('#myVideo');
let localstream;


// 初始化影像/聲音
async function createMedia() {
    // 儲存本地流到全域
    localstream = await navigator.mediaDevices.getUserMedia({ audio: true, video: true })

    myVideo.srcObject = localstream;
};

// 取得裝置名稱
function getAudioVideo() {
    const video = localstream.getVideoTracks();
    const audio = localstream.getAudioTracks();

    if (video.length > 0) {
        console.log(`使用影像裝置 => ${video[0].label}`)
    };
    if (audio.length > 0) {
        console.log(`使用聲音裝置 => ${audio[0].label}`)
    };
}

// 建立 P2P 連接
function createPeerConnection() {
    const configuration = {
        iceServers: [{
            urls: 'stun:stun.l.google.com:19302' // Google's public STUN server
        }]
    };
    pc = new RTCPeerConnection(configuration);
};

// 增加本地流
function addLocalStream() {
    pc.addStream(localstream)
};

function joinRoom() {
    socket.emit('joinRoom', 'secret room');
};

joinBtn.addEventListener('click', joinRoom);