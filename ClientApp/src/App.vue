<template>
  <div id="app">
    <camera-angle />
  </div>
</template>

<script>
import CameraAngle from './components/CameraAngle.vue'
export default {
  name: 'App',
  components: {
    CameraAngle
  },
  data() {
    return {
      weather: {}
    }
  }
}
</script>

<style lang="scss">
body {
  margin: 0;
  background: #f8f8f8;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin: 30px auto;
  max-width: 630px;
}
input {
  background: #FFFFFF;
  border: 1px solid #d8d8d8;
  height: 40px;
  border-radius: 8px;
  padding: 0 16px;
  outline: none;
  font-size: 16px;

  &::-webkit-outer-spin-button,
  &::-webkit-inner-spin-button {
    -webkit-appearance: none;
    margin: 0;
  }
  &[type=number] {
    -moz-appearance: textfield;
  }

  &::placeholder {
    color: #79818c;
  }
  &:hover {
    border-color: #79818c;
  }
  &:not(:placeholder-shown) {
    border-color: #818181;
  }
  &:focus, &:active {
    border-color: #367ee7;
    &::placeholder {
      color: #d1d1d1;
    }
  }
}

label {
  color: #79818c;
  font-size: 16px;
  margin-bottom: 8px;
}

button {
  color: #1f1f25;
  font-size: 16px;
  font-weight: 700;
  padding: 11px 60px;
  height: 40px;
  border: none;
  border-radius: 8px;
  cursor: pointer;

  &.primary {
    background-color: #ffd400;
    &:hover {
      background-color: #fdca21;
    }
    &:active {
      background-color: #ffd138;
    }
    &:disabled {
      background-color: #ffd400;
      cursor: default;
      opacity: 0.5;
    }
  }
  &.secondary {
    background-color: #f1f5f9;
    &:hover {
      background-color: #e5eff9;
    }
    &:active {
      background-color: #eaf1f9;
    }
  }
}
</style>
