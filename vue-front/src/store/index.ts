import axios from "axios";
import currency from "currency.js";
import { createStore } from "vuex";

export default createStore({
  state: {
    item: [
      {
        id: 0,
        Title: "",
        Type: "",
        Description: "",
        Filename: "",
        Price: 0,
        Rating: 0,
      },
    ],
    total: 0,
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
    addTotal(state, id) {
      var price = currency(state.item[id].Price).value;
      console.log("Cena + " + price);
      currency(state.total).add(price).value;
      state.total = currency(state.total).add(price).value;
      console.log(state.total);
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
          commit("setItems", response.data);
        })
        .catch(function (error: any) {
          console.log(error);
        });
    },
  },
  modules: {},
});
