<template>
  <div class="flex bg-white">
    <div class="grid-model-control">
      <div class="ms-grid-viewer table-scroll table-area" outsize="30px">
        <table v-show="!loading" class="ms-table-viewer">
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
            <tr
              class="ms-tr-viewer"
              v-for="employee in employees"
              :key="employee.employeeId"
              :employeeId="employee.employeeId"
            >
              <td class="ms-out-left-white-16"></td>
              <td class="ms-td-viewer text-left">
                {{ employee.employeeCode }}
              </td>
              <td class="ms-td-viewer text-left">
                {{ employee.employeeName }}
              </td>
              <td class="ms-td-viewer text-left">
                {{ employee.employeePosition }}
              </td>
              <td class="ms-td-viewer text-left">
                {{ employee.departmentName }}
              </td>
              <td class="ms-td-viewer text-left">
                {{ employee.bankAccountNumber }}
              </td>
              <td class="ms-td-viewer text-left">
                {{ employee.bankName }}
              </td>
              <td class="ms-td-viewer text-left">
                {{ employee.bankBranchName }}
              </td>
              <td class="ms-td-viewer text-left">Đang sử dụng</td>
              <td class="ms-td-viewer ms-td-wiget text-right">
                <div class="flex justify-end">
                  <div class="ms-dropdown">
                    <button
                      class="ms-button edit-btn"
                      data-toggle="modal"
                      data-target="#add-employee-dialog"
                    >
                      <div
                        class="ms-button-text flex align-center"
                        @click="getEmployeeById(employee.employeeId), setIsEditTrue()"
                      >
                        Sửa
                      </div>
                    </button>

                    <button
                      class="ms-button function-btn"
                      @click="showMenuForEmployee()"
                    >
                      <div class="ms-button-text flex align-center">
                        <div class="mi mi-16 mi-arrow-up--blue">&nbsp;</div>
                      </div>
                    </button>
                  </div>
                </div>
              </td>
              <td class="ms-out-right-white-30"></td>
              <td class="ms-out-right-grey-30"></td>
            </tr>
            <!-- <tr class="ms-tr-viewer">
              <td class="ms-out-left-white-16"></td>
              <td class="ms-td-viewer text-left">NV0001</td>
              <td class="ms-td-viewer text-left">Nguyễn Kiên Trung</td>
              <td class="ms-td-viewer text-left">Giám đốc</td>
              <td class="ms-td-viewer text-left">Ban giám đốc</td>
              <td class="ms-td-viewer text-left">10847232699636</td>
              <td class="ms-td-viewer text-left">
                Ngân hàng Nông nghiệp và Phát triển nông thôn Việt Nam
              </td>
              <td class="ms-td-viewer text-left">Chi nhánh Hai Bà Trưng</td>
              <td class="ms-td-viewer text-left">Đang sử dụng</td>
              <td class="ms-td-viewer ms-td-wiget text-right">
                <div class="flex justify-end">
                  <div class="ms-dropdown">
                    <button
                      class="ms-button edit-btn"
                      data-toggle="modal"
                      data-target="#employee-dialog"
                    >
                      <div class="ms-button-text flex align-center">Sửa</div>
                    </button>

                    <button class="ms-button function-btn">
                      <div class="ms-button-text flex align-center">
                        <div class="mi mi-16 mi-arrow-up--blue">&nbsp;</div>
                      </div>
                    </button>
                  </div>
                </div>
              </td>
              <td class="ms-out-right-white-30"></td>
              <td class="ms-out-right-grey-30"></td>
            </tr> -->
          </tbody>
        </table>
        <div
          v-show="loading"
          class="m-3"
          id="spinner-load-data"
          style="display: none !important"
        >
          <div class="d-flex justify-content-center">
            <div
              class="spinner-border"
              role="status"
              style="color: #019160 !important"
            >
              <span class="sr-only">Loading...</span>
            </div>
          </div>
        </div>
        <div class="ms-panigation">
          <div class="flex items-center justify-between w-full pagination-bar">
            <div class="left-pagination">
              <div class="total-record">Tổng số: <b>{{employees.length}}</b> bản ghi</div>
            </div>

            <div class="flex postion-pagination align-center">
              <div class="record-in-page">
                <div class="ms-combo ms-combo-box">
                  <div class="combo-main-content">
                    <div class="selected-options">
                      <input
                        type="text"
                        size="1"
                        placeholder=""
                        readonly="true"
                        autofocus="autofocus"
                        error="Error"
                        class="combo-input"
                        style="text-align: left"
                        value="10 bản ghi trên 1 trang"
                        id="number-record-in-page"
                      />
                    </div>
                    <div class="combo-actions">
                      <label
                        class="btn-dropdown m-0"
                        id="show-option-record-in-page"
                        for="number-record-in-page"
                      >
                        <div
                          class="mi mi-16 mi-arrow-dropdown arrow-dropdown--close"
                        ></div>
                      </label>
                    </div>
                  </div>
                </div>
              </div>

              <div class="flex items-center">
                <div class="mr-3 pointer unselect disableText">Trước</div>
                <div class="page-index">
                  <div class="pl-2 pr-2 pointer pageSelected">1</div>
                  <div class="pl-2 pr-2 pointer">2</div>
                  <div class="pl-2 pr-2 pointer">3</div>
                  <div class="pl-2 pr-2"></div>
                  <div class="pl-2 pr-2 pointer">...</div>
                  <div class="pl-2 pr-2 pointer">12</div>
                </div>
                <div class="ml-3 pointer unselect">Sau</div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div
      id="menu-for-employee"
      class="con-ms-dropdown--menu ms-dropdown-menu pt-0"
      style="display: none"
    >
      <ul class="ms-dropdown--menu">
        <li class="ms-dropdown--item">
          <a class="ms-dropdown--item-link">Nhân bản</a>
        </li>
        <li
          class="ms-dropdown--item"
          data-toggle="modal"
          data-target="#delete-employee-dialog"
          @click="getEmployee(), hideMenu()"
        >
          <a class="ms-dropdown--item-link">Xóa</a>
        </li>
        <li class="ms-dropdown--item">
          <a class="ms-dropdown--item-link">Ngừng sử dụng</a>
        </li>
      </ul>
    </div>
    <!-- <EditEmployeeDialog /> -->
    <AddEmployeeDialog @loadData="loadData" :employee="employee"/>
    <DeleteEmployeeDialog @loadData="loadData" :employee="employee" />
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
  border-collapse: separate;
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
  border-right: 1.5px solid #c7c7c7;
  border-bottom: 1.6px solid #c7c7c7;
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

