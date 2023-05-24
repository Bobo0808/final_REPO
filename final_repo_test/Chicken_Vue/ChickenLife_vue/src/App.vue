<script setup>
// import HelloWorld from "./components/HelloWorld.vue";
import { reactive, ref, onMounted, } from "vue";
import Phaser from './components/Phaser.vue';
import Modal from './components/Shop/Modal.vue'
import { fuck, playerRefs } from "./main.js";
import Sandy from "./components/Sandy.vue";
import profilePic from './img/625157.jpg';
// import './js/dialogue.js';
import Account from "./components/Account.vue"

const currentBody = ref(Phaser);


const closeableModal = ref(false);

playerRefs.value.isPlay = true;
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
    <header class="border-bottom">
        <div class="container">
            <div class="div-nav d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <i class="fa-solid fa-kiwi-bird fa-shake fa-xl"></i>

                <ul class=" nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    <ul><a @click="Change" type="button" class="nav-link px-2 rounded-2">遊戲王</a></ul>
                    <li><a href="#" class="nav-link px-2 link-secondary rounded-2">首頁</a></li>
                    <li><a @click="Checkshow" type="button" class="nav-link px-2 rounded-2 ">商城</a>
                        <Modal v-model="closeableModal" closeable header="商城">
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

        <div class="d-flex flex-column flex-shrink-0 p-3 text-white bg-dark sideyellow" style="width: 280px;">
            <a href="/" class="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-white text-decoration-none">
                <svg class="bi me-2" width="40" height="32">
                    <use xlink:href="#bootstrap" />
                </svg>
                <span class="fs-4">好友</span>
            </a>
            <!-- <li id="lifepoint">
        <a href="#" class="nav-link text-white">
            <svg class="bi me-2" width="16" height="16">
                <use xlink:href="#people-circle" />
            </svg>
            生活板
        </a>
        </li> -->

            <hr>
        </div>
        <Phaser></Phaser>
        <!-- <component :is="currentBody" :closeableModal="closeableModal"></component> -->
    </div>
</template>
  
<style src="./css/index.css"></style>
<style src="./css/sidebars.css"></style>
<style src="./css/style.css"></style>
<style src="../public/css/phaser_gamemode.css"></style>
<!-- <style src="./css/dialogue.css"></style> -->
<style scoped></style>