import *  as types from "./mutation-type";
import * as bookService from "@/services/book-service"
const state = {
    books:[]
  };
  
  // getters
  const getters = {
    books: (state) => state.books,
  };
  
  const mutations = {
    [types.SET_BOOKS](state, { data }) {
      state.books = data;
    },
  };
  
  const actions = {
    async getBooks({ commit }, searchText) {
      var result = await bookService.getBooks(searchText);
      commit(types.SET_BOOKS, { data: result.data.items });
    },
    async buyBook(context, deliveryInfor){
      var result = await bookService.buyBook(deliveryInfor);
      console.log(result);
    }
  };
  
  export default {
    state,
    getters,
    mutations,
    actions
  };
  