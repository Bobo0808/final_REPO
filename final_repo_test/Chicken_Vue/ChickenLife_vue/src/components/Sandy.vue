<script setup>
import { onMounted, ref } from "vue";
import { getAxios, playerRefs } from "../main.js";
const backdropClick = (event) => {
  if (event.target.id == "backdrop" && props.closeable == true) {
    emit("update:modelValue", false);
  }
};
const userdata = ref([]);
const userId = ref("");
let route = ref();
const router = "/api/wardrobe/details/";




const position = ref(96);
const sprites = document.querySelectorAll(".sprite");
const interval = 100;
const SpriteForP = () => {
  setInterval(() => {
    //sprites.forEach(sprite => {
    // 判斷是否超出精靈圖的寬度，若超出則重置為起始位置
    if (position.value < 384) {
      position.value += 96;
      // console.log("position=>", position);
    } else {
      position.value = 96;
    }
    // sprite.style.backgroundPosition = `-${position}px 0px`;
    //});
  }, interval);

  // requestAnimationFrame(SpriteForP);
};

onMounted(() => {
  SpriteForP();
});

const getData = async () => {
  route.value = router + playerRefs.value.user.a_ID;
  // route.value = router + userId.value;
  await getAxios(route, userdata);
  console.log(userId.value);
  console.log(route.value);
  console.log('userdata.value');
  console.log(userdata.value);
};
const deleteData = async () => {

};
// import {ref} from "vue";

const showModel = ref(false)

</script>

<template>
<main>
  <div v-show="showModel" class="overlay">

    <div class="modal">
      <div>
    <!-- <input type="text" v-model="userId" placeholder="輸入 User ID" /> -->
    <!-- <button @click="getData">詳細資料</button> -->
    <!-- <div v-if="{ userdata }"> -->
      <!-- <div v-for="(user,i) in userdata" :key="userdata[i]"> -->
        <div>使用者:{{ user }}</div>
        <button @click="getData">詳細資料</button>
        <table class="table">
          <thead>
            <tr>
              <th scope="col">訂單編號</th>
              <th scope="col">產品編號</th>
              <th scope="col">產品名稱</th>
              <th scope="col">產品圖</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(order, j) in userdata.orderID" :key="j">
              <td>
                <div>{{ parseInt(order) }}</div>
              </td>
              <td>
                <div v-for="(productID, k) in userdata.productID" :key="k">
                  <div v-if="k === j">{{ parseInt(productID) }}</div>
                </div>
              </td>
              <td>
                <div
                  v-for="(productName, l) in userdata.productName"
                  :key="productName[l]"
                >
                  <div v-for="ptempName in productName" :key="ptempName">
                    <div v-if="l === j">{{ ptempName }}</div>
                  </div>
                </div>
              </td>
              <td>
                <div
                  v-for="(productimage, m) in userdata.productImage"
                  :key="m"
                >
                  <div v-if="m === j">
                    <!-- <img
                      :src="productimage"
                      alt=""
                      style="width: 200px; height: 150px"
                    /> -->
                    <p class="sprite ms-sm-4 ms-0" :style="`background-image: url(${productimage}); background-position: ${position}px 0;`" />
                  </div>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    <!-- </div> -->
    <!-- <div v-else>Loading...</div> -->
  <!-- </div> -->
      <!-- <button>Add Note</button> -->
      <!-- <button @click="getData">詳細資料</button> -->
      <button class="close" @click="showModel=false">Close</button>
    </div>
  </div>

  <div class="container">
    <!-- <header> -->
      <!-- <button @click="showModel=true" style="">衣櫥</button> -->
    <h4 @click="showModel=true">衣櫥</h4>
    <!-- </header> -->
  </div>

</main>
</template>

<style scoped>
td{
  height: 200px;
}
.sprite {
  width: 96px;
  height: 96px;
  transform: scale(1.5);
  transform-origin: top left;
}
h4{
color: black;
font-size: 18px;
font-weight:bold;
width: 300px;
margin: 0;
padding: 0;
}

main{
  height: 100vh;
  width: 100vw;
}
  .container{
    max-width: 100px;
    padding: 10px;
  }
  header{
    display: flex;
    justify-content: space-between;
    align-items: center;
  }
  h1{
    font-weight: bold;
    margin-bottom: 25px;
    font-size: 75px;
  }
  header button{
    border: none;
    padding: 10px ;
    width: 80px;
    height: 50px;
    cursor: pointer;
    /* background-color:rgb(21, 20, 20); */
    /* border-radius: 100%; */
    color: black;
    font-size: 20px;
  }
  .card{
    width: 225px;
    height: 225px;
    /* background-color: rgb(237, 182,  44); */
    padding: 10px;
    border-radius: 15px;
    display: flex;
    flex-direction: column; 
    justify-content: space-between;
    margin-right: 20px;
    margin-bottom: 20px;
  }
  .date{
    font-size: 12.5px;
    font-weight: bold ;
  }
  .cards-container{
    display: flex;
    flex-wrap: wrap;
  }
  .overlay{
    position: absolute;
    width: 100%;
    height: 100%;
    /* background-color: rgba(0, 0, 0, 0.77); */
    z-index: 10;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .modal{
    width: 750px;
    background-color: white;
    border-radius: 15px;
    padding: 30px;
    position: relative;
    display: flex;
    flex-direction: column;
    overflow: auto;
  }
  .modal::-webkit-scrollbar {
  width: 8px; /* 滚动条宽度 */
}

.modal::-webkit-scrollbar-track {
  background-color: #8a8a8a; /* 滚动条背景颜色 */
}

.modal::-webkit-scrollbar-thumb {
  background-color: #dddddd; /* 滚动条滑块颜色 */
}

.modal::-webkit-scrollbar-thumb:hover {
  background-color: #292929; /* 滚动条滑块鼠标悬停颜色 */
}
  .modal button{
    padding:10px 20px ;
    font-size: 20px;
    width: 150px;
    background-color: blueviolet;
    border:none;
    color:white;
    cursor: pointer;
    margin-top: 15px;
  }
.modal .close{
  background-color: rgb(193, 15, 15) ;
  margin-top: 7px;
}
</style>