.mi-arrow-up--blue {
  background-position: -896px -359px;
}

.mi-dropdown-grey-triangle {
  background-position: -1752px -312px;
}

.mi-arrow-dropdown {
  background-position: -560px -359px;
}

.reverse {
  transform: rotate(180deg);
}

/**Cột chức năng */
.ms-grid-viewer .ms-table-viewer .ms-thead-viewer .ms-tr-viewer .ms-th-wiget {
  border-right: none;
  position: sticky;
  right: 0;
  z-index: 4;
  border-left: 1.5px solid #c7c7c7;
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
  padding: 5px 10px;
  border-bottom: 1.5px solid #c7c7c7;
  border-right: 1.5px dotted #c7c7c7;
  font-size: 13px;
}

.ms-tr-viewer:hover .ms-td-viewer {
  background: #f3f8f8 !important;
}

.ms-dropdown {
  display: flex;
}

/**nút sửa */
.ms-tr-viewer .ms-td-wiget {
  border-right: none;
  position: sticky;
  right: 30px;
  z-index: 2;
  background-color: #fff;
  border-left: 1px dotted #c7c7c7;
}

.edit-btn {
  padding: 6px 0 6px 16px !important;
  color: #0075c0;
  height: 36px;
}

.function-btn {
  width: 46px;
  color: #0075c0;
  height: 36px;
  padding: 8px 10px 8px 10px;
  position: relative;
}

/**phân trang */
.ms-panigation {
  bottom: 0px;
  width: calc(100vw - 246px);
  position: sticky;
  bottom: 0;
  z-index: 2;
  background-color: #fff;
  display: flex;
}

