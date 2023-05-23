

<script>
export default {

}
</script>
<template lang="">
    <div class="container text-center">
    <h1 class="py-5">頁面跳轉中，請稍等～</h1>
    <div class="d-none">
      <h3>準備為訂單編號： {{order.id}} 付款</h3>
      <h4>總價 {{order.amount}}</h4>

      <form name="Spgateway" :action="tradeInfo.PayGateWay" method="POST">
        MerchantID:
        <input type="text" name="MerchantID" :value="tradeInfo.MerchantID" />
        <br />TradeInfo:
        <input type="text" name="TradeInfo" :value="tradeInfo.TradeInfo" />
        <br />TradeSha:
        <input type="text" name="TradeSha" :value="tradeInfo.TradeSha" />
        <br />Version:
        <input type="text" name="Version" :value="tradeInfo.Version" />
        <br />
        <button type="submit" class="btn btn-primary" id="postPayment">Payment</button>
      </form>
    </div>
  </div>
</template>
<style lang="">
    
</style>