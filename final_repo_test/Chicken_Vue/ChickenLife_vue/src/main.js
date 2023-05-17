import { createApp, ref } from 'vue'
import './style.css'

import App from './App.vue'

const app = createApp(App);
app.config.globalProperties.playerRef = ref({
    id: 1,
    name: ['shit', 'fuck', 'bitch', 'suck', 'cock'],
    gender: 1
});
app.mount('#app')
