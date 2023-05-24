<script setup>
// import HelloWorld from "./components/HelloWorld.vue";
import { reactive, ref, onMounted, } from "vue";
import Phaser from './components/Phaser.vue';
import Modal from './components/Shop/Modal.vue'
import { fuck, playerRefs } from "./main.js";
import Sandy from "./components/Sandy.vue";
import profilePic from './img/625157.jpg';
// import './js/dialogue';
import Account from "./components/Account.vue"
const currentBody = ref(Sandy);

const isSussess = ref(false);
onMounted(() => {
    getAccountDTOes();
    // dialog
});

const memberpoints = ref(1000);
const accountA_ID = ref(1);

const closeableModal = ref(false);

const updatePoints = (modalpoints) => {
    memberpoints.value = modalpoints.value;
}

// 原先讀取會員資訊，若沒有可以砍掉
const getAccountDTOes = () => {

}

//確認商城開啟關掉鏡頭
const Checkshow = () => {
    if (closeableModal.value == false) {
        closeableModal.value = true;
    }
    else {
        closeableModal.value = false;
    }
}

// 顯示遊戲介面
const Change = () => {
    if (playerRefs.value.isPlay == false) {
        currentBody.value = Phaser
        playerRefs.value.isPlay = true;
    } else {
        playerRefs.value.isPlay = false;
        currentBody.value = Sandy;
    }
}
const isss = playerRefs.value.isPlay;
const showDialog = ref(true);

const showDialogBool = () => {
    showDialog.value = true;
}

const hideDialog = () => {
    showDialog.value = false;
}

const handleKeyPress = (event) => {
    if (event.key === 'Enter' && showDialog.value) {
        hideDialog();
    } else if (event.key === 'Enter' && !showDialog.value) {
        showDialog();
    }
}
</script>

