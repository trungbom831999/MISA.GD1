<template>
  <div class="flex bg-white">
    <div class="grid-model-control">
      <div class="ms-grid-viewer table-scroll table-area" outsize="30px">
        <table class="ms-table-viewer">
          <thead class="ms-thead-viewer">
            <tr class="ms-tr-viewer">
              <th class="ms-out-left-white-16"></th>
              <div class="dis-contents ms-tbody-viewer">
                <th class="ms-th-viewer dymamic-col header w-150">
                  <span class="ms-head-title flex justify-left"
                    >Mã nhân viên
                    <div class="mi mi-16" style="display: none"></div>
                  </span>
                  <div
                    data-v-6ca5f582=""
                    class="mi mi-16 icon-head mi-header-option"
                    style="display: none"
                  ></div>
                </th>

                <th class="ms-th-viewer dymamic-col header w-250">
                  <span class="ms-head-title flex justify-left"
                    >Tên nhân viên
                    <!-- <div class="mi mi-16" style="display: none"></div> -->
                  </span>
                  <div
                    data-v-6ca5f582=""
                    class="mi mi-16 icon-head mi-header-option"
                    style="display: none"
                  ></div>
                </th>

                <th class="ms-th-viewer dymamic-col header w-250">
                  <span class="ms-head-title flex justify-left"
                    >Chức danh
                    <div class="mi mi-16" style="display: none"></div>
                  </span>
                  <div
                    data-v-6ca5f582=""
                    class="mi mi-16 icon-head mi-header-option"
                    style="display: none"
                  ></div>
                </th>

                <th class="ms-th-viewer dymamic-col header w-250">
                  <span class="ms-head-title flex justify-left"
                    >Tên đơn vị
                    <div class="mi mi-16" style="display: none"></div>
                  </span>
                  <div
                    data-v-6ca5f582=""
                    class="mi mi-16 icon-head mi-header-option"
                    style="display: none"
                  ></div>
                </th>

                <th class="ms-th-viewer dymamic-col header w-150">
                  <span class="ms-head-title flex justify-left"
                    >Số tài khoản
                    <div class="mi mi-16" style="display: none"></div>
                  </span>
                  <div
                    data-v-6ca5f582=""
                    class="mi mi-16 icon-head mi-header-option"
                    style="display: none"
                  ></div>
                </th>

                <th class="ms-th-viewer dymamic-col header w-250">
                  <span class="ms-head-title flex justify-left"
                    >Tên ngân hàng
                    <div class="mi mi-16" style="display: none"></div>
                  </span>
                  <div
                    data-v-6ca5f582=""
                    class="mi mi-16 icon-head mi-header-option"
                    style="display: none"
                  ></div>
                </th>

                <th class="ms-th-viewer dymamic-col header w-250">
                  <span class="ms-head-title flex justify-left"
                    >Chi nhánh
                    <div class="mi mi-16" style="display: none"></div>
                  </span>
                  <div
                    data-v-6ca5f582=""
                    class="mi mi-16 icon-head mi-header-option"
                    style="display: none"
                  ></div>
                </th>

                <th class="ms-th-viewer dymamic-col header w-180">
                  <span class="ms-head-title flex justify-left"
                    >Trạng thái
                    <div class="mi mi-16" style="display: none"></div>
                  </span>
                  <div
                    data-v-6ca5f582=""
                    class="mi mi-16 icon-head mi-header-option"
                    style="display: none"
                  ></div>
                </th>
              </div>
              <th
                class="ms-th-viewer ms-th-wiget"
                style="right: 30px; width: 100px; min-width: 100px"
              >
                <span class="ms-head-title float-right">Chức năng</span>
              </th>
              <th class="ms-out-right-white-30"></th>
              <th class="ms-out-right-grey-30"></th>
            </tr>
          </thead>

          <tbody class="dis-contents ms-tbody-viewer">
            <tr class="ms-tr-viewer">
              <td class="ms-out-left-white-16"></td>
              <td class="ms-td-viewer text-left">NV0001</td>
              <td class="ms-td-viewer text-left">Nguyễn Kiên Trung</td>
              <td class="ms-td-viewer text-left">Giám đốc</td>
              <td class="ms-td-viewer text-left">Ban giám đốc</td>
              <td class="ms-td-viewer text-left">10847232699636</td>
              <td class="ms-td-viewer text-left">Ngân hàng Nông nghiệp và Phát triển nông thôn Việt Nam</td>
              <td class="ms-td-viewer text-left">Chi nhánh Hai Bà Trưng</td>
              <td class="ms-td-viewer text-left">Đang sử dụng</td>
              <td class="ms-out-right-white-30"></td>
              <td class="ms-out-right-grey-30"></td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<style>
