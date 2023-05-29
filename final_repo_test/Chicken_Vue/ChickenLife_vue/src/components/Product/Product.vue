<script setup>
import { onMounted, ref, watch, inject, toRaw } from "vue";
import {
  playerRefs,
  baseAddress,
  getAxios,
  postAxiosString,
  postAxiosObjNodata,
} from "../../main.js";
// import { playerRefs } from "../../main.js";
// const baseAddress = "https://localhost:7097";
// const baseAddress = "https://localhost:7093";
const employeeDTOes = ref([]);

const DiscountPrice = ref(0);

// 購買商品
const isDialogOpen = ref(false);
const selectedProduct = ref(null);

// 關掉
const showInsufficientPoints = ref(false);

// 取orderID
const OrderID = ref(0);
const OrderDTO = ref(null);
// 圖片移動像素值
const position = ref(96);

const emit = defineEmits();
const props = defineProps({
  modelValue: {
    type: Boolean,
    required: true,
    default: false,
  },
});

const getEmployeeDTOes = () => {
  // getAxios("/api/Products", employeeDTOes);
  // console.log(employeeDTOes);
  // console.log("playerRefs.value.user.a_Coin=>",playerRefs.value.user.a_Coin);
  // console.log(playerRefs.value);
  //原本axios呼叫指令碼
  axios.get(`${baseAddress}/api/Products`).then((response) => {
    //alert(JSON.stringify(response.data));
    employeeDTOes.value = response.data;
    // console.log(employeeDTOes.value);
  });
};

onMounted(() => {
  getEmployeeDTOes();
  SpriteForP();

  // 獲取按鈕元素
  const radioButton = document.getElementById("btnradio1");
  // 設置 checked 屬性
  radioButton.checked = true;
});
watch(() => {
  // playerRefs.value.coins;
  playerRefs.value.user.a_Coin;
});
const OpenorClose = () => {
  if (props.modelValue === true) {
    getEmployeeDTOes();
  }
};

const imageUrl = (url) => {
  // console.log(url);
  // const imgPath = `/src/assets/img/producttest/${url}`;
  // const imgUrl = new URL(imgPath, import.meta.url).href;
  // console.log(imgUrl);
  return url;
};

// 選取所有的 .sprite 元素
// Sprite
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

// 計算價格
const DiscountMoney = (Price, Discount) => {
  const DiscountPrice = parseInt(Price) - parseInt(Discount);
  return DiscountPrice;
};

// 購買商品
const openDialog = async (pt) => {
  // console.log("pt.target.id=>",pt.target.id);
  try {
    //fuck();
    // const product = {};
    // 從後端獲取商品資料
    const response = await axios.get(
      `${baseAddress}/api/Products/${pt.target.id}`
    ); // 假設商品 ID 為 123
    // await getAxios(`/api/Products/${pt.target.id}`, product); // 假設商品 ID 為 123
    // CheckPoints();
    const product = response.data;

    // 設定選中的商品
    selectedProduct.value = product;
    // console.log('selectedProduct.value=>', selectedProduct.value);
    isDialogOpen.value = true;
    // console.log(selectedProduct.value);
  } catch (error) {
    console.error("讀取商品資料失敗:", error);
  }
};
const closeDialog = () => {
  isDialogOpen.value = false;
  selectedProduct.value = null;
};

const Product=ref(true);
const confirmPurchase = async(ID, Price, Discount, img) => {
  // console.log("Product.value2=>",Product.value);
  // console.log("bool=>",CheckAccountProduct(ID,playerRefs.value.user.a_ID))
  if(await CheckAccountProduct(ID,playerRefs.value.user.a_ID)==false){
      if (playerRefs.value.user.a_Coin >= Price) {
      // 點數足夠，執行購買邏輯
      OrderAdd(ID, Price, Discount);

      // 扣除點數
      playerRefs.value.user.a_Coin-= Price;

      // 更新點數
      ChangeAccountCoins(playerRefs.value.user.a_Coin);

      // 購買完成後關閉彈出視窗
      closeDialog();
    } else {
      // 點數不足，顯示提示框
      showInsufficientPoints.value = true;
    }
  }else{
    alert("你已買過此商品");
  }
  
};
// 確認此會員是否重複購買訂單衣服
const  CheckAccountProduct= async(P_ID,A_ID)=>{
  var request = {};
  request.A_ID = A_ID;
  request.P_ID = P_ID;
  await axios.post(`${baseAddress}/api/Order/FilterAPID`, request).then((response) => {
    Product.value=response.data;
    console.log("Product.value=>",Product.value);
    // console.log("Product=>",Product);
  });

  return Product.value;


}


