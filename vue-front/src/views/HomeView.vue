<template>
  <div id="container">
    <div class="gridContainer">
      <div class="card" v-for="(item, id) in items" key="id">
        <ProductCard
          :title="item.title"
          :description="item.description"
          :imageSrc="item.filename"
        />
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { computed, ref } from "vue";
import store from "../store/index";
import ProductCard from "../components/ProductCard.vue";
export default {
  name: "HomeView",
  components: {
    ProductCard,
  },
  setup() {
    store.dispatch("fetchItems");
    const items = computed(() => store.getters.getItems);
    console.log(items);
    return { items };
  },
};
</script>
<style scoped lang="scss">
.gridContainer {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  grid-gap: 10px;
  padding: 10px;
}
</style>
