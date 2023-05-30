<script setup>
import { reactive, ref } from "vue";
import { postAxiosObj } from "../main.js";
import { playerRefs, currentBody } from "../main.js";
import Phaser from "./Phaser.vue";
import { inject } from "vue";
import { setMemberData } from "../js/userdata.js";
// const memberData = getMemberData();
// console.log(memberData);
const Account = ref({
  email: "user@example.com",
  password: "string",
});

const register = ref({
  email: "",
  password: "",
  confirmPassword: "",
  gender: 1,
  nickName: "",
});
const error_message = ref();

const Handerror = (err) => {
  Object.key(err).forEach((erro) => (error_message[erro] = err[erro]));
  console.log(error_message);
};

const Ruser = ref();
const hadlesubmit = async () => {
  await postAxiosObj("/api/User/register", register, Ruser);
  successFn();
  console.log(Ruser.value);
};
const isReg = ref(false);
// const successFn = () => {
//   alert("註冊成功");
//   isReg.value = true;
// };
const successFn = () => {
  console.log("註冊成功");
  console.log(Ruser.value);
  alert("註冊成功");
  isReg.value = true;
};

let route = "https://localhost:7093/api/User/login";

//1
const CheckAccount = async () => {
  await postAxiosObj("/api/User/login", Account, playerRefs);
  printValue(playerRefs);
  currentBody.value = Phaser;
};

function printValue(value) {
  console.log(value.value);
}

const view = ref(1);
const changeView = (index) => {
  view.value = index;
};
</script>
<script>
export default {
  name: "App",
};
</script>
<template>
  <div class="ALL">
    <!-- <div v-if="!isreg"> -->
    <header>
      <h2 class="logo">ChickenLive</h2>
      <nav class="navigation">
        <a href="#">驗證</a>
        <!-- <a href="#">TEST</a>
            <a href="#">TEST</a>
            <a href="#">TEST</a>
            <a href="#">TEST</a> -->
        <button @click="changeView(1)" class="btnLogin-popup">Login</button>
      </nav>
    </header>
    <div class="wrapper">
      <span class="icon-close">
        <ion-icon name="close"></ion-icon>
      </span>
      <div class="form-box login" v-if="view === 1">
        <h2>Login</h2>
        <form action="#">
          <div class="input-box">
            <span class="icon"><ion-icon name="mail"></ion-icon></span>
            <input type="text" v-model="Account.email" required />
            <label for=""> Email</label>
          </div>
          <div class="input-box">
            <span class="icon"><ion-icon name="lock-closed"></ion-icon></span>
            <input type="password" v-model="Account.password" required />
            <label for=""> Password</label>
          </div>
          <div class="remember-forget">
            <label><input type="checkbox" />記住我</label>
            <a href="#">忘記密碼?</a>
          </div>
          <button type="submit" class="btn" @click="CheckAccount">Login</button>
          <div class="login-register">
            <p>
              還沒有帳號?<a
                @click="changeView(2)"
                href="#"
                class="register-link"
                >註冊</a
              >
            </p>
          </div>
        </form>
      </div>

      <div class="form-box register" v-if="view === 2">
        <h2>Registerion</h2>
        <form action="#">
          <div class="input-box">
            <span class="icon"><ion-icon name="mail"></ion-icon></span>
            <input type="text" v-model="register.email" required />
            <label for=""> Email</label>
          </div>
          <div class="input-box">
            <span class="icon"><ion-icon name="mail"></ion-icon></span>
            <input type="text" v-model="register.nickName" required />
            <label for=""> 暱稱</label>
          </div>
          <div class="input-box">
            <span class="icon"><ion-icon name="lock-closed"></ion-icon></span>
            <input type="password" v-model="register.password" required />
            <label for=""> Password</label>
          </div>
          <div class="input-box">
            <span class="icon"><ion-icon name="lock-closed"></ion-icon></span>
            <input
              type="password"
              v-model="register.confirmPassword"
              required
            />
            <label for=""> confirmPassword</label>
          </div>
          <div class="gender-details">
            <input
              type="radio"
              name="gender"
              id="dot-1"
              :value="0"
              v-model="register.gender"
            />
            <input
              type="radio"
              name="gender"
              id="dot-2"
              :value="1"
              v-model="register.gender"
            />
            <span class="gender-title">性別</span>
            <div class="category">
              <label for="dot-1">
                <span class="dot one"></span>
                <span class="gender">男性</span>
              </label>
              <label for="dot-2">
                <span class="dot two"></span>
                <span class="gender">女性</span>
              </label>
            </div>
          </div>
          <div class="remember-forget">
            <label><input type="checkbox" />我同意此項條款</label>
          </div>
          <button @click="hadlesubmit" type="submit" class="btn">
            Register
          </button>
          <div class="login-register">
            <p>
              已經有帳號了?<a @click="changeView(1)" href="#" class="login-link"
                >登入</a
              >
            </p>
          </div>
        </form>
      </div>
    </div>
    <!-- <div v-if="isreg">
        <h3>註冊成功</h3>
      </div> -->
  </div>
  <!-- </div> -->
</template>


