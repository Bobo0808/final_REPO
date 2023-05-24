
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
    <div>
        
        <div class="phaser_area">
                <div :style="{ zIndex: closeableModal ? 0 : 999 }" v-show="!closeableModal">
                    <video width="200" height="200" autoplay id="myVideo" muted playsinline
                        style=" z-index: 999 " v-show="!closeableModal"></video>
                    <video width="500" height="500" autoplay id="remoteVideo" playsinline
                        style="z-index: 999 " v-show="!closeableModal"></video>
                </div>
                <div class="game-container"></div>


                <div class="phaser_gamearea " id="gameArea">
                    <component :is="currentBody"></component>
                </div>
            </div>
        <div class="phaser_gamearea" id="gameArea"></div>
    </div>
</template>

<style></style>