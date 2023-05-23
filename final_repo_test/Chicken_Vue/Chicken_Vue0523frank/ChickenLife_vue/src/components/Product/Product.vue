<script setup>

import { onMounted, ref, watch, inject, toRaw } from 'vue';
import { getAxios, postAxiosString } from '../../main';
// const baseAddress = "https://localhost:7097";
const baseAddress = "https://localhost:7093";
const employeeDTOes = ref([]);


const DiscountPrice = ref(0);

// 購買商品
const isDialogOpen = ref(false);
const selectedProduct = ref(null);

// 關掉
const showInsufficientPoints = ref(false);
//會員點數
const ProductPoints = ref(0);

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

const getEmployeeDTOes = () => {
    getAxios("/api/Products", employeeDTOes);
    //console.log(employeeDTOes);

    //原本axios呼叫指令碼
    // axios.get(`${baseAddress}/api/Products`).then(response => {
    //     //alert(JSON.stringify(response.data));
    //     employeeDTOes.value = response.data;
    //     // console.log(employeeDTOes.value);
    // });
};

onMounted(() => {
    getEmployeeDTOes();
    CheckPoints();
    SpriteForP();

});

const OpenorClose = () => {
    if (props.modelValue === true) {
        getEmployeeDTOes();
    }
};

//讀取圖片
// const imageUrl = (url) => {
//     // console.log(url);
//     const imgPath = `/src/assets/img/producttest/${url}`;
//     const imgUrl = new URL(imgPath, import.meta.url).href;
//     // console.log(imgUrl);
//     return imgUrl;
// };
const imageUrl = (url) => {
    // console.log(url);
    const imgPath = `/src/assets/img/producttest/${url}`;
    const imgUrl = new URL(imgPath, import.meta.url).href;
    // console.log(imgUrl);
    return imgUrl;
};

// 選取所有的 .sprite 元素
// Sprite
const sprites = document.querySelectorAll('.sprite');
const interval = 100;
const SpriteForP = () => {
    // position = 96; // 調整每次移動的像素值

    // 設定初始的 backgroundPosition
    // sprites.forEach(sprite => {
    //     sprite.style.backgroundPosition = `-${position}px 0px`;
    //     // console.log("position=>", position);
    // });

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
    //console.log(pt.target.id);
    try {
        //fuck();
        const product = {};
        // 從後端獲取商品資料
        // const response = await axios.get(`${baseAddress}/api/Products/${pt.target.id}`); // 假設商品 ID 為 123
        await getAxios(`/api/Products/${pt.target.id}`, product); // 假設商品 ID 為 123
        CheckPoints();
        // const product = response.data;

        // 設定選中的商品
        selectedProduct.value = product;
        // console.log('selectedProduct.value=>', selectedProduct.value);
        isDialogOpen.value = true;
        // console.log(selectedProduct.value);
    } catch (error) {
        console.error('讀取商品資料失敗:', error);
    }
};
const closeDialog = () => {
    isDialogOpen.value = false;
    selectedProduct.value = null;
};
const confirmPurchase = (ID, Price) => {
    if (props.memberpoints >= Price) {
        // 點數足夠，執行購買邏輯
        //console.log('購買商品:', selectedProduct.value);
        // console.log('Price', Price);

        CheckPoints();
        OrderAdd(ID, Price);
        //OrderDetailAdd(ID, Price);
        // 扣除點數
        ProductPoints.value -= Price;
        // console.log('ProductPoints=>', ProductPoints.value);
        emit('updatepoint', ProductPoints);
        // memberPoints.value -= selectedProduct.value.price;

        // 購買完成後關閉彈出視窗
        closeDialog();
    } else {
        // 點數不足，顯示提示框
        showInsufficientPoints.value = true;
    }
};

const closeInsufficientPointsDialog = () => {
    showInsufficientPoints.value = false;
};
const CheckPoints = () => {
    ProductPoints.value = props.memberpoints;
};
const OrderAdd = (ID, Price) => {
    //Order
    var request = {};
    var requestdetail = {};
    request.O_ID = 0;
    request.A_ID = props.accountA_ID;
    request.O_Date = new Date();
    request.O_TotalPrice = Price;
    request.O_Cancle = false;
    request.ProductName = "";
    //postAxios(`/api/Order`, request);
    // console.log(request);
    axios.post(`${baseAddress}/api/Order`, request).then(response => {
        console.log("success");
        console.log("response.data", response.data);
        axios.get(`${baseAddress}/api/Order/GET/${props.accountA_ID}`)
            .then(response => {
                OrderID.value = response.data;
                //console.log("OrderID.value=>", OrderID.value);
                requestdetail.Od_ID = 0;
                requestdetail.O_ID = OrderID.value;
                requestdetail.P_ID = ID;
                requestdetail.Od_UnitPrice = Price;
                requestdetail.Od_Sum = Price;
                requestdetail.Od_Quantity = 1;
                console.log("OrderDetail=>", requestdetail);
                axios.post(`${baseAddress}/api/OrderDetails`, requestdetail).then(test => {
                    alert(test.data);
                });
            });
    });

};

</script>
<template lang="">
<div class="page-wrapper">
    <div class="page-content">
        
        <div class="row test row-cols-1 row-cols-sm-3 row-cols-lg-4 row-cols-xl-5 row-cols-xxl-6 product-grid">
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
                                    @click="openDialog">購買</button>
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
    <div v-if="isDialogOpen" class="dialog">
        <div v-for="item in selectedProduct" :key="item.p_ID">
            <div  class="border rounded-3 my-4">
                <h4>購買商品: {{ item.p_Name }}</h4>
                <h3>價格: {{ DiscountMoney(item.p_Price, item.p_Discount)}}</h3>
            </div>
            <div class="border rounded-3 m-auto">
               <button class="btn btn-primary m-1" @click="confirmPurchase(item.p_ID,item.p_Price)">購買</button>
                <button class="btn btn-secondary" @click="closeDialog">關閉</button> 
            </div>
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

.test {
    min-width: 320px;
}
</style>