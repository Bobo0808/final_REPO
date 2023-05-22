import { createApp, ref } from 'vue'
// import './style.css'
import '../node_modules/bootstrap/dist/css/bootstrap.min.css'
import App from './AppSample.vue'
// import { response } from 'express';
import Account from "./components/Account.vue"

const baseAddress = "https://localhost:7093";

const app = createApp(App);
app.config.globalProperties.playerRef = ref({
  id: 1,
  name: ['shit', 'fuck', 'bitch', 'suck', 'cock'],
  gender: 1
});



export const fuck = () => {
  alert('hello world');
  return app.config.globalProperties;
};
export const getAxios = (route, data) => {
  axios.get(baseAddress + route).then(response => {
    data.value = response.data;
  });
  return data
}
export const postAxiosObj = (route, data,res) => {
  axios.post(baseAddress + route,data.value).then(response => {
    res.value = response.data;
  });
  return res
}

export const postAxiosString = (route, data,res) => {
  axios.post(baseAddress + route,data.value).then(response => {
    res.value = response;
  });
  return res
}

export const putAxiosObj = (route, data,res) => {
  axios.put(baseAddress + route,data.value).then(response => {
    res.value = response.data;
  });
  return res;
}

export const putAxiosString = (route, data,res) => {
  axios.put(baseAddress + route,data.value).then(response => {
    res.value = response;
  });
  return res;
}



const script1 = document.createElement('script');
script1.src = 'https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.esm.js';
script1.type = 'module';

const script2 = document.createElement('script');
script2.src = 'https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.js';
script2.setAttribute('nomodule', '');

document.head.appendChild(script1);
document.head.appendChild(script2);

export default app.config.globalProperties.playerRef;

app.component("Account", Account)
app.provide
app.mount('#app')
