<template>
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
      <li class="list-group-item">Start Time: {{ groom.startTime }} AM</li>
      <li class="list-group-item">
        Service: Hair Cut <i class="mdi mdi-content-cut"></i>
      </li>
      <li class="list-group-item">Quoted Price: ${{ groom.price }}</li>
      <li class="list-group-item">
        Location:
        <a
          v-bind:href="'https://google.com/maps/place/' + groom.groomLocation"
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
</template>

<script>
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

<style lang="scss" scoped></style>
