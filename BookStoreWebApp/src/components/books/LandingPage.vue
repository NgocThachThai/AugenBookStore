<template>
  <v-container fluid row>
    <v-flex xs12>
      <Searching v-on:submitSearch="search" />
    </v-flex>
    <v-flex xs6 md4 v-for="item in books" :key="item.id" class="pa-2">
      <v-hover v-slot:default="{ hover }" close-delay="200">
        <v-card :elevation="hover ? 16 : 2" class="mx-auto" max-width="300">
          <v-img
            height="400"
            :src="item.volumeInfo.imageLinks?item.volumeInfo.imageLinks.smallThumbnail:'https://icons.iconarchive.com/icons/paomedia/small-n-flat/512/book-icon.png'"
          ></v-img>
          <v-card-title class="justify-center">{{item.volumeInfo.title}}</v-card-title>
          <v-card-text
            align="center"
          >{{item.volumeInfo.authors?item.volumeInfo.authors.join(", "):""}} - {{item.volumeInfo.publishedDate}}</v-card-text>
          <v-fade-transition>
            <v-overlay v-if="hover" absolute color="primary">
              <v-btn color="primary" @click="openItemDetail(item)">Mua</v-btn>
            </v-overlay>
          </v-fade-transition>
        </v-card>
      </v-hover>
    </v-flex>
    <DetailPopup ref="detailPopup"/>
  </v-container>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import Searching from "../common/Searching";
import DetailPopup from "./DetailPopup";
export default {
  components: {
    Searching,
    DetailPopup
  },
  data() {
    return {
      selectedItem:{}
    };
  },
  computed: {
    ...mapGetters(["books"])
  },
  methods: {
    ...mapActions(["getBooks"]),
    search(searchText){
      this.getBooks(searchText);
    },
    openItemDetail(item){
      this.$refs.detailPopup.open(item);
    }
  },
  async created() {}
};
</script>
