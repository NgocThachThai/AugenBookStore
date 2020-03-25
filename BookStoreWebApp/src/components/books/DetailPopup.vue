<template>
  <v-dialog v-model="detailDialog" max-width="800">
    <v-card>
      <v-card-title>
        Detail
        <v-spacer />
        <v-btn color="red" icon @click="cancel">
          <v-icon>mdi-close</v-icon>
        </v-btn>
      </v-card-title>
      <v-card-text>
        <v-row>
          <v-col class="xs6">
            <v-card>
              <v-img
                height="200"
                :src="item.volumeInfo.imageLinks?item.volumeInfo.imageLinks.smallThumbnail:'https://icons.iconarchive.com/icons/paomedia/small-n-flat/512/book-icon.png'"
              ></v-img>
              <v-card-title class="justify-center">{{item.volumeInfo.title}}</v-card-title>
              <v-card-text
                align="center"
              >{{item.volumeInfo.authors?item.volumeInfo.authors.join(", "):""}} - {{item.volumeInfo.publishedDate}}</v-card-text>
            </v-card>
          </v-col>
          <v-col class="xs6">{{item.volumeInfo.description}}</v-col>
        </v-row>
        <v-row>
          <v-col cols="12">
            <p>Ship via</p>
            <v-divider></v-divider>
            <v-btn-toggle
              v-model="serviceTypeSelected"
              tile
              group
              class="text-center"
            >
              <v-btn
                v-for="item in packages"
                :key="item.serviceType"
                :value="item.serviceType"
              >{{item.vendorName}} ${{item.cost}}</v-btn>
            </v-btn-toggle>
          </v-col>
        </v-row>
      </v-card-text>
      <v-card-actions>
        <v-spacer />
        <v-btn block color="pink" dark @click="confirm">BUY</v-btn>
        <v-spacer />
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import { ServiceTypes } from "@/constants/enums";
export default {
  data() {
    return {
      detailDialog: false,
      item: {
        volumeInfo: {}
      },
      serviceTypeSelected: ServiceTypes.MOTOBIKE
    };
  },
  computed: {
    ...mapGetters(["packages"])
  },
  methods: {
    ...mapActions(["getPackages", "buyBook"]),
    open(item) {
      this.detailDialog = true;
      this.item = item;
      console.log(item);
      this.selectDefaultPackage();
    },
    cancel() {
      this.detailDialog = false;
    },
    async confirm() {
      let deliveryInfor = {
        serviceType: this.serviceTypeSelected,
        book:{
          id: this.item.id,
          title: this.item.volumeInfo.title,
          thumbnail: this.item.volumeInfo.imageLinks?this.item.volumeInfo.imageLinks.smallThumbnail:null,
          authors: this.item.volumeInfo.authors?this.item.volumeInfo.authors.join(", "): null,
          publishedDate: this.item.volumeInfo.publishedDate
        }
      }
      await this.buyBook(deliveryInfor);
      this.detailDialog = false;
    },
    selectDefaultPackage(){
      if(this.packages && this.packages.length > 0){
        this.serviceTypeSelected = this.packages[0].serviceType;
      }
    }
  },
  async created() {
    await this.getPackages();
    this.selectDefaultPackage();
  }
};
</script>
