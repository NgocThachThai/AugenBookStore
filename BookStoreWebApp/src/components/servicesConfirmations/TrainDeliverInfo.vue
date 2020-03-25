<template>
    <v-container row>
         <v-flex xs6 class="pa-2">
         <v-text-field
            label="Service"
            readonly
            :value="data.serviceName"
          ></v-text-field>
        </v-flex>
        <v-flex xs6 class="pa-2">
         <v-text-field
            label="Train No"
            readonly
            :value="data.trainNo"
          ></v-text-field>
        </v-flex>
        <v-flex xs6 class="pa-2">
         <v-text-field
            label="Station Arrival"
            readonly
            :value="data.stationArrival"
          ></v-text-field>
        </v-flex>
        <v-flex xs6 class="pa-2">
         <v-text-field
            label="Date Arrival"
            readonly
            :value="data.dateArrival"
          ></v-text-field>
        </v-flex>
        <v-flex xs6 class="pa-2">
         <v-text-field
            label="Cost"
            readonly
            :value="data.cost"
          ></v-text-field>
        </v-flex>
        <v-flex xs6 class="pa-2">
         <v-text-field
            label="Book"
            readonly
            :value="data.book.title"
          ></v-text-field>
        </v-flex>
    </v-container>
</template>
<script>
export default {
    props:{
        data: Object
    }
}
</script>