<template>
  <v-form ref="searchingForm" lazy-validation>
    <v-text-field
      class="pa-4"
      v-model="search"
      append-icon="mdi-magnify"
      label="Search"
      single-line
      outlined
      :rules="requiredField"
      v-on:keydown.enter.prevent="submitSearching"
      @click:append="submitSearching"
    ></v-text-field>
  </v-form>
</template>

<script>
import { mapActions } from "vuex";
import { RequiredField } from "@/constants/rules";
export default {
  data() {
    return {
      search: "",
      requiredField: RequiredField,
      eventName:"submitSearch"
    };
  },
  computed: {},
  methods: {
    ...mapActions(["getBooks"]),
    submitSearching() {
      if (this.$refs.searchingForm.validate()) {
        this.$emit(this.eventName, this.search);
      }
    }
  },
  async created() {}
};
</script>