//修改會員點數
const ChangeAccountCoins = (coins) => {
  var test = {};
  var request = {};
  // request.A_ID = playerRefs.value.id;
  request.A_ID = playerRefs.value.user.a_ID;
  request.A_Coin = coins;
  postAxiosObjNodata(`/api/User/Update/${playerRefs.value.user.a_ID}`, request, test);
};

const closeInsufficientPointsDialog = () => {
  showInsufficientPoints.value = false;
};

const OrderAdd = (ID, Price, Discount) => {
  //Order
  var request = {};
  var requestdetail = {};
  const finalPrice = DiscountMoney(Price, Discount);
  request.O_ID = 0;
  request.A_ID = playerRefs.value.user.a_ID;
  request.O_Date = new Date();
  request.O_TotalPrice = finalPrice;
  request.O_Cancle = false;
  request.ProductName = "";
  //postAxios(`/api/Order`, request);
  // console.log(request);
  axios.post(`${baseAddress}/api/Order`, request).then((response) => {
    // console.log("success");
    // console.log("response.data=>", response.data);
    axios
      .get(`${baseAddress}/api/Order/GET/${playerRefs.value.user.a_ID}`)
      .then((response) => {
        OrderID.value = response.data;
        //console.log("OrderID.value=>", OrderID.value);
        requestdetail.Od_ID = 0;
        requestdetail.O_ID = OrderID.value;
        requestdetail.P_ID = ID;
        requestdetail.Od_UnitPrice = finalPrice;
        requestdetail.Od_Sum = finalPrice;
        requestdetail.Od_Quantity = 1;
        // console.log("OrderDetail=>", requestdetail);
        axios
          .post(`${baseAddress}/api/OrderDetails`, requestdetail)
          .then((test) => {
            alert(test.data);
          });
      });
  });
};

const TypeChange = (num) => {
  employeeDTOes.value = [];
  if (num == -1) {
    // getAxios("/api/Products", employeeDTOes);
    getEmployeeDTOes();
  } else {
    var request = {};
    request.P_ID = 0;
    request.P_Name = "";
    request.P_Price = 0;
    request.P_ProductType = num;
    request.P_Image = "";
    request.P_Describe = "";
    request.P_Date = new Date();
    request.P_Instock = 0;
    request.P_Discount = 0;
    request.P_Discontinuted = false;
    postAxiosObjNodata(
      "/api/Products/FilterProductType",
      request,
      employeeDTOes
    );
  }
  // console.log("employeeDTOes=>", employeeDTOes);
  // console.log("employeeDTOes.value=>", employeeDTOes.value);
};
</script>
<template lang="">
<div class="page-wrapper">
    <div class="page-content row">
        <div class="col-md-1 col-12">
            <div class="btn-group-vertical " role="group" aria-label="Basic radio toggle button group">
                <input type="radio" class="btn-check" name="btnradio" id="btnradio1" autocomplete="off" checked>
                <label @click="TypeChange(-1)" class="btn btn-outline-primary" for="btnradio1">全部</label>

                <input type="radio" class="btn-check" name="btnradio" id="btnradio2" autocomplete="off">
                <label @click="TypeChange(2)" class="btn btn-outline-primary" for="btnradio2">動物</label>

                <input type="radio" class="btn-check" name="btnradio" id="btnradio3" autocomplete="off">
                <label @click="TypeChange(0)" class="btn btn-outline-primary" for="btnradio3">東方</label>

                <input type="radio" class="btn-check" name="btnradio" id="btnradio4" autocomplete="off">
                <label @click="TypeChange(3)" class="btn btn-outline-primary" for="btnradio4">其他</label>
            </div>
        </div>
        <div class="col-11">
            <div class="row test row-cols-1 row-cols-sm-2 row-cols-lg-3 row-cols-xl-4 row-cols-xxl-5 product-grid">

                <div v-for="item in employeeDTOes" :key="item.p_ID">
                    <div class="col">
                        <div class="position-relative border rounded popover-body bg-info">
                            <!-- :src="imageUrl(item.p_Image)"  -->
                            <div class="imgbord center ">
                                <p class="sprite ms-sm-4 ms-0" :style="`background-image: url(${imageUrl(item.p_Image)}); background-position: ${position}px 0;`" />
                                <!-- <p class="sprite" :style="`background-image: url(${imageUrl(item.p_Image)})`" /> -->
                                <!-- <img class="card-img-top  img-fluid" :src="imageUrl(item.p_Image)" /> -->
                            </div>
                            <div class="position-absolute top-0 end-0 m-2">
                                <span class="text-dark fw-bold">折扣 {{
                                    item.p_Discount }}</span>
                            </div>
                            <div class="card-body">
                                <h6 class="card-title cursor-pointer mt-3">{{ item.p_Name }}</h6>
                                <div class="clearfix ">
                                                    <p class="mb-0 fw-bold">
                                        <!-- <span
                                        class="me-2 text-decoration-line-through text-secondary">原價{{ item.p_Price
                                        }}</span> -->
                                        <span>點數價格: {{ DiscountMoney(item.p_Price, item.p_Discount)
                                        }}</span>
                                    </p>
                                </div>
                                <div class="d-flex align-items-center mt-3 fs-6">
                                    <!-- <button :id="item.id" type="button" class="btn btn-primary"
                                        @click="showBuyDetail(item.p_ID)">購買</button> -->
                                        <button :id="item.p_ID" type="button" class="btn btn-primary"
                                        @click="openDialog">詳細</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div>
