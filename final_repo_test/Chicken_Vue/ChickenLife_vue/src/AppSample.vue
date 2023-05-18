<script setup>
import HelloWorld from './components/HelloWorld.vue'
import { ref } from 'vue'
import {fuck} from './main.js'

fuck();
let i = ref(0);
</script>

<template>
  <div><button class="btn btn-primary" type="button" @click="playerRef.value.id++">Uid is {{ playerRef.value.id }}</button></div>
  <div><button type="button" @click="i++">Name is {{ playerRef.value.name[i] }}</button></div>
  <div v-if="playerRef.value.gender == 1">Gender is male</div>
  <div v-else>Gender is female</div>
  <div>
    <a href="https://vitejs.dev" target="_blank">

      <img src="/vite.svg" class="logo" alt="Vite logo" />
    </a>
    <a href="https://vuejs.org/" target="_blank">
      <img src="./assets/vue.svg" class="logo vue" alt="Vue logo" />
    </a>
  </div>
  <HelloWorld msg="Vite + Vue" />
</template>


<style scoped>
.logo {
  height: 6em;
  padding: 1.5em;
  will-change: filter;
  transition: filter 300ms;
}

.logo:hover {
  filter: drop-shadow(0 0 2em #646cffaa);
}

.logo.vue:hover {
  filter: drop-shadow(0 0 2em #42b883aa);
}
</style>
