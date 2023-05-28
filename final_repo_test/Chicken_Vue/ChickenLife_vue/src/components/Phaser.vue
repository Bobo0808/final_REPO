
<script setup>
import { onMounted, ref, watch, toRaw } from "vue";
import { playerRefs } from "../main.js";
import { phas } from "../js/back.js";
const emit = defineEmits();
const props = defineProps({
  LoginStatus: {
    type: Boolean,
    required: true,
    default: false,
  },
  memberpoints: {
    type: Number,
    required: false,
    default: 0,
  },
  closeableModal: {
    type: Boolean,
    default: false,
  },
});

onMounted(() => {
  phas();
});

const getPlay = () => {
  // const value = playerRef.value.isPlay; // 獲取需要傳遞的值
  // startGame(value); // 傳遞值給遊戲啟動函式
};
</script>
<template lang="">
     <div class="phaser_area">
      <!-- <div style="z-index: 999;"> -->
      <div :style="{ zIndex: !closeableModal ? '999' : '0' }" v-show="!props.closeableModal">
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
    <div id="dialog-box" ref="dialogBox">
      <div class="dialog-header">
        <span class="dialog-title">對話視窗</span>
        <span class="dialog-close-btn" id="dialog-close-btn" >x</span>
      </div>
      <div class="dialog" id="dialogBoo">
        <div class="dialog-body" id="dialog-body" ref="dialogBody"></div>
        <div class="dialog-time" id="dialog-time"></div>
      </div>
      <div class="dialog-footer">
        <input type="text" id="dialog-input" placeholder="請輸入訊息" @keydown.enter="handleKeyPress">
        <button id="dialog-send-btn" @click="sendMessage">發送</button>
      </div>
    </div>
  </div>
  
</template>
<style src="../css/index.css"></style>
<style src="../css/sidebars.css"></style>
<style src="../css/style.css"></style>
<style src="../../public/css/phaser_gamemode.css"></style>
<style scoped>
#dialog-box {
  display: flex;
  flex-direction: column;
  position: fixed;
  bottom: 0;
  left: 285px;
  width: 35%;
  height: 30%;
  background-color: rgba(0, 0, 0, 0.553);
  border: 1px solid gray;
  color: snow;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
  z-index: 9999;
  opacity: 100%;
  border-radius: 15px 15px 0px 0px;
}

.dialog-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 10px;
  background-color: #5d2d00b8;
  color: white;
  font-size: 20px;
  font-weight: bold;
  border-radius: 15px 15px 0px 0px;
}

.dialog-close-btn {
  cursor: pointer;
  font-size: 25px;
}

.dialog {
  overflow-y: auto;
  margin: 0px;
  padding: 10px;
  height: 100%;
}

/* 隱藏滾動條的預設樣式 */
.dialog::-webkit-scrollbar {
  width: 8px;
  background-color: #00000054;
}

/* 設置滾動條軌道的樣式 */
.dialog::-webkit-scrollbar-track {
  border-radius: 4px;
}

/* 設置滾動條的樣式 */
.dialog::-webkit-scrollbar-thumb {
  border-radius: 4px;
  background-color: rgba(254, 254, 254, 0.808)afa;
}

/* 滑鼠懸停在滾動條上時的樣式 */
.dialog::-webkit-scrollbar-thumb:hover {
  background-color: #dadada88;
}

.dialog-body {
  float: left;
}

.dialog-time {
  float: right;
}

.dialog-footer {
  display: flex;
  align-items: center;
  padding: 10px;
  border-top: 1px solid gray;
}

#dialog-input {
  flex: 1;
  margin-right: 10px;
  padding: 5px;
  border: none;
  background-color: #ffffffcd;
  border-bottom: 2px solid #1d3461;
  outline: none;
  font-size: 16px;
}

#dialog-send-btn {
  padding: 5px 10px;
  background-color: #5d2d00b8;
  color: white;
  border: none;
  border-radius: 3px;
  cursor: pointer;
  font-size: 16px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
}

.dialog-message {
  margin-bottom: 10px;
  padding: 5px 10px;
  border-radius: 5px;
  font-size: 16px;
}

.dialog-message-self {
  background-color: #1d3461;
  color: white;
  align-self: flex-end;
}

.dialog-message-other {
  background-color: #f2f2f2;
  color: black;
  align-self: flex-start;
}
</style>