<!-- 購買資訊 -->
    <div v-if="isDialogOpen" class="dialog buywidth bd-blue-200">
        <div class="container ">
        <!-- <div v-for="item in selectedProduct" :key="item.p_ID"> -->
            <div class="row product-block border rounded-1 ms-1">
                <div class=" product-images  col ">
                    <!-- Product Image thumbnails START -->
                    <div class="thumbnails">
                        <div class="product-image">
                            <a class="thumbnail" title="magni dolores eosquies">
                                <p class="sprite ms-5 mt-4 ms-0" :style="`background-image: url(${imageUrl(selectedProduct.p_Image)}); background-position: ${position}px 0;`" />
                                <!-- <img src="static/picture/05-800x800.jpg" title="magni dolores eosquies"
                                    data-zoom-image="https://demo.templatetrip.com/Opencart/OPC02/OPC040/OPC15/image/cache/catalog/demo/product/05-800x800.jpg"
                                    alt="magni dolores eosquies"> -->
                            </a>
                        </div>
                        <!-- Product Image thumbnails END -->
                    </div>
                </div>

                    <div class=" product-details  col border p-2">
                        <h1>商品名稱: </h1>
                        <h2 class="product-name">{{ selectedProduct.p_Name }} </h2>

                        <table class="product-info">
                            <tr>商品介紹: </tr>
                            <tr>
                                <td>{{ selectedProduct.p_Describe }}</td>
                                <!-- <td class="product-info-value"><a
                                        href="index-productmanufacturerinfo_8.html">Apple</a></td> -->
                            </tr>
                            <!-- <tr>
                                <td>Product Code:</td>
                                <td class="product-info-value">Product 14</td>
                            </tr>
                            <tr>
                                <td>Availability:</td>
                                <td class="product-info-value">In Stock</td>
                            </tr> -->
                        </table>

                        <!-- Product Rating START -->

                        <!-- Product Rating END -->

                        <ul class="list-unstyled product-price">
                            <li>
                                <h2>價格: {{ DiscountMoney(selectedProduct.p_Price, selectedProduct.p_Discount)}}</h2>
                            </li>
                        </ul>
                        <!-- Product Options START -->
                        <div id="product" class="product-options">
                            <div class="form-group product-quantity">
                                <button class="btn btn-primary m-1 btn-lg btn-block" @click="confirmPurchase(selectedProduct.p_ID,selectedProduct.p_Price,selectedProduct.p_Discount,selectedProduct.p_Image)">購買</button>
                                <button class="btn btn-secondary" @click="closeDialog">關閉</button> 
                            </div>
                        </div>
                        <!-- Product Options END -->
                    </div>
                    <!-- Product option details END -->
                </div>
            <!-- <div  class="border rounded-3 my-4">
                <h4>購買商品: {{ item.p_Name }}</h4>
                <h3>價格: {{ DiscountMoney(item.p_Price, item.p_Discount)}}</h3>
            </div>
            <div class="border rounded-3 m-auto">
               <button class="btn btn-primary m-1" @click="confirmPurchase(item.p_ID,item.p_Price)">購買</button>
                <button class="btn btn-secondary" @click="closeDialog">關閉</button> 
            </div> -->
        <!-- </div> -->
    </div>
    </div>

    <!-- 點數不足提示框 -->
    <div v-if="showInsufficientPoints" class="dialog">
      <p>點數不足，無法購買該商品。</p>
      <button class="btn btn-info" @click="closeInsufficientPointsDialog">關閉</button>
    </div>
  </div>

