<script setup>
import { onMounted, ref } from "vue";
import { getAxios } from "../main.js";

const userdata = ref([]);
const userId = ref("");
let route = ref();
const router = "/api/wardrobe/details/";
const getData = async () => {
  route.value = router + userId.value;
  console.log(userId.value);
  console.log(route.value);
  console.log(userdata.value);
  await getAxios(route, userdata);
};
</script>

<template>
  <div>
    <input type="text" v-model="userId" placeholder="輸入 User ID" />
    <button @click="getData">詳細資料</button>
    <div v-if="{ userdata }">
      <div v-for="(user, i) in userdata.userID" :key="user[i]">
        <div>使用者:{{ user }}</div>

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
                    <img
                      :src="productimage"
                      alt=""
                      style="width: 200px; height: 150px"
                    />
                  </div>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
    <div v-else>Loading...</div>
  </div>
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
  width: 90%;
}

.tab-tilte li {
  float: left;
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
.table {
  margin-top: 50px;
}
</style>

