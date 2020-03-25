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
            label="Drive Name"
            readonly
            :value="data.driveName"
          ></v-text-field>
        </v-flex>
        <v-flex xs6 class="pa-2">
         <v-text-field
            label="Mobile Phone"
            readonly
            :value="data.mobilePhone"
          ></v-text-field>
        </v-flex>
        <v-flex xs6 class="pa-2">
         <v-text-field
            label="Delivery Date"
            readonly
            :value="data.deliveryDate"
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