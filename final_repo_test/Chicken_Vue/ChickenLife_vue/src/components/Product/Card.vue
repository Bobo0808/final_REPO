
<script setup>
import { onMounted, ref, watch, toRaw } from 'vue';
import { getAxios, postAxiosString } from '../../main';
import CardAndOrder from '../Order/CardAndOrder.vue';


// const baseAddress = "https://localhost:7097";
const baseAddress = "https://localhost:7093";

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
    getAxios("/api/Cards", CardDTOes);

    //axios.get(`${baseAddress}/api/Cards`).then(response => {
    //alert(JSON.stringify(response.data));
    //CardDTOes.value = response.data;
    // console.log(CardDTOes.value);
    //});
};

onMounted(() => {
    getCardDTOes();
    CheckPoints();
    // SpriteForP();
});

const OpenorClose = () => {
    if (props.modelValue === true) {
        getCardDTOes();
    }
};
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
        // if (position.value < 2500) {
        //     position.value += 357.143;
        //     // console.log("position=>", position);
        // } else {
        //     position.value = 357.143;
        // }
        // sprite.style.backgroundPosition = `-${position}px 0px`;
        //});
        // console.log("5=>", selectedCardProduct.value);
    }, interval);

    // requestAnimationFrame(SpriteForP);
};


// 購買商品
const openDialog = async (cd) => {
    //console.log(pt.target.id);
    try {
        // const product = {};
        // 從後端獲取商品資料
        const response = await axios.get(`${baseAddress}/api/Cards/${cd.target.id}`); // 假設商品 ID 為 123
        const product = response.data;

        // await getAxios(`/api/Cards/${cd.target.id}`, product);
        // console.log("product=>", product);

        CheckPoints();

        // 設定選中的商品
        selectedCardProduct.value = product;

        isDialogOpen.value = true;
        // console.log(selectedCardProduct.value);

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
    if (props.memberpoints >= Price) {
        // 點數足夠，執行購買邏輯
        console.log('購買商品:', Price);

        CheckPoints();

        CardAdd(ID, Price);
        // 加點數
        //const str = "100元換200點";
        // console.log("Name.substring(5, 8)=>", Name.substring(5, 8));
        const parts = parseInt(Name.substring(5, 8));
        // console.log("parts=>", parts);
        CardPoints.value += parts;
        //memberPoints.value -= selectedCardProduct.value.cA_Price;
        emit('updatepoint', CardPoints);

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
    CardPoints.value = props.memberpoints;
    // console.log("1=>", selectedCardProduct.value);
}
const CardAdd = (ID, Price) => {
    var request = {};
    request.CO_ID = 0;
    request.A_ID = props.accountA_ID;
    request.CA_ID = ID;
    request.CA_Name = "";
    request.CT_ID = 1;
    request.CO_Date = new Date();
    request.CO_Sum = Price;
    request.CO_Cancel = false;
    request.CO_Quantity = 1;
    //postAxios(`/api/Order`, request);
    // console.log(request);
    axios.post(`${baseAddress}/api/CardOrders`, request).then(response => {
        console.log("success");
        console.log("response.data", response.data);
    });
}

const PayMentForLinePay = async () => {

}

const PayMentForNewWebPay = async () => {
    var request = {};
    request.MerchantID = 0;
    request.MerchantOrderNo = props.accountA_ID;
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
        <div >
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
</style>