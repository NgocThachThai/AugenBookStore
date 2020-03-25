
<template>
  <div>
    <v-app-bar dark color='blue'>
      <v-spacer></v-spacer>
      <v-toolbar-title>Augen Book Store</v-toolbar-title>
      <v-spacer></v-spacer>
      <v-btn icon>
        <v-badge color="green" content="6">
          <v-icon>mdi-cart-outline</v-icon>
        </v-badge>
      </v-btn>
    </v-app-bar>
    <v-progress-linear v-if="isLoading" indeterminate color="teal"></v-progress-linear>
  </div>
</template>
<script>
import { mapGetters } from "vuex";
export default {
  data: () => ({
  }),
  computed: {
    ...mapGetters(["isLoading"])
  },
  methods: {}
};
</script>