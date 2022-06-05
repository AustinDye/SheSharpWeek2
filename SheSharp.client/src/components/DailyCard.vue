<template>
  <div class="container-fluid job-card">
    <div class="row d-flex">
      <div class="col-3">
        <h2>May 30</h2>
        <h6>{{ groom.startTime }} AM</h6>
      </div>
      <div class="col-9 d-flex justify-content-end mt-1">
        <span>
          <h6 class="m-0">{{ groom.breed }}</h6>
          <p class="m-0 fs-6">{{ groom.services }}</p>
          <p>
            <button
              class="btn"
              type="button"
              data-bs-toggle="collapse"
              v-bind:data-bs-target="'#collapseExample' + groom.id"
              aria-expanded="false"
              aria-controls="collapseExample"
            >
              <i class="mdi mdi-chevron-down mdi-36px"></i>
            </button>
          </p>
        </span>
      </div>
    </div>

    <div class="collapse" v-bind:id="'collapseExample' + groom.id">
      <div class="">
        <div class="card m-2">
          <div class="row">
            <div class="col-6 p-4">
              <h5 class="">{{ groom.name }}</h5>
              <img
                class="rounded w-100 p-2"
                src="https://www.platinumgoldendoodles.com/wp-content/uploads/2020/03/img_0540-1024x1024-1-421x300.jpg"
                alt="100x100"
                data-holder-rendered="true"
              />
            </div>
            <div class="col-6">
              <div class="card-body">
                <h5 class="">{{ groom.breed }}</h5>
                <p class="card-text">{{ groom.services }}</p>
              </div>
            </div>
          </div>

          <ul class="list-group list-group-flush">
            <li class="list-group-item">
              Start Time: {{ groom.startTime }} AM
            </li>
            <li class="list-group-item">
              Service: Hair Cut <i class="mdi mdi-content-cut"></i>
            </li>
            <li class="list-group-item">Quoted Price: ${{ groom.price }}</li>
            <li class="list-group-item">
              Location:
              <a
                v-bind:href="
                  'https://google.com/maps/place/' + groom.groomLocation
                "
                >{{ groom.groomLocation }}</a
              >
            </li>
            <li class="list-group-item">Quoted Price: ${{ groom.price }}</li>
          </ul>
          <div class="card-body">
            <a href="#" class="card-link">Card link</a>
            <a href="#" class="card-link">Another link</a>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import Pop from "../utils/Pop";
import { logger } from "../utils/Logger";
import { groomsService } from "../services/GroomsService";
export default {
  props: {
    groom: {
      type: Object,
    },
  },
  setup() {
    return {};
  },
};
</script>

<style lang="scss" scoped>
.job-card {
  box-shadow: 0px 1px rgba(0, 0, 0, 0.402);
  margin-top: 10%;
  width: 100%;
}
</style>
