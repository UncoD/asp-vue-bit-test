<template>
  <div class="calculator">
    <div class="camera-params">
      <h1>Рассчет угла вертикального наклона камеры</h1>
      <img class="info-img" src="@/assets/image.png">
      <div class="params">
        <div class="param">
          <label for="object">Расстояние до объекта (A, см)</label>
          <input
            v-model="distToObject"
            name="object"
            type="number"
            @change="clearAnswer"
          >
        </div>
        <div class="param">
          <label for="camera">Высота установки камеры (D, см)</label>
          <input
            v-model="cameraHeight"
            name="camera"
            type="number"
            @change="clearAnswer"
          >
        </div>
      </div>
      <div class="buttons">
        <button
          class="btn secondary"
          @click="clearData(); clearAnswer()"
        >Сбросить</button>
        <button
          class="btn primary"
          @click="calculateAngle"
        >Рассчет</button>
      </div>
    </div>
    <transition
      name="showanswer"
      v-on:enter="scrollToAnswer"
    >
      <div v-if="answer" class="answer">
        <div><b>Высота над человеком (B):</b> {{ heightAbovePerson }}см</div>
        <div><b>Угол наклона:</b> {{ answer }}°</div>
      </div>
    </transition>
  </div>
</template>

<script>
export default {
  name: 'CameraAngle',
  data() {
    return {
      distToObject: 0,
      cameraHeight: 0,
      answer: null,
      heightAbovePerson: null
    }
  },
  methods: {
    clearData() {
      this.distToObject = 0
      this.cameraHeight = 0
    },
    clearAnswer() {
      this.answer = null
      this.heightAbovePerson = null
    },
    calculateAngle() {
      this.answer = this.distToObject * this.cameraHeight
      this.heightAbovePerson = parseInt(this.distToObject) + parseInt(this.cameraHeight)
    },
    scrollToAnswer() {
      window.scrollTo({
        top: document.body.scrollHeight,
        behavior: "smooth"
      })
    }
  },
}
</script>

<style lang="scss" scoped>
.calculator {
  margin: 0 30px;
}
.camera-params {
  margin: 0 auto;
  border: 1px solid #d8d8d8;
  border-radius: 10px;
  background: #fff;
  padding: 30px;
  z-index: 1;

  h1 {
    margin: 0 0 25px;
  }

  .info-img {
    width: 70%;
  }
}

.params {
  display: flex;
  justify-content: center;
  align-items: flex-end;
  margin: 30px 0;
  
  .param {
    display: flex;
    flex-direction: column;
    max-width: 300px;
    text-align: left;
    &:last-child {
      margin-left: auto;
    }
  }
}

.buttons {
  display: flex;
  justify-content: center;
  .btn:last-child {
    margin-left: auto;
  }
}

.answer {
  margin: 0 auto;
  border: 1px solid #d8d8d8;
  border-top: none;
  border-radius: 0 0 10px 10px;
  background: #fff;
  width: 50%;
  padding: 20px 10px 10px;
  background: #dfffbf;

  div {
    margin: 0 0 10px;
  }
}

.showanswer-enter-active,
.showanswer-leave-active {
  transition: all .8s ease;
  position: relative;
  z-index: -1;
}
.showanswer-enter, .showanswer-leave-to {
  transform: translateY(-100%);
  transform-origin: 50% 0;
}

@media screen and (max-width: 620px) {
  .params {
    flex-direction: column;
    align-items: center;

    .param {
      width: 100%;
      
      &:last-child {
        margin: 15px 0 0;
      }
    }
  }
}

@media screen and (max-width: 530px) {
  .buttons {
    flex-wrap: wrap;
    .btn {
      width: 70%;
      padding: 0 5px;
      &:last-child {
        margin: 15px 0 0;
      }
    }
  }
}
</style>