.grid-model-control {
  min-width: 100%;
}

.table-area {
  overflow: unset;
  max-height: none;
  min-width: calc(100% + 30px);
}

.ms-grid-viewer .ms-table-viewer {
  border-spacing: 0;
  min-width: 100%;
}

.ms-out-left-white-16 {
  min-width: 16px;
  max-width: 16px;
  width: 16px;
  background: #fff;
  position: sticky;
  left: 0;
  border: 0;
  z-index: 3;
  padding: 0;
}

.ms-out-right-grey-30,
.ms-out-right-white-30 {
  min-width: 30px;
  position: sticky;
  border: none;
  width: 30px;
  max-width: 30px;
  z-index: 3;
  padding: 0;
}

.ms-out-right-white-30 {
  background: #fff;
  right: 0;
}

.ms-out-right-grey-30 {
  background: #f4f5f6;
  right: -30px;
}

.ms-grid-viewer .ms-table-viewer .ms-tbody-viewer {
  background-color: #fff;
}

.dis-contents {
  display: contents;
}

/**TH */
.ms-grid-viewer .ms-table-viewer .ms-thead-viewer .ms-tr-viewer .dymamic-col {
  left: unset !important;
}

.ms-grid-viewer .ms-table-viewer .ms-thead-viewer .ms-tr-viewer .ms-th-viewer {
  border-right: 1px solid #c7c7c7;
  border-bottom: 1px solid #c7c7c7;
  min-height: 34px;
  height: 34px;
  position: sticky;
  z-index: 2;
  top: 0;
  background-color: #eceef1;
  vertical-align: middle;
}

.ms-th-viewer {
  top: 93px !important;
}

.ms-grid-viewer
  .ms-table-viewer
  .ms-thead-viewer
  .ms-tr-viewer
  .ms-th-viewer
  .ms-head-title {
  font-size: 12px;
  text-transform: uppercase !important;
  align-items: center;
  cursor: pointer;
  padding-right: 12px;
}

.icon-head {
  height: -webkit-fit-content;
  height: -moz-fit-content;
  height: fit-content;
  position: absolute;
  right: 3px;
  top: calc(50% - 8px);
}

.mi-header-option {
  background-position: -1687px -564px;
}

/**Cột chức năng */
.ms-grid-viewer .ms-table-viewer .ms-thead-viewer .ms-tr-viewer .ms-th-wiget {
  border-right: none;
  position: sticky;
  right: 0;
  z-index: 4;
  border-left: 1px solid #c7c7c7;
}

.ms-grid-viewer
  .ms-table-viewer
  .ms-thead-viewer
  .ms-tr-viewer
  .ms-th-viewer
  .ms-head-title.float-right {
  display: block;
  text-align: right;
}

.ms-grid-viewer
  .ms-table-viewer
  .ms-thead-viewer
  .ms-tr-viewer
  .ms-th-viewer
  .ms-head-title {
  text-transform: uppercase !important;
  align-items: center;
  cursor: pointer;
  padding-right: 12px;
}

/**TBODY */
.ms-grid-viewer .ms-table-viewer .ms-tbody-viewer .ms-tr-viewer,
.ms-grid-viewer .ms-table-viewer .ms-tbody-viewer {
  background-color: #fff;
}

.ms-tr-viewer .ms-td-viewer {
  height: 40px;
  padding: 0 5px;
  border-bottom: 1px solid #c7c7c7;
  border-right: 1px dotted #c7c7c7;
  font-size: 13px;
}
</style>