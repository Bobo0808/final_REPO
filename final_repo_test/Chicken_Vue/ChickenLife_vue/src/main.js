import { createApp, ref } from 'vue'
import '../node_modules/bootstrap/dist/css/bootstrap.min.css'
import App from './App.vue'
// import { response } from 'express';
// import Account from "./components/Account.vue"
import { register } from 'swiper/element/bundle';
export const baseAddress = "https://localhost:7093";
// export const baseAddress = "https://chickenlife.azurewebsites.net";



const app = createApp(App);

// const currentBody = ref(Phaser);
export const currentBody = ref();

app.config.globalProperties.playerRef = ref({
  id: 1,
  name: ['shit', 'fuck', 'bitch', 'suck', 'cock'],
  gender: 1
});

//玩家資料
export let playerRefs = ref({
  id: 1,
  name: ['shit', 'fuck', 'bitch', 'suck', 'cock'],
  gender: 1,
  isPlay: false,
  coins: 1200,
  clothes: [],
});

export const fuck = () => {
  alert('hello world');
  return app.config.globalProperties;
};


export const getAxios = async (route, data) => {
  await axios.get(baseAddress + route.value).then(response => {
    console.log(route.value)
    return data.value = response.data;
  });
}

export const getAxiosNoData = async (route, data) => {
  await axios.get(baseAddress + route).then(response => {
    data.value = response.data;
  });
  return data
}

export const postAxiosObj = async (route, data, res) => {
  await axios.post(baseAddress + route, data.value).then(response => {
    return res.value = response.data;
  });
}

export const postAxiosString = async (route, data, res) => {
  try {
    await axios.post(baseAddress + route, data.value).then(response => {
      res = response;
      return res
    })
  }

  catch (error) {
    console.log(error);
  };

}

export const putAxiosObj = async (route, data, res) => {
  await axios.put(baseAddress + route, data.value).then(response => {
    res.value = response.data;
  });
  return res;
}

export const postAxiosObjNodata = async (route, data, res) => {
  await axios.post(baseAddress + route, data).then(response => {
    res.value = response.data;
    // console.log("res=>", res)
    // console.log("response.data=>", response.data)
  });
  return res
}

export const putAxiosString = async (route, data, res) => {
  await axios.put(baseAddress + route, data.value).then(response => {
    res.value = response;
  });
  return res;
}

export const putAxiosStringNodata = async (route, data, res) => {
  await axios.put(baseAddress + route, data).then(response => {
    res.value = response;
  });
  return res;
}

// datetime只取年月日
export const getDate = (databasedate) => {
  const today = new Date(databasedate);
  const date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();
  const time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
  const dateTime = date + ' ' + time;
  //console.log("date=>", date);
  return date
};

//處理登入回應資料的地方






//登入的icon
const script1 = document.createElement('script');
script1.src = 'https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.esm.js';
script1.type = 'module';

const script2 = document.createElement('script');
script2.src = 'https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.js';
script2.setAttribute('nomodule', '');

document.head.appendChild(script1);
document.head.appendChild(script2);

export default app.config.globalProperties.playerRef;

// app.component("Account", Account)

app.use(register);
app.provide
app.mount('#app')
