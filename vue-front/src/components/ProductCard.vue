<template>
  <div class="card">
    <div class="cardImage">
      <img :src="getImageUrl(this.imageSrc)" alt="product image" />
    </div>
    <div class="cardContent">
      <h3>{{ title }}</h3>
      <p>{{ description }}</p>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";
import store from "../store/index";

export default defineComponent({
  name: "ProductCard",
  props: {
    title: String,
    description: String,
    imageSrc: String,
  },
  setup(props) {
    const getImageUrl = (name: String) => {
      return new URL(`../assets/images/aaa.png`, import.meta.url).href;
    };
    return { getImageUrl };
  },
});
</script>
<style lang="scss">
img {
  max-width: 100%;
  height: 100%;
}
</style>