<!-- 遮罩層 -->
<div v-if="isDialogOpen || showInsufficientPoints" class="dialog-overlay"></div>
</template>

<style scoped>
.dialog {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  background-color: #fff;
  padding: 20px;
  border: 1px solid #ccc;
  border-radius: 5px;
  z-index: 1040;
}

.dialog-overlay {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.5);
  /* 設定透明度 */
  z-index: 999;
  /* 設定疊加順序，需高於其他元素 */
}

.sprite {
  width: 96px;
  height: 96px;
  transform: scale(1.5);
  transform-origin: top left;
}

.bd-blue-200 {
  color: #000;
  background-color: #9ec5fe;
}

.test {
  min-width: 320px;
}

.buywidth {
  width: 700px;
}

/*product-page */
.product-product #content .row {
  margin: 0;
}

.product-block {
  background: #ffffff;
  float: left;
  padding: 30px 15px;
  width: 100%;
}

/* Product page stylesheet */
.product-images .additional-images-container {
  margin: 0 auto;
  overflow: hidden;
  position: relative;
  width: 95%;
}

.additional-images .owl-wrapper-outer {
  float: left;
  width: 100%;
  overflow: hidden;
}

.product-details .product-info td {
  padding: 3px;
}

.product-details .product-info .product-info-value {
  color: #666;
  padding: 3px 3px 3px 10px;
  font-weight: normal;
}

.product-details .product-info tr td {
  color: #222222;
  text-transform: capitalize;
}

.product-product .product-info-value > a {
  color: #f12a43;
}

.product-product .product-info-value > a:hover {
  color: #222;
}

.product-product .tab-content {
  background: #ffffff;
  margin: 20px 0 0;
  padding: 20px;
}

.cpt_product_description strong {
  font-size: 14px;
}

.product-quantity label {
  padding: 10px 0;
}

.product-quantity label,
.product-quantity #input-quantity {
  width: auto;
  text-align: center;
  margin: 0 10px 0 0;
  float: left;
}

.product-quantity #input-quantity {
  border: 1px solid #f0f0f0;
  font-size: 14px;
  float: left;
  height: 43px;
  line-height: 27px;
  border-radius: 5px;
  padding: 0 6px;
  text-align: center;
  width: 60px;
}

.product-details h1.product-name {
  border-bottom: 1px solid #f0f0f0;
  color: #111;
  font-size: 16px;
  font-weight: 500;
  margin: 0 0 12px;
  padding-bottom: 12px;
  text-transform: capitalize;
}

.product-details table.product-info {
  margin: 15px 0;
}

.product-details .product-price {
  border-top: 1px solid #f0f0f0;
  border-bottom: 1px solid #f0f0f0;
  padding: 15px 0;
  margin: 15px 0 20px;
}

.product-details .addthis_toolbox {
  padding-top: 15px;
  width: 100%;
  float: left;
}

.product-details .product-options h3 {
  font: 500 18px/24px "Poppins", Helvetica, sans-serif;
}

.product-details .rating {
  display: table;
}

.product-total-review .fa.fa-comment,
.product-write-review .fa.fa-pencil {
  margin-right: 5px;
}

