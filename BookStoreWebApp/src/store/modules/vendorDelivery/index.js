import *  as types from "./mutation-type";
import * as vendorService from "@/services/vendor-service"
const state = {
    packages:[]
  };
  
  // getters
  const getters = {
    packages: (state) => state.packages,
  };
  
  const mutations = {
    [types.SET_PACKAGES](state, { data }) {
      state.packages = data;
    },
  };
  
  const actions = {
    async getPackages({commit})
    {
      var result = await vendorService.getPackages();
      commit(types.SET_PACKAGES, { data: result.data });
    }
  };
  
  export default {
    state,
    getters,
    mutations,
    actions
  };
  