.ms-panigation .pagination-bar {
  min-height: 46px;
}

.left-pagination {
  position: sticky;
  left: 20px;
  white-space: nowrap;
  min-width: 10px;
  display: flex;
}

.postion-pagination {
  position: sticky;
  right: 60px;
}

.record-in-page {
  margin: 0 16px;
  width: 200px;
  min-width: 200px;
}

/**combobox số bản ghi trên 1 trang */
.ms-combo {
  position: relative;
  width: 100%;
}

.ms-combo .combo-main-content {
  display: flex;
  min-height: 32px;
  border: 1px solid #babec5;
  border-radius: 2px;
  background-color: #fff;
  overflow: hidden;
}

.ms-combo .combo-main-content .selected-options {
  display: flex;
  flex-basis: 100%;
  flex-grow: 1;
  flex-wrap: wrap;
  width: calc(100% - 32px);
  align-items: center;
  padding: 6px 0 6px 12px;
}

.ms-combo .combo-main-content .selected-options .combo-input {
  border: none;
  font-size: 13px;
  padding-right: unset;
  text-overflow: ellipsis;
  background-color: transparent;
  display: flex;
  flex-grow: 1;
}

.ms-combo .combo-main-content .combo-actions {
  display: flex;
}

.ms-combo .combo-main-content .combo-actions .btn-dropdown {
  width: 32px;
  background-color: transparent;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
}

.ms-combo .combo-main-content .combo-actions .arrow-dropdown--close {
  transform: rotate(0deg);
  transition: transform 0.15s linear;
}

.ms-combo .combo-main-content .combo-actions .arrow-dropdown--open {
  transform: rotate(180deg);
  transition: transform 0.15s linear;
}

.ms-combo .combo-main-content .combo-actions .btn-dropdown:hover {
  background-color: #e0e0e0;
  border-color: #e0e0e0;
}

/**Số trang */
.disableText {
  cursor: default !important;
  color: #9e9e9e;
}
.unselect {
  -webkit-touch-callout: none;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}

.page-index {
  display: flex;
}

.pageSelected {
  border: 1px solid #e0e0e0;
  font-weight: 700;
}

/* input:focus{
  border: 1px solid #2ca01c !important;
} */

/**CSS menu hiện lên trên từng dòng */
.con-ms-dropdown--menu {
  padding-top: 10px;
  position: absolute;
  height: auto;
  width: auto;
  z-index: 1001;
  transform: translate(-100%);
  transition: opacity 0.25s, transform 0.25s, width 0.3s ease;
}

.ms-dropdown--menu {
  background: #fff;
  padding: 2px 1px;
  border-radius: 2px;
  border: 1px solid #babec5;
  position: relative;
}

.ms-dropdown--item {
  white-space: nowrap;
  transition: all 0.2s ease;
  position: relative;
  z-index: 1000;
  text-align: left;
  width: 100%;
  list-style: none;
  min-width: 100px;
  font-weight: 400 !important;
  font-size: 13px;
}

.ms-dropdown--item:hover {
  background: #e8e9ec;
  color: #08bf1e;
}

.ms-dropdown--item .ms-dropdown--item-link {
  background: inherit !important;
  color: inherit !important;
  cursor: pointer;
  transition: all 0.2s ease;
  padding: 5px;
  padding-left: 10px;
  padding-right: 10px;
  width: 100%;
  position: relative;
  display: block;
  color: rgba(0, 0, 0, 0.7);
}
</style>

<script>
import * as axios from "axios";
import JQuery from "jquery";
let $ = JQuery;

// import EditEmployeeDialog from './dialog/EditEmployeeDialog.vue';
import AddEmployeeDialog from './dialog/AddEmployeeDialog.vue';
import DeleteEmployeeDialog from "./dialog/DeleteEmployeeDialog.vue";
import EventBus from "../main.js";

var idEmployee = "";
var localhost = "https://localhost:44397/api/v1/Employees/";

