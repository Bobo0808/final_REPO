<script setup>
import { reactive, ref, onMounted } from "vue";
import Phaser from "./components/Phaser.vue";
import Modal from "./components/Shop/Modal.vue";
import { fuck, playerRefs, currentBody } from "./main.js";
import Sandy from "./components/Sandy.vue";
import profilePic from "./img/625157.jpg";
// import './js/dialogue.js';
import Account from "./components/Account.vue";
const C_Show=ref(false);
const closeableModal = ref(false);
currentBody.value = Account;
playerRefs.value.isPlay = true;
//確認商城開啟關掉鏡頭
const Checkshow = () => {
  if (closeableModal.value == false) {
    closeableModal.value = true;
  } else {
    closeableModal.value = false;
  }
};
const ClothShow=()=>{
  if(C_Show.value==false){
    C_Show.value==true;
  }
  else{
    C_Show.value==false;
  }
}

const showDialog = ref(true);

const showDialogBool = () => {
  showDialog.value = true;
};

const hideDialog = () => {
  showDialog.value = false;
};

const handleKeyPress = (event) => {
  if (event.key === "Enter" && showDialog.value) {
    hideDialog();
  } else if (event.key === "Enter" && !showDialog.value) {
    showDialog();
  }
};
</script>

<template>
  <header class="border-bottom">
    <div class="container">
      <div class="div-nav d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
        <i class="fa-solid fa-kiwi-bird fa-shake fa-xl"></i>

        <ul class="nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
          <ul>
            <a @click="Change" type="button" class="nav-link px-2 rounded-2">遊戲王</a>
        </ul>
        <li>
          <a href="#" class="nav-link px-2 link-secondary rounded-2">首頁</a>
        </li>
        <li>
          <a @click="Checkshow" type="button" class="nav-link px-2 rounded-2">商城</a>
          <Modal v-model="closeableModal" closeable header="商城"> </Modal>
        </li>
        <!-- <li>
          <a @click="Checkshow" type="button" class="nav-link px-2 rounded-2">衣櫥</a>
          <Modal v-model="closeableModal" closeable header="衣櫥"> </Modal>
        </li> -->
          <!-- <li><a href="#" class="nav-link px-2 link-secondary">首頁</a></li> -->
          <!-- <li><a href="#" class="nav-link px-2 link-dark">商城</a></li> -->
          <!-- <li><a href="#" class="nav-link px-2 link-dark">衣櫥</a></li> -->
          <li>
            <!-- <a @click="Change" type="button" class="nav-link px-2 rounded-2"
              >衣櫥</a
            > -->
            
            <Sandy style="position: absolute;top: 13px; right: 30%; width: 700px; height: 600px;"></Sandy>
            <!-- <a @click="Change" type="button" class="nav-link px-2 rounded-2">衣櫥</a> -->
            <!-- <Sandy style="position: absolute;top: 10px; right: 30%;"></Sandy> -->
          </li>

        </ul>

        <div class="ms-auto dropdown text-end">
          <a href="#" class="d-block link-dark text-decoration-none dropdown-toggle" id="dropdownUser1"
            data-bs-toggle="dropdown" aria-expanded="false">
            <img :src="profilePic" width="32" height="32" class="rounded-circle" />
          </a>
          <ul class="dropdown-menu text-small" aria-labelledby="dropdownUser1">
            <li><a class="dropdown-item" href="#">帳戶設定</a></li>
            <li><a class="dropdown-item" href="#">個人檔案</a></li>
            <li>
              <hr class="dropdown-divider" />
            </li>
            <li><a class="dropdown-item" href="#">登出</a></li>
          </ul>
        </div>
      </div>
    </div>
  </header>
  <div class="div-sidebar">
    <div class="d-flex flex-column flex-shrink-0 p-3 text-white bg-dark sideyellow" style="width: 280px">
      <a class="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-white text-decoration-none">
        <svg class="bi me-2" width="40" height="32"></svg>
        <span style="color: black; font-weight: 600; font-size: larger">好友</span>
      </a>
      <!-- <li id="lifepoint">
                              <a href="#" class="nav-link text-white">
                                  <svg class="bi me-2" width="16" height="16">
                                      <use xlink:href="#people-circle" />
                                  </svg>
                                  生活板
                              </a>
                              </li> -->
      <hr />
      <div class="friend_area">
        <div>
          <p>
            版權免責聲明<br />本網站使用的部分圖片和音樂素材可能受到版權保護，並且可能未經過所有者的授權使用。我們已經儘力確保在網站上使用的素材符合相關法律和法規。<br />對於本網站上使用的素材的版權歸屬情況，我們無法提供任何明示或暗示的擔保。如果您是素材的版權所有者並認為我們的使用侵犯了您的權益，請與我們聯繫，我們將立即采取相應的措施予以改正。<br />我們鼓勵所有使用本網站的用戶遵守相關的版權法律和法規。在使用本網站提供的素材之前，請您確保您已獲得所有必要的權利、許可和授權，以避免侵犯他人的版權。<br />如有任何疑問，請與我們聯繫。<br /><br />ChickenLive<br />Chickenlive@gmail.com
          </p>
        </div>
      </div>
    </div>
    <!-- <Phaser></Phaser> -->
    <component :is="currentBody" :closeableModal="closeableModal"></component>
  </div>
</template>

<script>
export default {
  data() {
    return {
      isPopupVisible: false,
    };
  },
  methods: {
    showPopup() {
      this.isPopupVisible = true;
    },
  },
};
</script>

<style src="./css/index.css"></style>
<style src="./css/sidebars.css"></style>
<style src="./css/style.css"></style>
<style src="../public/css/phaser_gamemode.css"></style>
<!-- <style src="./css/dialogue.css"></style> -->
<style scoped></style>