<template>
  <div class="grid-list-data sticky left-0">
    <div class="grid-button-list flex">
      <div class="w-6/7">
        <div class="content-input-list">
          <div class="ms-input">
            <input
              id="search-employee-input"
              class="input-search hasIcon"
              type="text"
              placeholder="Tìm theo mã, tên nhân viên"
              style="border: 1px solid #babec5"
            />
            <label
              class="icon-inputx notranslate ms-input--icon icon-after mi-search mi mi-16"
              for="navbar-search"
            ></label>
          </div>
        </div>
      </div>
      <div class="w-1/7">
        <div class="ultility-buttons flex">
          <div class="refresh-button list-button" title="Làm mới bộ lọc">
            <div class="mi mi-24 mi-refresh"></div>
          </div>
          <div class="print-button list-button" title="Nhập từ Excel">
            <div class="mi mi-24 mi-excel__nav"></div>
          </div>
          <div class="setting-button list-button" title="Cài đặt">
            <div class="mi mi-24 mi-setting__list"></div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<style>
.grid-list-data {
  background: #fff;
  padding: 16px 16px 10px 16px;
  position: relative;
}

.grid-list-data .grid-button-list {
  margin-bottom: 10px;
}

.content-input-list {
  width: 250px;
  float: left;
  margin-right: 10px;
}

/**các nút trên Filter */
.grid-list-data .grid-button-list .ultility-buttons {
  justify-content: flex-end;
}

.ultility-buttons .list-button {
  padding: 0 6px;
}

.mi-setting__list {
  background-position: -88px -200px;
}

.mi-excel__nav {
  background-position: -704px -200px;
}

.mi-refresh {
  background-position: -423px -201px;
}
</style>

<script>
export default {
  mounted() {
    window.onload = function () {
      document.getElementById("search-employee-input").focus();
    };
  },
};
</script>