export default {
  name: "TableEmployees",
  components: {
    // EditEmployeeDialog,
    AddEmployeeDialog,
    DeleteEmployeeDialog,
  },
  data() {
    return {
      loading: true,
      isEdit: true,
      employeeId: "",
      employee: {},
      employees: [],
    };
  },
  mounted() {
    //đảo button chọn số bản ghi trên 1 trang
    var btnShowDropdownRecordInPage = document.getElementById(
      "show-option-record-in-page"
    );
    btnShowDropdownRecordInPage.onclick = function () {
      for (var i = 0; i < btnShowDropdownRecordInPage.childNodes.length; i++) {
        if (
          btnShowDropdownRecordInPage.childNodes[i].classList.contains(
            "arrow-dropdown--close"
          )
        ) {
          btnShowDropdownRecordInPage.childNodes[i].classList.remove(
            "arrow-dropdown--close"
          );
          btnShowDropdownRecordInPage.childNodes[i].classList.add(
            "arrow-dropdown--open"
          );
        } else if (
          btnShowDropdownRecordInPage.childNodes[i].classList.contains(
            "arrow-dropdown--open"
          )
        ) {
          btnShowDropdownRecordInPage.childNodes[i].classList.remove(
            "arrow-dropdown--open"
          );
          btnShowDropdownRecordInPage.childNodes[i].classList.add(
            "arrow-dropdown--close"
          );
        }
      }
    };

    var numberRecordInPage = document.getElementById("number-record-in-page");
    numberRecordInPage.onfocus = function () {
      numberRecordInPage
        .closest(".combo-main-content")
        .classList.add("input-focus");
    };

    numberRecordInPage.onblur = function () {
      numberRecordInPage
        .closest(".combo-main-content")
        .classList.remove("input-focus");
    };
  },
  methods: {
    // setEventClickToShowMenuForEmployee() {
    //   console.log("run");
    //   var menuOption = document.getElementById("menu-for-employee");
    //   var functionBtns = document.getElementsByClassName("function-btn");
    //   Array.from(functionBtns).forEach(function (element) {
    //     element.addEventListener("click", function (event) {
    //       if (menuOption.style.display == "none") {
    //         var parent = $(event.target).parents(".ms-dropdown");
    //         var top = parent.offset().top + 35 + "px";
    //         var left = parent.offset().left - 120 + "px";
    //         menuOption.style.top = top;
    //         menuOption.style.left = left;
    //         menuOption.style.display = "block";
    //         console.log(parent);
    //       } else {
    //         menuOption.style.display = "none";
    //       }
    //       // console.log(event.target.parentElement.pageY + " " + event.pageX);
    //       // contextElement.classList.add("active");
    //     });
    //   });
    // },

    setIsEditTrue() {
      EventBus.$emit("setIsEdit", true);
    },

    showMenuForEmployee() {
      var menuOption = document.getElementById("menu-for-employee");
      var parent = $(event.target).parents(".ms-dropdown");
      var parentContainId = parent.parents("tr");
      // idEmployee = parentContainId.attr("employeeid");
      if (idEmployee != parentContainId.attr("employeeid") || menuOption.style.display == "none") {
        idEmployee = parentContainId.attr("employeeid");
        var top = parent.offset().top + 35 + "px";
        var left = parent.offset().left - 120 + "px";
        menuOption.style.top = top;
        menuOption.style.left = left;
        menuOption.style.display = "block";
        console.log(parent);
      } else {
        menuOption.style.display = "none";
      }
    },

     hideMenu(){
       document.getElementById("menu-for-employee").style.display = "none";
     },

    async getEmployee() {
      const response = await axios.get(localhost + idEmployee);
      this.employee = response.data;
      console.log(this.employee);
    },

    async getEmployeeById(id) {
      const response = await axios.get(localhost + id);
      this.employee = response.data;
      // console.log(this.employee);
    },

    async loadData() {
      this.loading = true;
      const response = await axios.get(localhost);

      // console.log(response.data[0]);
      this.loading = false;
      this.employees = response.data;
    },

    async searchEmployees(data){
      this.loading = true;
      const response = await axios.get(localhost+"Search?keyword="+data);

      // console.log(response.data[0]);
      this.loading = false;
      this.employees = response.data;
    }
  },
  async created() {
    this.loadData();
    EventBus.$on("searchEmployees", this.searchEmployees);
  },
};
</script>
