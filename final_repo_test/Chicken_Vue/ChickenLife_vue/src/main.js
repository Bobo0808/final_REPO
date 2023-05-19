import { createApp, ref } from 'vue'
import './style.css'
import '../node_modules/bootstrap/dist/css/bootstrap.min.css'
import App from './AppSample.vue'

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
export const getAxios =(baseAddress,route,data)=>{
    axios.get(baseAddress+route).then(response => {
        data.value = response.data;

    });
    return data.value
  }
export const postAxios =(baseAddress,route,data)=>{
    axios.post(baseAddress+route).then(response => {
        data.value = response.data;
    });
    return data.value
  }
app.provide
app.mount('#app')
