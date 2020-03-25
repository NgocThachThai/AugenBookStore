import Vue from "vue";
import Vuex from "vuex";
import application from './modules/application'
import bookStore from './modules/bookStore'
import vendorDelivery from './modules/vendorDelivery'
Vue.use(Vuex);

const store = new Vuex.Store({
  strict: true,
  modules: {
    application,
    bookStore,
    vendorDelivery
  }
});

export default store;
