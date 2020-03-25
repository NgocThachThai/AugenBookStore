import axios from "axios";
import store from "@/store";

const axiosInterceptor = {
  setup() {
    axios.interceptors.request.use(
      async config => {
        store.commit('SET_LOADING', true);
        config.headers["Pragma"] = "no-cache";
        return config;
      },
      err => {
        store.commit('SET_LOADING', false);
        return Promise.reject(err);
      }
    );

    axios.interceptors.response.use(

      function(response) {
        store.commit('SET_LOADING', false);
        // Do something with response data
        return response;
      },
      function(error) {
        store.commit('SET_LOADING', false);
        // Do something with response error
        if (error.response) {
          // Access and handle error from response here
          console.log(error.response.status);
          console.log(error.response.data);
        }
        return Promise.reject(error);
      }
    );
  }
};

export default axiosInterceptor;
