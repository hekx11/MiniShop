import axios from "axios";
import { createStore } from "vuex";
import items from "../assets/products.json";

export default createStore({
  state: {
    item: [],
  },
  getters: {
    getItems(state) {
      return state.item;
    },
  },
  mutations: {
    setItems(state, payload) {
      state.item = payload;
    },
  },
  actions: {
    fetchItems({ commit }) {
      var data = "";

      var config = {
        method: "get",
        url: "https://localhost:7203/api/EndPointOne/",
        headers: {},
        data: data,
      };

      axios(config)
        .then(function (response: any) {
          console.log(JSON.stringify(response.data));
          commit("setItems", response.data);
        })
        .catch(function (error: any) {
          console.log(error);
        });
    },
  },
  modules: {},
});
