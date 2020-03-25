<template>
  <v-dialog v-model="servicesConfirmation" max-width="800">
    <v-card>
      <v-card-title>Delivery Information</v-card-title>
      <v-card-text>
        <v-row>
          <v-col class="xs12">
            <keep-alive>
              <component ref="information" v-bind:is="deliverComponent" :data="data"/>
            </keep-alive>
          </v-col>
        </v-row>
      </v-card-text>
      <v-card-actions>
        <v-spacer />
        <v-btn block color="primary" dark @click="confirm">Ok</v-btn>
        <v-spacer />
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import { ServiceTypes } from "@/constants/enums";
import AircraftDeliverInfo from "../servicesConfirmations/AircraftDeliverInfo";
import MotobikeDeliverInfo from "../servicesConfirmations/MotobikeDeliverInfo";
import TrainDeliverInfo from "../servicesConfirmations/TrainDeliverInfo";
export default {
    components:{AircraftDeliverInfo, MotobikeDeliverInfo, TrainDeliverInfo},
  data() {
    return {
      servicesConfirmation: false,
      deliverComponent: "",
      data:{}
    };
  },
  computed: {},
  methods: {
    open(data) {
      this.deliverComponent = this.setComponent(data.serviceType);
      this.data = data;
      console.log(data);
      this.servicesConfirmation = true;
    },
    cancel() {
      this.servicesConfirmation = false;
    },
    setComponent(serviceType) {
      switch (serviceType) {
        case ServiceTypes.MOTOBIKE:
          return "MotobikeDeliverInfo";
        case ServiceTypes.TRAIN:
          return "TrainDeliverInfo";
        case ServiceTypes.AIRCRAFT:
          return "AircraftDeliverInfo";
      }
    },
    async confirm() {
      this.servicesConfirmation = false;
    }
  }
};
</script>
