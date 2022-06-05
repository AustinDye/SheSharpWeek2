<template>
  <div class="home flex-grow-1 d-flex flex-column justify-content-center">
    <h1 class="text-center">GROOMS</h1>
    <div class="row">
      <div class="col-12">
        <div class="row d-flex justify-content-center head">
          <div class="col-4 bg-grey">
            <div class="btn text-info">Appointments</div>
          </div>
          <div class="col-4">
            <div class="btn">Canceled</div>
          </div>
          <div class="col-4">
            <div class="btn">History</div>
          </div>
        </div>
        <DailyCard v-for="g in grooms" :key="g.id" :groom="g" />
      </div>
    </div>
    <!--<div class="btn btn-info" @click="create()">Make a new One</div>-->
  </div>
</template>

<script>
import { computed, onMounted } from "@vue/runtime-core";
import { groomsService } from "../services/GroomsService";
import { AppState } from "../AppState";
import Pop from "../utils/Pop";
export default {
  name: "Home",
  setup() {
    onMounted(async () => {
      try {
        await groomsService.getAll();
      } catch (error) {
        Pop.toast("Something went wrong", error);
      }
    });
    return {
      grooms: computed(() => AppState.grooms),
      async create() {
        try {
          await groomsService.create();
        } catch (error) {
          Pop.toast("Something went wrong", error);
        }
      },
    };
  },
};
</script>

<style scoped lang="scss">
.head {
  border-top: 1px black solid;
  border-bottom: 1px black solid;
}
</style>
