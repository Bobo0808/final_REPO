import { createApp } from 'vue'
import './style.css'
import App from './App.vue'

const app = createApp(App);
app.config.globalProperties.Uid = '78';
app.mount('#app')
