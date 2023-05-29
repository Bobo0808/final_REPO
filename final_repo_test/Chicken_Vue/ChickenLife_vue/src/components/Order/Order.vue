
<script setup>
import { onMounted, ref, inject } from 'vue';
import { playerRefs, baseAddress, getAxios, getDate, postAxiosObjNodata, putAxiosString, putAxiosStringNodata } from '../../main';
// const baseAddress = "https://localhost:7097";
// const baseAddress = "https://localhost:7093";

const props = defineProps({
    accountA_ID: {
        type: Number,
        required: true,
        default: 0
    },
})

const OrderDTOes = ref([]);
const datefilter = ref(null);

//確認取消訂單
const isDialogOpen=ref(false);
const selectedOrder = ref(null);

const getOrderDTOes = (A_ID) => {
    var request = {};
    request.A_ID = isNaN(Number(A_ID)) ? -1 : Number(A_ID);
    request.productName = "";
    //getAxios(`${baseAddress}`, "/api/Order", OrderDTOes);

    //console.log("request.A_ID=>",request.A_ID);
    //console.log("request=>",request);

    //原本axios呼叫指令碼
    // axios.post(`${baseAddress}/api/Order/Show`, request).then(response => {
    //     //alert(JSON.stringify(response.data));
    //     OrderDTOes.value = response.data;
    //     // console.log("OrderDTOes.value=>", OrderDTOes.value);
    // });
    postAxiosObjNodata(`/api/Order/Show`, request, OrderDTOes);
    // console.log("OrderDTOes.value=>", OrderDTOes);

};

const getdatefilter = (datefilter) => {
    return getDate(datefilter);
    //console.log("datefilter=>",datefilter);
}

onMounted(() => {
    getOrderDTOes(playerRefs.value.user.a_ID);
    // console.log("props.accountA_ID=>", props.accountA_ID);
});

// 按鈕日期
const isButtonDisabled = (date, iscanceled) => {
    const threeDaysLater = new Date(date);
    // console.log("date=>", date);
    // console.log("threeDaysLater=>", threeDaysLater);
    threeDaysLater.setDate(threeDaysLater.getDate() + 3);
    const today = new Date();
    return threeDaysLater <= today || iscanceled;
};

// 確認取消訂單
const CheckCancel= async (O_ID)=>{
    try {
        //fuck();
        // const product = {};
        // 從後端獲取商品資料
        const response = await axios.get(`${baseAddress}/api/Order/${O_ID}`); // 假設商品 ID 為 123
        // await getAxios(`/api/Products/${pt.target.id}`, product); // 假設商品 ID 為 123
        // CheckPoints();
        const product = response.data;

        // 設定選中的商品
        selectedOrder.value = product;
        // console.log('selectedOrder.value=>', selectedOrder.value);
        isDialogOpen.value = true;
        // console.log(selectedProduct.value);
    } catch (error) {
        console.error('讀取商品資料失敗:', error);
    }
}

// 取消訂單
const cancelOrder = async (O_ID, Price) => {
    // console.log("O_ID=>", O_ID);
    var test = {};
    var request = {};
    request.O_ID = isNaN(Number(O_ID)) ? -1 : Number(O_ID);
    request.O_Cancle = true;
    request.productName = "";
    await putAxiosStringNodata(`/api/Order/Cancel/${O_ID}`, request, test);

    playerRefs.value.user.a_Coin += Price;
    ChangeAccountCoins(playerRefs.value.user.a_Coin);
    getOrderDTOes(playerRefs.value.user.a_ID);
    // axios.put(`${baseAddress}/api/Order/Cancel/${O_ID}`, request).then(response => {
    //     getOrderDTOes(props.accountA_ID);
    // });

    // 購買完成後關閉彈出視窗
    closeDialog();
};
// 關閉
const closeDialog = () => {
    isDialogOpen.value = false;
    selectedOrder.value = null;
};

