<template>
  <div class="title-distance lock-title-distance">
    <div class="header-di">
      <div class="title-di">Nhân viên</div>
      <div class="header-button flex">
        <div>
          <button
            class="add-button ms-button ms-button-primary"
            title="Thêm nhân viên"
            data-toggle="modal"
            data-target="#employee-dialog"
          >
            <div class="ms-button-text flex align-center">Thêm</div>
          </button>

          
        </div>
      </div>
    </div>
    <div class="back flex justify back-all-di">
      <div class="mi mi-16 mi-chevron-left--primary"></div>
      <a>Tất cả danh mục</a>
    </div>
  </div>
</template>

<style>
.title-distance {
  position: sticky !important;
  left: 0;
  margin: 0;
  padding-top: 22px;
  padding-bottom: 16px;
}

.lock-title-distance {
  position: sticky;
  background: #f4f5f6;
  z-index: 10;
  top: 0;
}

/**Header cho mục Title */
.header-di {
  position: relative;
  display: flex;
  justify-content: space-between;
}

.header-di .title-di {
  font-size: 24px;
  font-weight: 700;
  color: #111;
}

/**button thêm nhân viên */
.add-button {
  padding: 8px 14px 8px 16px;
  height: 36px;
  border-radius: 30px;
}

.add-button .ms-button-text {
  font-weight: 500;
  letter-spacing: 0.5px;
}

.ms-button-primary {
  border: 1px solid transparent;
  color: #fff;
  background-color: #2ca01c;
}

.ms-button-primary:hover {
  background-color: #35bf22;
  color: #fff;
}

/**Nút back về tất cả danh mục */
.back-all-di {
  cursor: pointer;
  width: -webkit-max-content;
  width: -moz-max-content;
  width: max-content;
}

.back {
  color: #0075c0;
  cursor: pointer;
}

.back a {
  font-size: 14px;
  font-weight: 300;
}

.mi-chevron-left--primary {
  background-position: -224px -360px;
}
</style>