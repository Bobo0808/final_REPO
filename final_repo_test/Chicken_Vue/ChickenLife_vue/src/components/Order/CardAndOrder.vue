
<script setup>
import { onMounted, ref } from 'vue';
import CardOrder from '../Order/CardOrder.vue';
import Order from '../Order/Order.vue';
import { playerRefs, baseAddress } from '../../main.js';

const props = defineProps({
  accountA_ID: {
    type: Number,
    required: true,
    default: 0
  },
});

</script>

<template lang="">

<div class="accordion row" id="accordionExample">
  <div class="col col-lg-6 ">
    <div class="accordion-item ">
      <h2 class="accordion-header" id="headingOne">
        <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
          點數購買紀錄
        </button>
      </h2>
      <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
        <div class="accordion-body h-50">
          <CardOrder  />
        </div>
      </div>
    </div>    
  </div>
  <div class="col col-lg-6 ">
    <div class="accordion-item  ">
      <h2 class="accordion-header " id="headingTwo">
        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
          衣服購買紀錄
        </button>
      </h2>
      <div id="collapseTwo" class="accordion-collapse collapse" aria-labelledby="headingTwo" data-bs-parent="#accordionExample">
        <div class="accordion-body h-50">
          <Order  />
        </div>
      </div>
    </div>
  </div>
</div>
    
    

</template>

<style scopt>
.test{
  display: flex;
  justify-content: row;
}
    
</style>