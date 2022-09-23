<template>
  <div id="container">
    <div class="gridContainer">
      <div class="card" v-for="(item, id) in items" key="id">
        {{ item.title }}
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent, ref } from "vue";
import store from "../store/index";
export default defineComponent({
  name: "HomeView",
  setup() {
    const items = ref(store.getters.getItems);
    return { items };
  },
});
</script>
<style scoped lang="scss">
.gridContainer {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  grid-gap: 10px;
  padding: 10px;
}
</style>
