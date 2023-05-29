
<script setup>
import { onMounted, ref } from 'vue';
import { playerRefs, baseAddress, getDate, putAxiosStringNodata, postAxiosObjNodata } from '../../main';
// const baseAddress = "https://localhost:7097";
// const baseAddress = "https://localhost:7093";

const props = defineProps({
    accountA_ID: {
        type: Number,
        required: true,
        default: 0
    },
})

const CardOrderDTOes = ref([]);
const datefilter = ref(null);

//確認取消訂單
const isDialogOpenCard=ref(false);
const selectedCardOrder = ref(null);

const getCardOrderDTOes = (A_ID) => {
    var request = {};
    request.A_ID = isNaN(Number(A_ID)) ? -1 : Number(A_ID);
    request.CA_Name = "";
    // axios.post(`${baseAddress}/api/CardOrders/Show`, request).then(response => {
    //     // alert(JSON.stringify(response.data));
    //     CardOrderDTOes.value = response.data;
    //     // console.log(CardOrderDTOes.value);
    // });
    postAxiosObjNodata(`/api/CardOrders/Show`, request, CardOrderDTOes);
};

const getdatefilter = (datefilter) => {
    return getDate(datefilter);
    //console.log("datefilter=>",datefilter);
};

onMounted(() => {
    getCardOrderDTOes(playerRefs.value.user.a_ID);
});


//按鈕日期
const isButtonDisabled = (date, iscanceled) => {
    const threeDaysLater = new Date(date);
    // console.log("date=>", date);
    // console.log("threeDaysLater=>", threeDaysLater);
    threeDaysLater.setDate(threeDaysLater.getDate() + 3);
    const today = new Date();
    return threeDaysLater <= today || iscanceled;
}

// 確認取消訂單
const CheckCancel= async (CO_ID,Name)=>{
    try {
        //fuck();
        // const product = {};
        // 從後端獲取商品資料
        const response = await axios.get(`${baseAddress}/api/CardOrders/${CO_ID}`); // 假設商品 ID 為 123
        // await getAxios(`/api/Products/${pt.target.id}`, product); // 假設商品 ID 為 123
        // CheckPoints();
        const product = response.data;
        // console.log('product=>', product);

        // 設定選中的商品
        selectedCardOrder.value = product;
        selectedCardOrder.value.cA_Name = Name;
        // console.log('selectedCardOrder.value=>', selectedCardOrder.value);
        isDialogOpenCard.value = true;
        // console.log(isDialogOpenCard.value);
    } catch (error) {
        console.error('讀取商品資料失敗:', error);
    }
}

// 取消
const cancelOrder = async (CO_ID, CO_Name) => {
    const parts = parseInt(CO_Name.substring(5, 8));
    if (playerRefs.value.user.a_Coin>parts){
        var test = {};
    var request = {};
    request.CO_ID = isNaN(Number(CO_ID)) ? -1 : Number(CO_ID);
    request.CO_Cancel = true;
    request.CA_Name = "";
    // console.log("request=>", request);
    // axios.put(`${baseAddress}/api/CardOrders/Cancel/${CO_ID}`, request).then(response => {
    //     getCardOrderDTOes(props.accountA_ID);
    // });

    await putAxiosStringNodata(`/api/CardOrders/Cancel/${CO_ID}`, request, test);
    
    // console.log("parts=>", parts);
    playerRefs.value.user.a_Coin -= parts;
    ChangeAccountCoins(playerRefs.value.user.a_Coin);
    getCardOrderDTOes(playerRefs.value.user.a_ID);
    }
    else{
        alert("你無法取消訂單");
    }

    // 購買完成後關閉彈出視窗
    closeDialog();
}
// 關閉
const closeDialog = () => {
    isDialogOpenCard.value = false;
    selectedCardOrder.value = null;
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
const ShowCardOrder=(num)=>{
    CardOrderDTOes.value=[];
    if(num==0){
        getCardOrderDTOes(playerRefs.value.user.a_ID);
    }else {
        var request = {};
        request.CO_ID = 0;
        request.A_ID = isNaN(Number(playerRefs.value.user.a_ID)) ? -1 : Number(playerRefs.value.user.a_ID);
        request.CA_ID = 1;
        request.CA_Name = "";
        request.CO_Date = new Date();
        request.CO_Sum = 1;
        request.CO_Cancle = false;
        request.CO_Quantity = 1;

        axios.post(`${baseAddress}/api/CardOrders/FilterAccount`, request).then(response => {
            
            CardOrderDTOes.value = response.data;
        });
    }
};

</script>

<template lang="">
    <div class="btn-group mb-2" role="group" aria-label="Basic radio toggle button group">
        <input type="radio" class="btn-check" name="btnradio" id="btnradio1" autocomplete="off" checked>
        <label class="btn btn-outline-primary" for="btnradio1" @click="ShowCardOrder(0)">全部</label>

        <input type="radio" class="btn-check" name="btnradio" id="btnradio2" autocomplete="off">
        <label class="btn btn-outline-primary" for="btnradio2" @click="ShowCardOrder(1)">當月購買</label>

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
        <tbody id="table"  v-for="(item,index) in CardOrderDTOes" :key="item.cO_ID">
            <tr class="gray" >
                <td>
                    <div class="d-flex align-items-center">
                        <div class="ms-2">
                            <h6 class="mb-0 font-14 "># {{index + 1}}</h6>
                        </div>
                    </div>
                </td>
                <td>
                    <div id="test" :class="['badge', 'rounded-pill', 'p-2', 'text-uppercase', 'px-3', {'bg-danger': item.cO_Cancel, 'bg-success': !item.cO_Cancel}]" >
                        {{ item.cO_Cancel ? '訂單取消' : '訂單完成' }}
                    </div>
                </td>
                <td>
                    {{item.cA_Name}}
                </td>
                <td>
                    {{item.cO_Sum}}
                </td>
                <td>
                    {{getdatefilter(item.cO_Date)}}
                </td>
                <td>
                    <div class="d-flex order-actions">
                        <button v-if="!isButtonDisabled(item.cO_Date,item.cO_Cancel)" :disabled="isButtonDisabled(item.cO_Date,item.cO_Cancel)"  class="btn btn-danger rounded-circle" @click="CheckCancel(item.cO_ID,item.cA_Name)">X</button>                       
                    </div>
                </td>
            </tr>
        </tbody>
    </table>

<!-- 確認訂單是否刪除 -->
<div v-show="isDialogOpenCard" class="dialog buywidth bd-blue-200">  
    <div  class="rounded-3 my-4">
        確定取消訂單嗎?
    </div>
    <div class="rounded-3 m-auto">
        <button class="btn btn-primary m-1" @click="cancelOrder(selectedCardOrder.cO_ID,selectedCardOrder.cA_Name)">確定</button>
        <button class="btn btn-secondary" @click="closeDialog">關閉</button> 
    </div>
</div>



</template>

<style scoped>
     .w-90{
        width: 90%;
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