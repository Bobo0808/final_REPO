
<script setup>
import { onMounted, ref, watch, toRaw } from 'vue';
import { playerRefs, baseAddress, getAxios, postAxiosString, postAxiosObjNodata } from '../../main.js';
import CardAndOrder from '../Order/CardAndOrder.vue';
// import { playerRefs,postAxiosObjNodata } from "../../main.js";

// const baseAddress = "https://localhost:7097";
// const baseAddress = "https://localhost:7093";

const CardDTOes = ref([]);

// 購買商品
const isDialogOpen = ref(false);
const selectedCardProduct = ref({});

// 關掉
const showInsufficientPoints = ref(false);
//會員點數
const CardPoints = ref(0);

// 圖片移動像素值
const position = ref(357);

const emit = defineEmits();
const props = defineProps({
    modelValue: {
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

const getCardDTOes = () => {
    // getAxios("/api/Cards", CardDTOes);

    axios.get(`${baseAddress}/api/Cards`).then(response => {
        // alert(JSON.stringify(response.data));
        CardDTOes.value = response.data;
        // console.log(CardDTOes.value);
    });
};

onMounted(() => {
    getCardDTOes();
    // CheckPoints();
    // SpriteForP();
});
watch(() => {
    // playerRefs.value.coins;
    playerRefs.value.user.a_Coin;
});
const OpenorClose = () => {
    if (props.modelValue === true) {
        getCardDTOes();
    }
};
const imageUrl = (url) => {
    // console.log(url);
    // const imgPath = `/src/assets/img/producttest/${url}`;
    // const imgUrl = new URL(imgPath, import.meta.url).href;
    // console.log(imgUrl);
    return url;
};
const product = ref([]);
// 購買商品
const openDialog = async (ID) => {
    // console.log(ID);
    try {

        // getAxios(`/api/Cards/${cd.target.id}`, selectedCardProduct)
        await axios.get(`${baseAddress}/api/Cards/${ID}`).then(response => {
            // alert(JSON.stringify(response.data));

            selectedCardProduct.value = response.data;
            // console.log(CardDTOes.value);
        });
        // 從後端獲取商品資料
        // const response = axios.get(`${baseAddress}/api/Cards/${ID}`); // 假設商品 ID 為 123
        // product.value = response.data;

        // getAxios(`/api/Cards/${ID}`, product);
        // console.log("product.value=>", product.value);
        // console.log("product=>", product);

        // 設定選中的商品
        // selectedCardProduct.value = product;

        isDialogOpen.value = true;
        // console.log("selectedCardProduct.value=>", selectedCardProduct.value);

        return selectedCardProduct
    } catch (error) {
        console.error('讀取商品資料失敗:', error);
    }
};
const closeDialog = () => {
    isDialogOpen.value = false;
    selectedCardProduct.value = null;
};
const confirmPurchase = (ID, Price, Name) => {
    // if (playerRefs.coins >= Price) {
    // 點數足夠，執行購買邏輯
    console.log('購買商品:', Price);

    // CheckPoints();

    CardAdd(ID, Price);
    // 加點數
    //const str = "100元換200點";
    // console.log("Name.substring(5, 8)=>", Name.substring(5, 8));
    const parts = parseInt(Name.substring(5, 8));
    // console.log("parts=>", parts);
    // playerRefs.value.coins += parts;
    playerRefs.value.user.a_Coin += parts;

    ChangeAccountCoins(playerRefs.value.user.a_Coin);

    // 購買完成後關閉彈出視窗
    closeDialog();

};

//修改會員點數
const ChangeAccountCoins = (coins) => {
    var test = {};
    var request = {};
    request.A_ID = playerRefs.value.user.a_ID;
    request.A_Coin = coins;
    postAxiosObjNodata(`/api/User/Update/${playerRefs.value.user.a_ID}`, request, test);
}


const closeInsufficientPointsDialog = () => {
    showInsufficientPoints.value = false;
};

const CardAdd = (ID, Price) => {
    var test = {};
    var request = {};
    request.CO_ID = 0;
    request.A_ID = playerRefs.value.user.a_ID;
    request.CA_ID = ID;
    request.CA_Name = "";
    request.CT_ID = 1;
    request.CO_Date = new Date();
    request.CO_Sum = Price;
    request.CO_Cancel = false;
    request.CO_Quantity = 1;
    // postAxiosObjNodata(`/api/CardOrders`, request, test);

    // console.log(request);
    axios.post(`${baseAddress}/api/CardOrders`, request).then(response => {
        // console.log("success");
        getCardOrderDTOes();
        // console.log("response.data", response.data);
    });
}
const CardOrderDTOes = ref([]);
const getCardOrderDTOes = () => {
    CardOrderDTOes.value = [];
    var request = {};
    request.A_ID = playerRefs.value.user.a_ID;
    request.CA_Name = "";
    axios.post(`${baseAddress}/api/CardOrders/Show`, request).then(response => {
        // alert(JSON.stringify(response.data));
        CardOrderDTOes.value = response.data;
        // console.log(CardOrderDTOes.value);
    });
    // postAxiosObjNodata(`/api/CardOrders/Show`, request, CardOrderDTOes);
};

const PayMentForLinePay = async () => {

}

const PayMentForNewWebPay = async () => {
    var request = {};
    request.MerchantID = 0;
    request.MerchantOrderNo = playerRefs.value.user.a_ID;
    request.ItemDesc = ID;
    request.Amt = "";
    request.ExpireDate = 1;
    request.ReturnURL = new Date();
    request.CustomerURL = Price;
    request.NotifyURL = false;
    request.ClientBackURL = 1;
    request.Email = 'xxxx@gmail.com';

    try {
        const response = await axios.post('@Url.Content("~/Home/SendToNewebPay")', postData)
        const returnObj = response.data

        // 呼叫藍新金流 API
        const form = document.createElement('form')
        form.method = 'post'
        form.action = 'https://ccore.newebpay.com/MPG/mpg_gateway' // 藍新金流驗證網址(測試環境)

        for (const key in returnObj) {
            if (returnObj.hasOwnProperty(key)) {
                const hiddenField = document.createElement('input')
                hiddenField.type = 'hidden'
                hiddenField.name = key
                hiddenField.value = returnObj[key]
                form.appendChild(hiddenField)
            }
        }

        document.body.appendChild(form)
        form.submit()
    } catch (error) {
        Toast.fire({
            type: 'error',
            title: `${error.response.status} ${error.response.statusText}\n${error.response.data}`
        })
    }
}








</script>



<template lang="">
<div class="page-wrapper">
    <div class="page-content">
        
        <div class="row row-cols-1 row-cols-sm-3 row-cols-lg-4 row-cols-xl-5 row-cols-xxl-6 product-grid">
            <div v-for="item in CardDTOes" :key="item.cA_ID">
                <div class="col">
                    <div class="position-relative border rounded popover-body bg-info">
                        <!-- :src="imageUrl(item.p_Image)"  -->
                        <div class="imgbord center scale">
                            <!-- <p class="sprite" :style="`background-image: url(${imageUrl(item.cA_Image)}); background-position: ${position}px 0;`" /> -->
                            <!-- <img class="ms-sm-4 ms-0 sprite card-img-top img-fluid" :style="`background-image: url(${imageUrl(item.p_Image)}); background-position: ${activePosition}px 0;`" /> -->
                            <img class="card-img-top" :src="imageUrl(item.cA_Image)" />
                        </div>
                        <!-- <div class="position-absolute top-0 end-0 m-2">
                            <span class="text-dark fw-bold">折扣 {{
                                item.cA_Discount }}</span>
                        </div> -->
                        <div class="card-body">
                            <h6 class="card-title cursor-pointer">{{ item.cA_Name }}</h6>
                            <div class="clearfix">
                                                <p class="mb-0 fw-bold">
                                    <!-- <span
                                    class="me-2 text-decoration-line-through text-secondary">原價{{ item.p_Price
                                    }}</span> -->
                                    <span>價格: {{item.cA_Price}} 元</span>
                                </p>
                            </div>
                            <div class="d-flex align-items-center mt-3 fs-6">
                                <!-- <button :id="item.cA_ID" type="button" class="btn btn-primary"
                                    @click="showBuyDetail(item.cA_ID)">購買</button> -->
                                    <button :id="item.cA_ID" type="button" class="btn btn-primary"
                                    @click="openDialog(item.cA_ID)">詳細</button>
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
            <div class="row product-block border rounded-1 ms-1">
                <div class=" product-images  col ">
                    <!-- Product Image thumbnails START -->
                    <div class="thumbnails">
                        <div class="product-image">
                            <a class="thumbnail" title="magni dolores eosquies">
                                <img class="card-img-top" :src="imageUrl(selectedCardProduct.cA_Image)" />
                                <!-- <img src="static/picture/05-800x800.jpg" title="magni dolores eosquies"
                                    data-zoom-image="https://demo.templatetrip.com/Opencart/OPC02/OPC040/OPC15/image/cache/catalog/demo/product/05-800x800.jpg"
                                    alt="magni dolores eosquies"> -->
                            </a>
                        </div>
                        <!-- Product Image thumbnails END -->
                    </div>
                </div>

                    <div class=" product-details  col border p-2">
                        <h2 class="product-name">購買商品: {{ selectedCardProduct.cA_Name }} </h2>

                        <table class="product-info">
                            <tr>商品介紹: </tr>
                            <tr>
                                <td>{{ selectedCardProduct.cA_Describe }}</td>

                            </tr>

                        </table>


                        <ul class="list-unstyled product-price">
                            <li>
                                <h2>價格:  {{selectedCardProduct.cA_Price}}</h2>
                            </li>
                        </ul>
                        <!-- Product Options START -->
                        <div id="product" class="product-options">
                            <div class="form-group product-quantity">
                                <button class="btn btn-primary m-1" @click="PayMentForNewWebPay">Visa</button>
                                <!-- <button class="btn btn-primary m-1" @click="">LinePay</button> -->
                                <button class="btn btn-primary m-1 btn-lg btn-block" @click="confirmPurchase(selectedCardProduct.cA_ID,selectedCardProduct.cA_Price,selectedCardProduct.cA_Name)">購買</button>
                                <button class="btn btn-secondary" @click="closeDialog">關閉</button> 
                            </div>
                        </div>
                        <!-- Product Options END -->
                    </div>
                    <!-- Product option details END -->
                </div>
            </div>
        </div>
        <!-- <div >
            <div class="border rounded-3 my-4">
                <h4>購買商品: {{ selectedCardProduct.cA_Name }}</h4>
                <h3>價格:  {{selectedCardProduct.cA_Price}}</h3>
            </div>
            <div class="border rounded-3 m-auto">
               <button class="btn btn-primary m-1" @click="PayMentForNewWebPay">Visa</button>
               <button class="btn btn-primary m-1" @click="">LinePay</button>
               <button class="btn btn-primary m-1" @click="confirmPurchase(selectedCardProduct.cA_ID,selectedCardProduct.cA_Price,selectedCardProduct.cA_Name)">直接買</button>
                <button class="btn btn-secondary" @click="closeDialog">關閉</button> 
            </div>
        </div> -->

    </div>

    <!-- 點數不足提示框 -->
    <!-- <div v-if="showInsufficientPoints" class="dialog">
      <p>點數不足，無法購買該商品。</p>
      <button class="btn btn-info" @click="closeInsufficientPointsDialog">關閉</button>
    </div> -->

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

/* .sprite {
    width: 357.143px;
    height: 400px;

}

.scale {
    transform: scale(0.6);
    transform-origin: top left;
}

.productHeight {
    height: 50%;
} */

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

.product-product .product-info-value>a {
    color: #f12a43;
}

.product-product .product-info-value>a:hover {
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

.product-details .rating>a {
    border-right: 1px solid #f0f0f0;
    color: #666666;
    float: left;
    font-size: 13px;
    margin: 2px 10px 0 0;
    padding: 0 10px 0 0;
    height: 20px;
}

.product-details .rating>a:last-child {
    border-right: medium none;
    margin-right: 0;
}

.product-details .rating>a:hover {
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

.product-product .product-details .btn-group>button {
    margin: 10px 5px 5px 0;
}

.product-product .product-details .addthis_toolbox>a:first-child {
    margin: 0px;
}

.product-product .product-details .addthis_toolbox>a {
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

.product-product .nav-tabs>li>a {
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

.product-product .nav-tabs>li.active>a::before {
    background: #f12a43;
    bottom: -2px;
    content: "";
    height: 3px;
    left: 0;
    position: absolute;
    right: 0;
    width: 100%;
}

.product-product #tab-description>h3,
.product-product #form-review>h2 {
    font-family: "Poppins", Helvetica, sans-serif;
    font-size: 16px;
    color: #666;
}

.product-product .nav-tabs>li {
    margin: 0 15px;
}

.product-product .nav-tabs>li:first-child {
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

.checkout-cart #accordion .form-group>div {
    width: 100%;
    padding: 0px;
    margin: 5px 0;
}

.checkout-cart #content>.buttons {
    float: left;
    width: 100%;
}

.checkout-checkout #accordion .panel-default .panel-heading {
    border-color: #f0f0f0;
    background: #ffffff;
}

#product-compare .table-bordered>tbody>tr>td:first-child {
    font-weight: 500;
    color: #111;
}

.table.table-bordered {
    border-color: #f0f0f0;
    background: #ffffff;
}

.table-bordered>thead>tr>th,
.table-bordered>thead>tr>td,
.table-bordered>tbody>tr>th,
.table-bordered>tbody>tr>td,
.table-bordered>tfoot>tr>th,
.table-bordered>tfoot>tr>td {
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
    background: #EEEEEE;
}

.bootstrap-datetimepicker-widget .timepicker td a:hover,
.bootstrap-datetimepicker-widget .timepicker td a:focus {
    color: #FFFFFF;
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
    background: #EEEEEE;
}

.bootstrap-datetimepicker-widget .timepicker td a:hover,
.bootstrap-datetimepicker-widget .timepicker td a:focus {
    color: #FFFFFF;
}

.bootstrap-datetimepicker-widget .accordion-toggle a.btn:hover,
.bootstrap-datetimepicker-widget .timepicker td a span:hover {
    background: #bc3b36;
}

.datepicker-days .table-condensed .day.today::before {
    border-bottom: 7px solid #f12a43;
}

.datepicker-days .table-condensed .day.active.today::before {
    border-bottom: 7px solid #FFF;
}
</style>