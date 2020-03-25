const state = {
    isLoading: false,
  };
  
  const getters = {
    isLoading: state => state.isLoading
  };
  
  const mutations = {
    SET_LOADING(state, isLoading){
      state.isLoading = isLoading
    }
  };
  
  const actions = {
    setLang({commit}, payload) {
      commit('SET_LANG', payload)
    },
    setLoading({commit}, isLoading) {
      commit('SET_LOADING', isLoading)
    }
  };
  
  export default {
    state,
    getters,
    mutations,
    actions
  };
  