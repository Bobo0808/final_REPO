<script setup>
import {onMounted, ref} from 'vue'
import { getAxios } from '../main.js';

const userdata = ref([]);
const userId = ref("");
let route = ref();
const router = '/api/wardrobe/details/';
// onMounted(async()=>{
//     await getAxios(route,userdata);

//     console.log(userdata.value)
// })
const getData = async()=>{
    route.value=router+userId.value
    console.log(userId.value)
    console.log(route.value)
    console.log(userdata.value)
    await getAxios(route,userdata);
    // for(let i = 0;i<userdata.productImage.count;i++){
    //     import qw from user.productImage[i];
    // }
    
}
</script>

<template>
    <div>
        <input type="text" v-model="userId" placeholder="輸入 User ID">
        <button @click="getData">詳細資料</button>
            <div v-if="{userdata}">
                <!-- <p>{{ userdata.userID}}</p> -->
                <div v-for="(user,i) in userdata.userID " :key="user[i]">
                    <div>使用者:{{ user}}</div>

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
        <div v-for="(productName, l) in userdata.productName" :key="productName[l]">
            <div v-for="ptempName in productName" :key="ptempName">
                            <div v-if="l === j">{{ ptempName }}</div>
                        </div>
        </div>

      </td>
      <td>
        <div v-for="(productimage, m) in userdata.productImage" :key="m">
          <div v-if="m === j">
            <img :src="productimage" alt="" style="width: 200px; height: 150px;">
          </div>
        </div>
      </td>
    </tr>
  </tbody>
  <!-- <tbody>
    <tr>
        <td>
            <div v-for="(order,j) in userdata.orderID" :key="order[j]">
                <div>{{order }}</div>
            </div>
        </td>

      <td>
            <div v-for="(productID,k) in userdata.productID" :key="productID[k]">
                        <div v-for="ptemp in productID" :key="ptemp">
                            <div>{{ptemp }}</div>
                        </div>
            </div>
        </td>

      <td>
            <div v-for="(productName,l) in userdata.productName" :key="productName[l]">
                        <div v-for="ptempName in productName" :key="ptempName">
                            <div>{{ ptempName }}</div>
                        </div>
            </div>
        </td>

      <td>
            <div v-for="(productimage,m) in userdata.productImage" :key="productimage[m]">
                        <div v-for="ptempImage in productimage" :key="ptempImage">
                            <div>產品圖:{{ ptempImage }}</div>
                            <img :src="`C:\\Users\\iSpan\\Desktop\\img\\${ptempImage}`" alt="">
                            <img :src="ptempImage" alt="" style="width: 200px; height: 150px;">
                        </div>
            </div>
        </td>
    </tr>
  </tbody> -->
</table>
                
                    
                    <!-- <div v-for="u in user" :key="u">
                        <div v-for="uu in user" :key="uu">
                        <div>{{ uu }}</div>
                    </div>
                        <div>{{ u }}</div>
                    </div> -->
                </div>
                <!-- <h2>User ID: {{ userData.userID }}</h2>
                <h3>Order IDs:</h3>
                <ul>
                    <li v-for="orderID in userData.orderID" :key="orderID">{{ orderID }}</li>
                </ul>
                <h3>Product Details:</h3>
                <div v-for="(product, index) in userData.productID" :key="index">
                    <h4>Order {{ index + 1 }}</h4>
                    <ul>
                        <li v-for="(name, subIndex) in userData.productName[index]" :key="subIndex">{{ name }}</li>
                    </ul>
                    <div v-for="(image, subIndex) in userData.productImage[index]" :key="subIndex">
                        <img :src="image" alt="Product Image" />

                    </div>
                </div> -->
            </div>
            <div v-else>
                Loading...
            </div>
        </div>
</template>

<style scoped>
</style>
