<template>
  <div id="app" class="flex">
    <Loading />
    <!-- <div class="tooltip">
      Hãy di chuột qua tôi nào!
      <span class="tooltiptext">Tiền gửi</span>
    </div> -->
    <Menu />
    <div id="main-content">
      <HeaderEmployee />
      <div class="router-content">
        <div class="content-area">
        <TitleEmployee />
        <FilterEmployee />
        <TableEmployee />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Loading from "./components/Loading.vue";
import Menu from "./components/Menu.vue";
import HeaderEmployee from "./components/HeaderEmployee.vue";
import TitleEmployee from "./components/TitleEmployee.vue";
import FilterEmployee from "./components/FilterEmployee.vue";
import TableEmployee from "./components/TableEmployee.vue";

export default {
  name: "App",
  components: {
    Loading,
    Menu,
    HeaderEmployee,
    TitleEmployee,
    FilterEmployee,
    TableEmployee,
  },
};
</script>

<style>
@import "./styles/style.css";
@import "./assets/bootstrap/bootstrap.min.css";

::-webkit-scrollbar {
  width: 10px;
  height: 10px;
}

::-webkit-scrollbar-thumb {
  background: #b8bcc3;
}

::-webkit-scrollbar-track {
  background: #f1f1f1;
}

* {
  font-family: inherit;
  font-size: inherit;
}
* {
  margin: 0;
  padding: 0;
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
  outline: none;
  text-transform: none;
  text-decoration: none;
}
user agent stylesheet body,
html {
  font-family: noto_sans, Open Sans local;
  line-height: 1.5;
}

Style Attribute {
  overflow: hidden;
  --vs-primary: 53, 191, 34;
  --vs-success: 40, 199, 111;
  --vs-danger: 234, 84, 85;
  --vs-warning: 255, 159, 67;
  --vs-dark: 30, 30, 30;
}
:root {
  --vs-primary: 31, 116, 255;
  --vs-danger: 255, 71, 87;
  --vs-success: 70, 201, 58;
  --vs-dark: 30, 30, 30;
  --vs-warning: 255, 186, 0;
  --vs-light: 245, 245, 245;
}
.vuesax-app-is-ltr {
  direction: ltr;
}

#main-content {
  flex: 1;
  min-height: 0;
  min-width: 0;
  width: 100%;
  height: 100%;
  min-height: calc(100vh - 48px);
  position: relative;
}

.router-content{
      padding-top: 48px;
    padding-left: 20px;
    background: #f4f5f6;
}

.content-area{
  padding-right: 30px;
    overflow: scroll;
    height: calc(100vh - 48px);
}
</style>
