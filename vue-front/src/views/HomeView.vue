<template>
  <div id="container">
    <div
      class="gridContainer grid-cols-1 lg:grid-cols-3 md:grid-cols-3 sm:grid-cols-2"
    >
      <div class="cardWrap" v-for="(item, id) in items" key="id">
        <ProductCard
          :title="item.title"
          :description="item.description"
          :imageSrc="item.filename"
          :price="item.price"
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
#container {
  .gridContainer {
    display: grid;
    grid-gap: 10px;
    padding: 10px;

    .cardWrap {
      border: 1px solid rgb(102, 102, 102);
    }
    .cardWrap:hover {
      border: 1px solid #fff;
      transition: all 0.3s ease-in-out;
      cursor: pointer;
    }
  }
}
</style>
