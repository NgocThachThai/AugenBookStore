import Vue from 'vue'
import Router from 'vue-router'
import LandingPageBooks from './components/books/LandingPage.vue'
Vue.use(Router)

var router = new Router({
  mode: "history",
  base: '',
  routes: [
    {
      path: '/',
      name: 'home',
      component: LandingPageBooks,
    }
  ]
});


export default router;