<style scoped>
.ALL {
  display: flex;
  justify-content: center;
  align-items: center;
  min-height: 100vh;
  background: url("src/background3.jpg") no-repeat;
  background-size: cover;
  background-position: center;
  width: 100%;
  box-shadow: inset 0 0 100px rgba(0, 0, 0, 0.5);
}

header {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  padding: 20px 100px;
  background-color: rgb(39, 37, 36);
  display: flex;
  justify-content: space-between;
  align-items: center;
  z-index: 99;
}

.logo {
  font-size: 2em;
  color: #fff;
}

.navigation a {
  position: relative;
  font-size: 1.1em;
  color: #fff;
  text-decoration: none;
  font-weight: 500;
  margin-left: 40px;
}

.navigation a::after {
  content: "";
  position: absolute;
  left: 0;
  bottom: -6px;
  width: 100%;
  height: 3px;
  background: #fff;
  border-radius: 5px;
  transform-origin: right;
  transform: scaleX(0);
  transition: transform 0.5s;
}

.navigation a:hover::after {
  transform: scaleX(1);
}

.navigation .btnLogin-popup {
  width: 130px;
  height: 50px;
  background: transparent;
  border: 2px solid #fff;
  outline: none;
  border-radius: 6px;
  cursor: pointer;
  font-size: 1.1em;
  color: #fff;
  font-weight: 500;
  margin-left: 40px;
  transition: 0.5s;
}

.navigation .btnLogin-popup:hover {
  background: #fff;
  color: #162938;
}

.wrapper {
  position: relative;
  width: 600px;
  height: 650px;
  background: transparent;
  border: 2px solid rgba(255, 255, 255, 0.5);
  border-radius: 20px;
  backdrop-filter: blur(20px);
  box-shadow: 0 0 30px rgba(0, 0, 0, 0.5);
  display: flex;
  justify-content: center;
  align-items: center;
  overflow: hidden;
}

.wrapper .form-box {
  width: 100%;
  padding: 40px;
}

.form-box .gender-details .gender-title {
  color: black;
  font-size: 25px;
  font-weight: 400;
}

.form-box .category {
  color: black;
  display: flex;
  width: 80%;
  margin: 14px 0;
  justify-content: space-between;
}

.form-box .category label {
  display: flex;
  align-items: center;
  cursor: pointer;
}

.form-box .category label .dot {
  height: 18px;
  width: 18px;
  border-radius: 50%;
  margin-right: 10px;
  background: #d9d9d9;
  border: 5px solid transparent;
  transition: all 0.3s ease;
}

#dot-1:checked ~ .category label .one,
#dot-2:checked ~ .category label .two,
#dot-3:checked ~ .category label .three {
  background: #9b59b6;
  border-color: #d9d9d9;
}

.form-box input[type="radio"] {
  display: none;
}
/* .wrapper .form-box.register {
  /* position: absolute;
  transform: translateX(400px); }*/

.wrapper .icon-close {
  position: absolute;
  top: 0;
  right: 0;
  width: 45px;
  height: 45px;
  background: #162938;
  font-size: 2em;
  color: #fff;
  display: flex;
  justify-content: center;
  align-items: center;
  border-bottom-left-radius: 20px;
  cursor: pointer;
  z-index: 1;
}

.form-box h2 {
  font-size: 2em;
  color: #162938;
  text-align: center;
}

.input-box {
  position: relative;
  width: 100%;
  height: 50px;
  border-bottom: 2px solid #162938;
  margin: 30px 0;
}

.input-box label {
  position: absolute;
  top: 50%;
  left: 5px;
  transform: translateY(-50%);
  font-size: 1em;
  color: #162938;
  font-weight: 500;
  pointer-events: none;
  transition: 0.5s;
}

.input-box input:focus ~ label,
.input-box input:valid ~ label {
  top: -5px;
}

.input-box input {
  width: 100%;
  height: 100%;
  background: transparent;
  border: none;
  outline: none;
  font-size: 1em;
  color: #162938;
  font-weight: 600;
  padding: 0 25px 0 5px;
}

.input-box .icon {
  position: absolute;
  right: 8px;
  font-size: 1.2em;
  color: #162938;
  line-height: 57px;
}

.remember-forget {
  font-size: 0.9em;
  color: #162938;
  font-weight: 500;
  margin: -15px 0 15px;
  display: flex;
  justify-content: space-between;
}

.remember-forget label input {
  accent-color: #162938;
  margin-right: 3px;
}

.remember-forget a {
  color: #162938;
  text-decoration: none;
}

.remember-forget a:hover {
  text-decoration: underline;
}

.btn {
  width: 100%;
  height: 45px;
  background: #162938;
  border: none;
  outline: none;
  border-radius: 6px;
  cursor: pointer;
  font-size: 1em;
  color: #fff;
  font-weight: 500;
}

.login-register {
  font-size: 0.9em;
  color: #162938;
  text-align: center;
  font-weight: 500;
  margin: 25px 0 10px;
}

.login-register p a {
  color: #162938;
  text-decoration: none;
  font-weight: 600;
}

.login-register p a:hover {
  text-decoration: underline;
}
</style>

<style>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: "Poppins" sans-serif;
}
</style>