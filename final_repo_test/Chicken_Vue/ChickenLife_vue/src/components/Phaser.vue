
<script setup>
import { onMounted, ref, watch, toRaw } from 'vue';
import { playerRefs } from "../main.js";

const emit = defineEmits();
const props = defineProps({
    LoginStatus: {
        type: Boolean,
        required: true,
        default: false
    },
    memberpoints: {
        type: Number,
        required: false,
        default: 0
    },
    accountA_ID: {
        type: Number,
        required: true,
        default: 0
    }
})
onMounted(() => {
    getPlay();
    // phaserArcade();
    // phaser();
    // backgame();
    // SpriteForP();
});

const getPlay = () => {
    // const value = playerRef.value.isPlay; // 獲取需要傳遞的值
    // startGame(value); // 傳遞值給遊戲啟動函式
}

</script>

<template lang="">
     <div class="phaser_area">
      <div style="z-index: 999;">
        <video autoplay id="myVideo" muted playsinline></video>
        <video autoplay id="remoteVideo" playsinline></video>
      </div>
      <div class="game-container"></div>
      <div class="phaser_gamearea " id="gameArea"></div>
    </div>
    <div id="fixBtnDiv">
      <div class="leftSideBtn">
        <button id="waypoint"></button>
        <button id="moneypoint"></button>
        <button id="elecpoint"></button>
        <button id="sportspoint"></button>
        <button id="lifepoint"></button>
      </div>
      <div class="rightSideBtn">
        <button id="joinBtn"></button>
        <button id="waitingLog"></button>
        <div id="extendBtnContainer">
          <button id="btnLeave"></button>
          <button id="btnCamera"></button>
          <button id="btnMic"></button>
        </div>
    </div>
    <div id="dialog-box">
    <div class="dialog-header">
      <span class="dialog-title">對話視窗</span>
      <span class="dialog-close-btn">x</span>
    </div>
    <div class="dialog">
      <div id="dialog" class="dialog-body"></div>
      <div id="dialog-time" class="dialog-time"></div>
    </div>
    <div class="dialog-footer">
      <input type="text" id="dialog-input" placeholder="請輸入訊息">
      <button id="dialog-send-btn">發送</button>
    </div>
</div>
  </div>
  
</template>
<style src="../css/index.css"></style>
<style src="../css/sidebars.css"></style>
<style src="../css/style.css"></style>
<style src="../../public/css/phaser_gamemode.css"></style>
<style></style>