<template>
  <form>
    <div class="mb-3">
      <label for="startTime" class="form-label">Book a Groom</label>
      <input
        type="startTime"
        class="form-control"
        id="startTime"
        aria-describedby="startTime"
      />
      <div id="startTime" class="form-text">Start Time</div>
    </div>
    <div class="mb-3">
      <label for="exampleInputPassword1" class="form-label"></label>
      <input type="password" class="form-control" id="exampleInputPassword1" />
      <div id="startTime" class="form-text">End Time</div>
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
  </form>
</template>

<script>
export default {
  setup() {
    return {};
  },
};
</script>

<style lang="scss" scoped></style>