.product-details .btn.btn-default.product-btn-wishlist,
.product-details .btn.btn-default.product-btn-compare {
  font-size: 13px;
  text-align: left;
  text-transform: none;
  border: none;
  background: none;
  padding: 0 15px 0 0;
  letter-spacing: 1px;
  font-weight: 500;
  margin: 0;
}

.product-details .btn.btn-default.product-btn-wishlist::after,
.product-details .btn.btn-default.product-btn-compare::after {
  display: none;
}

.product-details .btn.btn-default.product-btn-wishlist:hover,
.product-details .btn.btn-default.product-btn-compare:hover {
  background: none;
}

.product-price .product-discounts {
  list-style: none;
  margin-top: 10px;
  font-size: 13px;
}

.product-price .product-reward-points {
  font-size: 13px;
}

.product-details .rating > a {
  border-right: 1px solid #f0f0f0;
  color: #666666;
  float: left;
  font-size: 13px;
  margin: 2px 10px 0 0;
  padding: 0 10px 0 0;
  height: 20px;
}

.product-details .rating > a:last-child {
  border-right: medium none;
  margin-right: 0;
}

.product-details .rating > a:hover {
  color: #444;
}

.rating .product-rating {
  border-right: 1px solid #f0f0f0;
  float: left;
  margin: 0 10px 0 0;
  padding: 4px 10px 0 0;
  height: 20px;
}

.product-details .price-new {
  float: left;
  margin: 0 8px 0 0;
}

.product-details .price-old {
  font-weight: normal;
  text-decoration: line-through;
}

.product-details .product-tax {
  margin-top: 10px;
}

.product-details .product-options h3 {
  margin: 10px 0;
}

.product-details ul.product-price h2 {
  color: #f12a43;
  font: 600 18px/20px "Poppins", Helvetica, sans-serif;
}

.product-options .product-quantity {
  clear: both;
  float: left;
}

.product-options .radio,
.product-options .checkbox {
  padding: 0;
  margin-top: 0;
  margin-bottom: 5px;
}

.product-product .btn.btn-default {
  background-color: #f5f5f5;
  border-color: #f5f5f5;
  color: #666666;
  padding: 7px 15px;
}

.product-product .btn.btn-default:hover {
  background-color: #f12a43;
  border-color: #f12a43;
}

.product-product .btn.btn-default:hover {
  color: #fff;
}

.product-product .btn.btn-default.product-btn-wishlist:hover,
.product-product .btn.btn-default.product-btn-wishlist:focus,
.product-product .btn.btn-default.product-btn-wishlist:active,
.product-product .btn.btn-default.product-btn-wishlist:active:focus {
  color: #000;
}

.product-product .btn.btn-default.product-btn-compare:hover,
.product-product .btn.btn-default.product-btn-compare:focus,
.product-product .btn.btn-default.product-btn-compare:active,
.product-product .btn.btn-default.product-btn-compare:active:focus {
  color: #000;
}

.product-product .product-details .btn-group > button {
  margin: 10px 5px 5px 0;
}

.product-product .product-details .addthis_toolbox > a:first-child {
  margin: 0px;
}

.product-product .product-details .addthis_toolbox > a {
  margin: 0 5px;
}

.product-tabs {
  padding: 0;
  clear: both;
  margin: 40px 0;
}

#tab-review label.control-label {
  font: 500 13px/20px "Poppins", Helvetica, sans-serif;
  color: #222;
  margin-bottom: 10px;
}

.product-product .nav.nav-tabs li.active a,
.product-product .nav.nav-tabs li:hover a {
  background: rgba(0, 0, 0, 0) none repeat scroll 0 0;
  color: #f12a43;
  border: medium none;
}

.product-product .nav-tabs > li > a {
  border: medium none;
  color: #666;
  margin: 0;
  font: 500 15px/22px "Poppins", Helvetica, sans-serif;
  padding: 8px 0;
  position: relative;
  text-transform: capitalize;
  border-radius: 0;
  -moz-border-radius: 0;
  -webkit-border-radius: 0;
  -khtml-border-radius: 0;
}

