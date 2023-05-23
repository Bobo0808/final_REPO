
<script setup>
import { onMounted, ref } from 'vue';
import { getDate } from '../../main';
// const baseAddress = "https://localhost:7097";
const baseAddress = "https://localhost:7093";

const props = defineProps({
    accountA_ID: {
        type: Number,
        required: true,
        default: 0
    },
})

const CardOrderDTOes = ref([]);
const datefilter = ref(null);

const getCardOrderDTOes = (A_ID) => {
    var request = {};
    request.A_ID = isNaN(Number(A_ID)) ? -1 : Number(A_ID);
    request.CA_Name = "";
    axios.post(`${baseAddress}/api/CardOrders/Show`, request).then(response => {
        // alert(JSON.stringify(response.data));
        CardOrderDTOes.value = response.data;
        // console.log(CardOrderDTOes.value);
    });
};

const getdatefilter = (datefilter) => {
    return getDate(datefilter);
    //console.log("datefilter=>",datefilter);
};

onMounted(() => {
    getCardOrderDTOes(props.accountA_ID);
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
// 取消
const cancelOrder = (CO_ID) => {
    var request = {};
    request.CO_ID = isNaN(Number(CO_ID)) ? -1 : Number(CO_ID);
    request.CO_Cancel = true;
    request.CA_Name = "";
    // console.log("request=>", request);
    axios.put(`${baseAddress}/api/CardOrders/Cancel/${CO_ID}`, request).then(response => {
        getCardOrderDTOes(props.accountA_ID);
    });
}


</script>

<template lang="">
    <table class="table mb-0 border w-80 text-center">
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
        <tbody id="table"  v-for="(item,index) in CardOrderDTOes" :key="item.cO_ID">
            <tr class="gray" >
                <td>
                    <div class="d-flex align-items-center">
                        <div class="ms-2">
                            <h6 class="mb-0 font-14"># {{index + 1}}</h6>
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
                        <button v-if="!isButtonDisabled(item.cO_Date,item.cO_Cancel)" :disabled="isButtonDisabled(item.o_Date,item.cO_Cancel)"  class="btn btn-danger" @click="cancelOrder(item.cO_ID)">取消</button>
                        
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</template>

<style lang="">
    
</style>