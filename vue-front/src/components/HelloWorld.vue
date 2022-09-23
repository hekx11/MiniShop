<script setup lang="ts">
import { ref, reactive } from "vue";

defineProps<{ msg: string }>();

const count = ref(0);
const state = reactive({
  message: "empty",
});
fetch("https://localhost:7203/api/EndPointOne")
  .then((response) => response.json())
  .then((response) => console.log(response));
</script>

<template>
  <p class="read-the-docs">Click on the Vite and Vue logos to learn more</p>
</template>

<style scoped></style>