<template>
    <div>
        <Account v-if="isSussess" />
    </div>
    <div>
        <header class="border-bottom">
            <div class="container">
                <div class="div-nav d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                    <i class="fa-solid fa-kiwi-bird fa-shake fa-xl"></i>

                    <ul class=" nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                        <ul><a @click="Change" type="button" class="nav-link px-2 rounded-2">遊戲王</a></ul>
                        <li><a href="#" class="nav-link px-2 link-secondary rounded-2">首頁</a></li>
                        <li><a @click="closeableModal = true" type="button" class="nav-link px-2 rounded-2 ">商城</a>
                            <Modal :accountA_ID="accountA_ID" :memberpoints="memberpoints" v-model="closeableModal"
                                closeable header="商城" @update-points="updatePoints">
                            </Modal>
                        </li>
                        <!-- <li><a href="#" class="nav-link px-2 link-secondary">首頁</a></li> -->
                        <!-- <li><a href="#" class="nav-link px-2 link-dark">商城</a></li> -->
                        <!-- <li><a href="#" class="nav-link px-2 link-dark">衣櫥</a></li> -->
                        <li><a type="button" class="nav-link px-2 rounded-2 ">衣櫥</a></li>
                    </ul>

                    <div class="ms-auto dropdown text-end">
                        <a href="#" class="d-block link-dark text-decoration-none dropdown-toggle" id="dropdownUser1"
                            data-bs-toggle="dropdown" aria-expanded="false">
                            <img :src="profilePic" width="32" height="32" class="rounded-circle">
                        </a>
                        <ul class="dropdown-menu text-small" aria-labelledby="dropdownUser1">
                            <li><a class="dropdown-item" href="#">帳戶設定</a></li>
                            <li><a class="dropdown-item" href="#">個人檔案</a></li>
                            <li>
                                <hr class="dropdown-divider">
                            </li>
                            <li><a class="dropdown-item" href="#">登出</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </header>
        <div class="div-sidebar">

            <div class="d-flex flex-column flex-shrink-0 p-3 text-white bg-dark" style="width: 280px;">
                <a href="/" class="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-white text-decoration-none">
                    <svg class="bi me-2" width="40" height="32">
                        <use xlink:href="#bootstrap" />
                    </svg>
                    <span class="fs-4">Sidebar</span>
                </a>
                <hr>
                <ul class="nav nav-pills flex-column mb-auto">
                    <li class="nav-item" id="waypoint">
                        <a href="#" class="nav-link active" aria-current="page">
                            <svg class="bi me-2" width="16" height="16">
                                <use xlink:href="#home" />
                            </svg>
                            出生點
                        </a>
                    </li>
                    <li id="moneypoint">
                        <a href="#" class="nav-link text-white">
                            <svg class="bi me-2" width="16" height="16">
                                <use xlink:href="#speedometer2" />
                            </svg>
                            金融板
                        </a>
                    </li>
                    <li id="elecpoint">
                        <a href="#" class="nav-link text-white">
                            <svg class="bi me-2" width="16" height="16">
                                <use xlink:href="#table" />
                            </svg>
                            電子板
                        </a>
                    </li>
                    <li id="sportspoint">
                        <a href="#" class="nav-link text-white">
                            <svg class="bi me-2" width="16" height="16">
                                <use xlink:href="#grid" />
                            </svg>
                            體育板
                        </a>
                    </li>
                    <li id="lifepoint">
                        <a href="#" class="nav-link text-white">
                            <svg class="bi me-2" width="16" height="16">
                                <use xlink:href="#people-circle" />
                            </svg>
                            生活板
                        </a>
                    </li>
                    <label for="player-name">Your Name</label>
                    <input id="player-name" maxlength="10" type="text" />
                    <button id="player-color">Change Color</button>
                    <button id="joinBtn">JoinQueue</button>
                    <button id="btnLeave">Leave Room</button>
                    <button id="btnCamera">CameraOn</button>
                    <button id="btnMic">MicOn</button>
                </ul>
                <hr>
                <div class="dropdown">
                    <a href="#" class="d-flex align-items-center text-white text-decoration-none dropdown-toggle"
                        id="dropdownUser1" data-bs-toggle="dropdown" aria-expanded="false">
                        <img :src="profilePic" alt="" width="32" height="32" class="rounded-circle me-2">
                        <strong>mdo</strong>
                    </a>
                    <ul class="dropdown-menu dropdown-menu-white text-small shadow" aria-labelledby="dropdownUser1">
                        <li><a class="dropdown-item" href="#">New project...</a></li>
                        <li><a class="dropdown-item" href="#">Settings</a></li>
                        <li><a class="dropdown-item" href="#">Profile</a></li>
                        <li>
                            <hr class="dropdown-divider">
                        </li>
                        <li><a class="dropdown-item" href="#">Sign out</a></li>
                    </ul>
                </div>
            </div>

            <div class="phaser_area">
                <!-- <div :style="{ zIndex: closeableModal ? 0 : 999 }" v-show="!closeableModal">
                    <video width="200" height="200" autoplay id="myVideo" muted playsinline
                        :style="{ zIndex: closeableModal ? 0 : 999 }" v-show="!closeableModal"></video>

                    <video width="500" height="500" autoplay id="remoteVideo" playsinline
                        :style="{ zIndex: closeableModal ? 0 : 999 }" v-show="!closeableModal"></video>
                </div> -->
                <!-- <div class="game-container"></div> -->

       
                <div class="phaser_gamearea " id="gameArea">
                    <component :is="currentBody"></component>
                </div>
            </div>
        </div>
        <div id="dialog-box" :style="{ display: showDialog ? 'flex' : 'none' }">
            <div class="dialog-header">
                <span class="dialog-title">對話視窗</span>
                <span class="dialog-close-btn" @click="hideDialog">x</span>
            </div>
            <div class="dialog">
                <div id="dialog" class="dialog-body"></div>
                <div id="dialog-time" class="dialog-time"></div>
            </div>
            <div class="dialog-footer">
                <input type="text" id="dialog-input" @keypress.enter="handleKeyPress" placeholder="請輸入訊息">
                <button id="dialog-send-btn">發送</button>
            </div>
        </div>
    </div>
</template>
  
<style src="./css/index.css"></style>
<style src="./css/sidebars.css"></style>
<style src="./css/style.css"></style>
<style src="./css/phaser_gamemode.css"></style>
<style scoped></style>