<template>
  <div class="navbar-sticky">
    <header class="flex">
      <div class="flex header-branch">
        <div class="header-branch-name">
          CÔNG TY TNHH NƯỚC UỐNG TINH KHIẾT SÀI GÒN
        </div>
        <a class="flex items-center"
          ><div
            class="header-icon mi mi-14 mi-chevron-right header-branch-icon pointer"
          ></div
        ></a>
      </div>
      <div class="header-current-db">
        <div class="icon-header-current-db"></div>
        <div class="header-current-db-name">NỘI BỘ</div>
      </div>
      <div class="spacer"></div>
      <div class="flex header-quick-search">
        <div class="ms-input">
          <input
            id="navbar-search"
            class="input-search hasIcon"
            type="text"
            placeholder="Nhập từ khóa tìm kiếm"
          />
          <label
            class="icon-inputx notranslate ms-input--icon icon-after mi-search mi mi-16"
            for="navbar-search"
          ></label>
        </div>
      </div>
    </header>
  </div>
</template>

<style>
header {
  background-color: #fff;
  padding: 0;
  height: 48px;
  clear: both;
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-align: center;
  -ms-flex-align: center;
  align-items: center;
  -webkit-box-pack: justify;
  -ms-flex-pack: justify;
  justify-content: space-between;
  -webkit-box-shadow: 0 4px 20px 0 rgb(0 0 0 / 5%);
  box-shadow: 0 4px 20px 0 rgb(0 0 0 / 5%);
  width: 100%;
  z-index: 10000;
  position: relative;
}

.navbar-sticky {
  padding: 0;
  background: none;
  z-index: 1000;
  top: 0;
  position: absolute;
  width: 100%;
}

/*Tên công ty */
.header-branch {
  cursor: pointer;
}

@media (max-width: 1680px) {
  .header-branch-name {
    max-width: 450px;
  }
}

@media (max-width: 1440px) {
  .header-branch-name {
    max-width: 300px;
  }
}

@media (max-width: 1300px) {
  .header-branch-name {
    max-width: 200px;
  }
}

@media (max-width: 900px) {
  .header-branch-name {
    max-width: 100px;
  }
}
.header-branch-name {
  padding-left: 10px;
  overflow: hidden;
  white-space: nowrap;
  font-weight: 600;
  max-width: 800px;
  text-overflow: ellipsis;
  transition: all 0.2s ease;
  font-size: 14px;
  color: #111;
}

.header-branch-icon {
  transform: rotate(90deg);
  margin-left: 10px;
}

.header-icon {
  margin: 0 10px;
}

/**Cắt ảnh ra icon */
.mi-14 {
  width: 14px;
  height: 14px;
  min-width: 14px;
  min-height: 14px;
}

.mi-16 {
  width: 16px;
  height: 16px;
  min-width: 16px;
  min-height: 16px;
}

.mi {
  background: url(../assets/img/Sprites.64af8f61.svg) no-repeat;
  cursor: pointer;
}

.mi-chevron-right {
  background-position: -80px -360px;
}

.mi-search {
  background-position: -992px -360px;
}

/**Db hiện tại */
.header-current-db {
  display: flex;
  align-items: center;
  border: 1px solid #ebedf0;
  padding: 0 12px;
  border-radius: 40px;
  margin-left: 15px;
  font-size: 13px;
  cursor: pointer;
  height: 30px;
  margin-right: 10px;
}

.icon-header-current-db {
  width: 8px;
  height: 8px;
  background-color: #4ea344;
  border-radius: 50%;
  border: 1px solid #fff;
}

.header-current-db-name {
  padding-left: 7px;
  max-width: 200px;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
  transition: all 0.2s ease;
  color: #111;
}

/**khoảng trống */
.spacer {
  display: block !important;
  padding: 0;
  margin: 0;
  -webkit-box-flex: 1 !important;
  -ms-flex-positive: 1 !important;
  flex-grow: 1 !important;
  background: transparent;
}

/**thanh tìm kiếm */
.header-quick-search {
  margin-right: 20px;
  width: 200px;
}

.ms-input {
  display: flex;
  align-items: flex-start;
  flex-direction: column;
  position: relative;
  justify-content: center;
  color: #111;
  width: 100%;
}

.ms-input .hasIcon {
  padding-left: 0.85em;
  padding-right: 1.75rem;
}

.input-search {
  background: #fff;
  border-radius: 3px;
  color: #111;
  border: 1px solid #ebedf0;
  font-size: 13px;
  height: 32px;
  box-sizing: border-box;
  width: 100%;
}

.input-search::-webkit-input-placeholder {
  color: #babec5;
  font-style: italic;
  font-weight: 500;
  font-size: 12px;
}

.input-search:hover {
  outline: 1px solid #e2e2e2;
}

.icon-after {
  position: absolute;
  left: auto;
  right: 5px;
  top: 8px;
  border-right: 0;
  padding-left: 3px;
  margin-right: 4px;
  user-select: none;
}
</style>