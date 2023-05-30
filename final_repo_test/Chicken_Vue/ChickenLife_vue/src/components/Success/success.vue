

<script setup>
const emit = defineEmits();
const props = defineProps({
  modelValue: {
    type: Boolean,
    required: true,
    default: false,
  },
});


</script>

<template>
     <div class="modal-overlay" @click="$emit('close-modal')">
    <div class="modal" @click.stop>
      <img class="check" src="https://res.cloudinary.com/dolqf5dmn/image/upload/v1685465779/check-icon_d8fajt.png" alt="" />
      <h6>Saved!</h6>
      <p>Your Details have been saved Successfully</p>
      <button>Go Home</button>
    </div>
    <div class="close" @click="$emit('close-modal')">
      <!-- <img class="close-img" src="~/assets/close-icon.svg" alt="" /> -->
    </div>
  </div>
</template>

<style scoped>
modal-overlay {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  background-color: #000000da;
  z-index: 1070;
}

.modal {
  text-align: center;
  position: fixed;
  background-color: white;
  height: 500px;
  width: 500px;
  margin-top: 10%;
  padding: 60px 0;
  border-radius: 20px;
  z-index: 999;
}
.close {
  margin: 10% 0 0 16px;
  cursor: pointer;
}

.close-img {
  width: 25px;
}

.check {
  width: 150px;
}

h6 {
  font-weight: 500;
  font-size: 28px;
  margin: 20px 0;
}

p {
  font-size: 16px;
  margin: 20px 0;
}

button {
  background-color: #ac003e;
  width: 150px;
  height: 40px;
  color: white;
  font-size: 14px;
  border-radius: 16px;
  margin-top: 50px;
}
</style>