.product-product .nav-tabs > li.active > a::before {
  background: #f12a43;
  bottom: -2px;
  content: "";
  height: 3px;
  left: 0;
  position: absolute;
  right: 0;
  width: 100%;
}

.product-product #tab-description > h3,
.product-product #form-review > h2 {
  font-family: "Poppins", Helvetica, sans-serif;
  font-size: 16px;
  color: #666;
}

.product-product .nav-tabs > li {
  margin: 0 15px;
}

.product-product .nav-tabs > li:first-child {
  margin-left: 0;
}

.product-product .nav.nav-tabs {
  border-bottom: 1px solid #dddddd;
}

.tab-content #tab-description b {
  font-weight: 600;
  color: #414141;
}

.checkout-cart #accordion .panel-heading {
  padding: 0px;
  border-color: #f0f0f0;
  background: #ffffff;
}

.checkout-cart #accordion .panel-heading a {
  padding: 10px 15px;
  font-family: "Poppins", Helvetica, sans-serif;
  font-weight: 500;
  font-size: 13px;
}

.checkout-cart #accordion label.control-label {
  width: 100%;
  padding: 0px;
  text-align: left;
  color: #444;
  font-size: 14px;
}

.checkout-cart #accordion .form-group {
  margin: 15px 0;
}

.checkout-cart #accordion .form-group > div {
  width: 100%;
  padding: 0px;
  margin: 5px 0;
}

.checkout-cart #content > .buttons {
  float: left;
  width: 100%;
}

.checkout-checkout #accordion .panel-default .panel-heading {
  border-color: #f0f0f0;
  background: #ffffff;
}

#product-compare .table-bordered > tbody > tr > td:first-child {
  font-weight: 500;
  color: #111;
}

.table.table-bordered {
  border-color: #f0f0f0;
  background: #ffffff;
}

.table-bordered > thead > tr > th,
.table-bordered > thead > tr > td,
.table-bordered > tbody > tr > th,
.table-bordered > tbody > tr > td,
.table-bordered > tfoot > tr > th,
.table-bordered > tfoot > tr > td {
  border: 1px solid #f0f0f0;
  color: #222;
}

.sub-total-table .table-bordered tbody tr td:first-child strong {
  font-weight: 500;
  font-size: 13px;
  color: #111;
}

.product-product #review .table.table-striped.table-bordered p {
  margin: 0;
}

.checkout-cart .sub-total-table {
  float: right;
}

.bootstrap-datetimepicker-widget .accordion-toggle a.btn,
.bootstrap-datetimepicker-widget .timepicker td a span {
  background: #eeeeee;
}

.bootstrap-datetimepicker-widget .timepicker td a:hover,
.bootstrap-datetimepicker-widget .timepicker td a:focus {
  color: #ffffff;
}

.bootstrap-datetimepicker-widget .accordion-toggle a.btn:hover,
.bootstrap-datetimepicker-widget .timepicker td a span:hover {
  background: #777;
}

.datepicker .datepicker-days .table-condensed .day.active,
.bootstrap-datetimepicker-widget td span.active,
.bootstrap-datetimepicker-widget .accordion-toggle a.btn:hover,
.bootstrap-datetimepicker-widget .timepicker td a span:hover,
.bootstrap-datetimepicker-widget td span.active,
.datepicker-months .table-condensed .month.active,
.datepicker-years .table-condensed .year.active {
  background-color: #f12a43;
}

s.bootstrap-datetimepicker-widget .accordion-toggle a.btn,
.bootstrap-datetimepicker-widget .timepicker td a span,
.bootstrap-datetimepicker-widget .accordion-toggle a.btn {
  background: #eeeeee;
}

.bootstrap-datetimepicker-widget .timepicker td a:hover,
.bootstrap-datetimepicker-widget .timepicker td a:focus {
  color: #ffffff;
}

.bootstrap-datetimepicker-widget .accordion-toggle a.btn:hover,
.bootstrap-datetimepicker-widget .timepicker td a span:hover {
  background: #bc3b36;
}

.datepicker-days .table-condensed .day.today::before {
  border-bottom: 7px solid #f12a43;
}

.datepicker-days .table-condensed .day.active.today::before {
  border-bottom: 7px solid #fff;
}
</style>