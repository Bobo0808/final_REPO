
<script setup>
import { onMounted, ref, inject } from 'vue';
import { getAxios, getDate } from '../../main';
// const baseAddress = "https://localhost:7097";
const baseAddress = "https://localhost:7093";

const props = defineProps({
    accountA_ID: {
        type: Number,
        required: true,
        default: 0
    },
})

const OrderDTOes = ref([]);
const datefilter = ref(null);

// const formatDate = inject('formatDate');

const getOrderDTOes = (A_ID) => {
    var request = {};
    request.A_ID = isNaN(Number(A_ID)) ? -1 : Number(A_ID);
    request.productName = "";
    //getAxios(`${baseAddress}`, "/api/Order", OrderDTOes);

    //console.log("request.A_ID=>",request.A_ID);
    //console.log("request=>",request);

    //原本axios呼叫指令碼
    axios.post(`${baseAddress}/api/Order/Show`, request).then(response => {
        //alert(JSON.stringify(response.data));
        OrderDTOes.value = response.data;
        // console.log("OrderDTOes.value=>", OrderDTOes.value);
    });
};

const getdatefilter = (datefilter) => {
    return getDate(datefilter);
    //console.log("datefilter=>",datefilter);
}

onMounted(() => {
    getOrderDTOes(props.accountA_ID);
    console.log("props.accountA_ID=>", props.accountA_ID);
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

// 取消訂單
const cancelOrder = (O_ID) => {
    console.log("O_ID=>", O_ID);
    var request = {};
    request.O_ID = isNaN(Number(O_ID)) ? -1 : Number(O_ID);
    request.O_Cancle = true;
    request.productName = "";
    axios.put(`${baseAddress}/api/Order/Cancel/${O_ID}`, request).then(response => {
        getOrderDTOes(props.accountA_ID);
    });
};





</script>

<template lang="">
    <nav aria-label="Page navigation example">
  <ul class="pagination justify-content-end btn:hover">
    <li class="page-item"><a class="page-link" href="#">全部</a></li>
    <li class="page-item"><a class="page-link" href="#">當月</a></li>
    <li class="page-item"><a class="page-link" href="#">購買</a></li>
    <li class="page-item"></li>
  </ul>
</nav>
    <table class="table mb-0 border w-80">
        <thead class="table-light">
            <tr>
                <th class="col-1">Order#</th>
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
                        <button v-if="!isButtonDisabled(item.o_Date,item.o_Cancle)" :disabled="isButtonDisabled(item.o_Date,item.o_Cancle)" class="btn btn-danger" @click="cancelOrder(item.o_ID)">取消</button>
                        
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</template>

<style lang="">
    
</style>