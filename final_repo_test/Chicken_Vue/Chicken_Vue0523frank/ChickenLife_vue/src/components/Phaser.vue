
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
    // SpriteForP();
});

const getPlay = () => {
    // const value = playerRef.value.isPlay; // 獲取需要傳遞的值
    // startGame(value); // 傳遞值給遊戲啟動函式
}

</script>

<template lang="">
    <div>
        <div class="phaser_gamearea" id="gameArea"></div>
    </div>
</template>

<style>
/* Characters */
.grid-cell {
    position: absolute;
    width: 16px;
    height: 16px;
}

.Character {
    transition: transform 0.4s;
}

.Character.you {
    z-index: 1;
}

.Character.you .Character_you-arrow {
    display: block;
}

.Character_you-arrow {
    display: none;
    position: absolute;
    top: -18px;
    left: 5px;
    width: 7px;
    height: 5px;
    background: url(./images/arrow.png) no-repeat no-repeat;
}

.Character_sprite {
    overflow: hidden;
    top: -3px;
    background: url(./images/characters.png);
}

.Character[data-direction="right"] .Character_sprite {
    background-position-x: 16px;
}

.Character[data-color="red"] .Character_sprite {
    background-position-y: -16px;
}

.Character[data-color="orange"] .Character_sprite {
    background-position-y: -32px;
}

.Character[data-color="yellow"] .Character_sprite {
    background-position-y: -48px;
}

.Character[data-color="green"] .Character_sprite {
    background-position-y: -64px;
}

.Character[data-color="purple"] .Character_sprite {
    background-position-y: -80px;
}

.Character_shadow {
    background: url(./images/shadow.png) no-repeat no-repeat;
}

.Character_name-container {
    position: absolute;
    opacity: 90%;
    top: -12px;
    font-size: 5px;
    padding: 1px 2px 1px;
    border-radius: 3px;
    background: #333;
    color: white;
    font-weight: bold;
    text-transform: uppercase;
    white-space: nowrap;
}

/* .Character_coins {
  margin-left: 1px;
  color: gold;
} */

/* Coins */
.Coin_sprite {
    background: url(./images/coin.png) no-repeat no-repeat;
    animation: coinFloat 0.8s linear infinite alternate-reverse;
}

@keyframes coinFloat {
    from {
        transform: translateY(0)
    }

    to {
        transform: translateY(5px)
    }
}

.Coin_shadow {
    background: url(./images/coin-shadow.png) no-repeat no-repeat;
}

.phaser_area {
    width: 100%;
    height: 100%;
}

@media (min-width: 768px) {
    .bd-placeholder-img-lg {
        font-size: 3.5rem;
    }
}

:root {
    --header-height: 56px;
}
</style>