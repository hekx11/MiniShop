import { createStore } from "vuex";
import items from "../assets/products.json";

export default createStore({
  state: {
    item: items,
  },
  getters: {
    getItems(state) {
      return state.item;
    },
  },
  mutations: {},
  actions: {},
  modules: {},
});
