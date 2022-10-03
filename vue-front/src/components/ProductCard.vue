<template>
  <div class="card flex flex-col text-center">
    <div class="cardImage flex justify-center">
      <img :src="getImageUrl(this.imageSrc)" alt="product image" />
    </div>
    <div class="cardContent pt-4">
      <h3 class="text-xl font-bold">{{ title }}</h3>
      <p>{{ description }}</p>
      <p>{{ price }}</p>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";
import currency from "currency.js";

export default defineComponent({
  name: "ProductCard",
  props: {
    title: String,
    description: String,
    imageSrc: String,
    price: Number,
  },
  setup(props) {
    const getImageUrl = (name: String) => {
      return new URL(`../assets/images/aaa.png`, import.meta.url).href;
    };
  },
});
</script>
<style lang="scss">
.card {
  padding: 2em;
  img {
    max-width: 300px;
    height: 100%;
  }
}
</style>
