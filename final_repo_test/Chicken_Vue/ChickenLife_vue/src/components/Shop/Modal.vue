

<script setup>
import { onMounted, ref, watch } from "vue";
import Product from "../Product/Product.vue";
import Card from "../Product/Card.vue";
import Slide from "./Slide.vue";
import { playerRefs, baseAddress } from "../../main.js";
import CardAndOrder from "../Order/CardAndOrder.vue";
// const baseAddress = "https://localhost:7097";
const backdropClick = (event) => {
  if (event.target.id == "backdrop" && props.closeable == true) {
    emit("update:modelValue", false);
    // isDialogOpenWatch();
  }
};

const props = defineProps({
  modelValue: {
    type: Boolean,
    required: true,
    default: false,
  },
  closeable: {
    type: Boolean,
    required: false,
    default: false,
  },
  header: {
    type: String,
    required: false,
    default: null,
  },
  container: {
    type: String,
    required: false,
    default: null,
  },
  maxwidth: {
    type: String,
    required: false,
    default: null,
  },
});

onMounted(() => {
  // modalpoints.value = props.memberpoints;
  // isDialogOpenWatch
});
//監控會員點數
watch(() => {
  // playerRefs.value.coins;
  //  playerRefs.value.user.a_Coin;
});

const emit = defineEmits();

const isVisible = ref(false);

const cur = ref(0);

const modalpoints = ref(0);

// const isDialogOpen = ref(false);
// const isDialogOpenWatch = () => {
//     if (props.modelValue == true) {
//         isDialogOpen.value = true;
//     } else {
//         isDialogOpen.value = false;
//     }
// }

// const ProductupdatetoModal = (ProductPoints) => {
//     modalpoints.value = ProductPoints.value;
//     emit("update-points", modalpoints)
// };
// const CardupdatetoModal = (CardPoints) => {
//     modalpoints.value = CardPoints.value;
//     emit("update-points", modalpoints)
// };
</script>

<template>
  <teleport to="body">
    <transition name="fade">
      <div
        v-if="modelValue"
        class="pt-5 position-fixed top-0 start-0 h-100 w-100 shop"
        style="background-color: rgba(0, 0, 0, 0.25)"
      >
        <div id="backdrop" @click="backdropClick" class="centerformodal">
          <div
            class="card px-0 bkcolor"
            :class="container == null ? 'container' : `container-${container}`"
            :style="maxwidth != null ? `max-width: ${maxwidth}` : null"
          >
            <div class="card-header h2 test">
              <div class="float-start">
                {{ header }}
              </div>
              <div class="center-column">
                <!-- 點數: {{ modalpoints }} -->

                點數: {{ playerRefs.user.a_Coin }}
              </div>

              <button
                v-if="closeable"
                @click="$emit('update:modelValue', false)"
                class="btn btn-text float-end"
              >
                <strong>X</strong>
              </button>
            </div>
            <div>
              <ul class="tab-tilte p-0">
                <li @click="cur = 0" :class="{ active: cur == 0 }">廣告</li>
                <li @click="cur = 1" :class="{ active: cur == 1 }">商品</li>
                <li @click="cur = 2" :class="{ active: cur == 2 }">點數</li>
                <li @click="cur = 3" :class="{ active: cur == 3 }">訂單紀錄</li>
              </ul>
            </div>
            <div class="card-body tabwidth">
              <div class="tab-content">
                <div v-show="cur == 0">
                  <slot>
                    <Slide />
                  </slot>
                </div>
                <div v-show="cur == 1">
                  <slot>
                    <Product />
                  </slot>
                </div>
                <div v-show="cur == 2">
                  <slot>
                    <Card />
                  </slot>
                </div>
                <div v-show="cur == 3">
                  <slot>
                    <CardAndOrder />
                  </slot>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </transition>
    <!-- 遮罩層 -->
    <div v-if="isDialogOpenWatch" class=".dialog-overlay"></div>
  </teleport>
</template>


<style scoped>
.centerformodal {
  display: flex;
  justify-content: center;
}

.backdrop {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.25);
  pointer-events: none;
  /* 禁用點擊事件 */
}

.dialog-overlay {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.5);
  /* 設定透明度 */
  overflow: hidden;
  z-index: 999;
  /* 設定疊加順序，需高於其他元素 */
}

.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.5s;
}

.fade-enter-from,
.fade-leave-to {
  opacity: 0;
}

ul li {
  margin: 0;
  padding: 0;
  list-style: none;
}

.tab-tilte {
  /* width: 90%; */
  border: 1px solid black;
}

.tab-tilte li {
  float: left;
  justify-content: center;
  width: 25%;
  padding: 10px 0;
  text-align: center;
  background-color: #f4f4f4;
  cursor: pointer;
}

.tab-tilte .active {
  background-color: #09f;
  color: #fff;
}

/* .tab-content div{
float: left;
width: 25%;
line-height: 100px;
text-align: center;
}  */

.shop {
  /* overflow: auto; */
  /* height: 80%; */
  /* height: 800px; */
  overflow: hidden;
}

.center-column {
  /* 中間欄位的樣式 */
  margin: 0 auto;
  /* 將元素置於水平中間 */
  font-size: 20px;
}

.test {
  display: flex;
  justify-content: space-between;
  /* 將元素平均分佈在容器中 */
}

.tabwidth {
  height: 600px;
  overflow-y: auto;
  /* height: 80%; */
  /* overflow: auto; */
}

.bkcolor {
  background-color: #ededed;
}
</style>