//修改會員點數
const ChangeAccountCoins = (coins) => {
    var test = {};
    var request = {};
    request.A_ID = playerRefs.value.user.a_ID;
    request.A_Coin = coins;
    postAxiosObjNodata(`/api/User/Update/${playerRefs.value.user.a_ID}`, request, test);
}


// 切換全部/當月
const ShowOrder=(num)=>{

    OrderDTOes.value=[];
    if(num==0){
        getOrderDTOes(playerRefs.value.user.a_ID);
    }else {
        var request = {};
        request.O_ID = 0;
        request.A_ID = isNaN(Number(playerRefs.value.user.a_ID)) ? -1 : Number(playerRefs.value.user.a_ID);
        request.O_O_Date = new Date();
        request.O_Cancle = false;
        request.productName = "";

        axios.post(`${baseAddress}/api/Order/FilterAccount`, request).then(response => {
            
            OrderDTOes.value = response.data;
        });
    }
};



</script>

<template lang="">
    <div class="btn-group mb-2" role="group" aria-label="Basic radio toggle button group">
        <input type="radio" class="btn-check" name="btnradio" id="btnradio1" autocomplete="off" checked>
        <label class="btn btn-outline-primary" for="btnradio1" @click="ShowOrder(0)">全部</label>

        <input type="radio" class="btn-check" name="btnradio" id="btnradio2" autocomplete="off">
        <label class="btn btn-outline-primary" for="btnradio2" @click="ShowOrder(1)">當月購買</label>

        <!-- <input type="radio" class="btn-check" name="btnradio" id="btnradio3" autocomplete="off">
        <label class="btn btn-outline-primary" for="btnradio3">Radio 3</label> -->
    </div>
    <table class="table mb-0 border w-90 text-center">
        <thead class="table-light">
            <tr>
                <th class="col-1">#</th>
                <th class="col-2">狀態</th>
                <th class="col-2">商品名稱</th>
                <th class="col-1">金額</th>
                <th class="col-2">購買日期</th>
                <th class="col-1">取消</th>
            </tr>
        </thead>
        <tbody id="table"  v-for="(item,index) in OrderDTOes" :key="item.o_ID">
            <tr class="gray" >
                <td>
                    <div class="d-flex align-items-center">
                        <div class="ms-2">
                            <h6 class="mb-0 font-14"># {{index+1}}</h6>
                        </div>
                    </div>
                </td>
                <td>
                    <div id="test" :class="['badge', 'rounded-pill', 'p-2', 'text-uppercase', 'px-3', {'bg-danger': item.o_Cancle, 'bg-success': !item.o_Cancle}]" >
                        {{ item.o_Cancle ? '訂單取消' : '訂單完成' }}
                    </div>
                </td>
                <td>
                    {{item.productName}}
                </td>
                <td>
                    {{item.o_TotalPrice}}
                </td>
                <td>
                    {{getdatefilter(item.o_Date)}}
                </td>
                <td>
                    <div class="d-flex order-actions">
                        <button v-if="!isButtonDisabled(item.o_Date,item.o_Cancle)" :disabled="isButtonDisabled(item.o_Date,item.o_Cancle)" class="btn btn-danger" @click="CheckCancel(item.o_ID)">X</button>
                        
                    </div>
                </td>
            </tr>
        </tbody>
    </table>

<!-- 確認訂單是否刪除 -->
<div v-show="isDialogOpen" class="dialog buywidth bd-blue-200">  
    <div  class="rounded-3 my-4">
        確定取消訂單嗎?
    </div>
    <div class="rounded-3 m-auto">
        <button class="btn btn-primary m-1" @click="cancelOrder(selectedOrder.o_ID,selectedOrder.o_TotalPrice)">確定</button>
        <button class="btn btn-secondary rounded-circle" @click="closeDialog">關閉</button> 
    </div>
</div>
</template>

<style scoped>
    .w-90{
        width: 95%;
        margin: 0 auto;
    }
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
</style>