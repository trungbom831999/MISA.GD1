<template>
  <div class="modal fade" id="add-employee-dialog">
    <div class="modal-dialog modal-xl modal-dialog-centered">
      <div class="modal-content">
        <!-- Dialog Header -->
        <div class="modal-header border-0 p-0">
          <div class="ms-popup--title">
            <div class="header-popup flex">
              <div class="title-popup">Thông tin nhân viên</div>
              <label class="con-ms-checkbox px-3" for="isCustomer">
                <input
                  type="checkbox"
                  class="ms-checkbox--input"
                  id="isCustomer"
                />
                <span
                  class="ms-checkbox-border-disabled-false ms-checkbox-border-checked-false checkbox_x ms-checkbox"
                  ><span
                    class="ms-checkbox-inner ms-checkbox-check-disabled-false ms-checkbox--check"
                  >
                  </span
                ></span>
                <span class="con-slot-label"> Là khách hàng </span>
              </label>

              <label class="con-ms-checkbox px-3" for="isSupplier">
                <input
                  type="checkbox"
                  class="ms-checkbox--input"
                  id="isSupplier"
                />
                <span
                  class="ms-checkbox-border-disabled-false ms-checkbox-border-checked-false checkbox_x ms-checkbox"
                  ><span
                    class="ms-checkbox-inner ms-checkbox-check-disabled-false ms-checkbox--check"
                  >
                  </span
                ></span>
                <span class="con-slot-label"> Là nhà cung cấp </span>
              </label>
            </div>
          </div>

          <div class="ms-popup-close">
            <div
              class="mi mi-24 mi-help mr-6-px help-btn"
              title="Trợ giúp"
            ></div>
            <div
              class="mi mi-24 mi-close"
              data-dismiss="modal"
              title="Đóng (ESC)"
            ></div>
          </div>
        </div>

        <!-- Dialog body -->
        <div class="modal-body p-0">
          <div class="ms-popup--content">
            <div class="row pb-b-12">
              <div class="col-md-6 col-12 p-r-26">
                <div class="row">
                  <div class="col-sm-5 col-12 p-r-6">
                    <div class="form-group">
                      <label class="flex label-input" for="employee-code"
                        >Mã
                        <p class="label-for-input-requied">*</p></label
                      >
                      <input
                        type="text"
                        class="form-control input-is-focus"
                        id="employee-code"
                        v-model="employee.employeeCode"
                      />
                    </div>
                  </div>
                  <div class="col-sm-7 col-12 pl-sm-0">
                    <div class="form-group">
                      <label class="flex label-input" for="employee-name"
                        >Tên
                        <p class="label-for-input-requied">*</p></label
                      >
                      <input
                        type="text"
                        class="form-control input-is-focus"
                        id="employee-name"
                        v-model="employee.employeeName"
                      />
                    </div>
                  </div>
                </div>

                <div class="form-group">
                  <label class="flex label-input" for="employee-department"
                    >Đơn vị
                    <p class="label-for-input-requied">*</p></label
                  >
                  <div class="combo-main-con">
                    <div class="selected-options">
                      <input
                        type="text"
                        size="1"
                        placeholder=""
                        class="combo-input"
                        id="employee-department"
                        v-model="employee.departmentName"
                      />
                    </div>

                    <div
                      class="combo-actions"
                      id="btn-combo-employee-department"
                    >
                      <div class="btn-dropdown">
                        <div class="mi mi-16 mi-arrow-dropdown"></div>
                      </div>
                    </div>
                  </div>

                  <div
                    class="combo-menu"
                    id="combo-employee-department"
                    style="display: none"
                  >
                    <div class="menu-header-container">
                      <table class="menu-table">
                        <thead class="menu-header">
                          <tr>
                            <th
                              title=""
                              class="menu-header__th dropdown-item-th-first-col"
                            >
                              <span>Mã đơn vị</span>
                            </th>
                            <th
                              title=""
                              class="menu-header__th dropdown-item-th-second-col"
                            >
                              <span>Tên đơn vị</span>
                            </th>
                          </tr>
                        </thead>
                      </table>
                    </div>

                    <div class="menu-body-container scroller">
                      <table class="menu-table">
                        <tbody class="menu-items">
                          <tr
                            class="dropdown-item"
                            v-for="department in departments"
                            :key="department.departmentId"
                            @click="
                              setDepartmentIdToEmployee(
                                department.departmentId,
                                department.departmentName
                              ),
                                hideComboEmployeeDepartment()
                            "
                            value="1111"
                          >
                            <td
                              class="dropdown-item-td dropdown-item-td-first-col level-2"
                            >
                              <div class="dropdown-item-td--contents">
                                <div title="002" class="dropdown-item-td--text">
                                  007
                                </div>
                              </div>
                            </td>
                            <td
                              class="dropdown-item-td dropdown-item-td-second-col"
                            >
                              <div class="dropdown-item-td--contents">
                                <div
                                  :title="department.departmentName"
                                  class="dropdown-item-td--text"
                                >
                                  {{ department.departmentName }}
                                </div>
                              </div>
                            </td>
                            <td class="selected-container"></td>
                          </tr>
                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>

                <div class="form-group">
                  <label class="flex label-input" for="employee-position"
                    >Chức danh
                  </label>
                  <input
                    type="text"
                    class="form-control input-is-focus"
                    id="employee-position"
                    v-model="employee.employeePosition"
                  />
                </div>
              </div>
              <div class="col-md-6 col-12 p-r-26 pl-0">
                <div class="row">
                  <div class="col-sm-5 col-12 p-r-6">
                    <div class="form-group">
                      <label class="flex label-input" for="date-of-birth"
                        >Ngày sinh
                      </label>
                      <input
                        type="date"
                        class="form-control input-is-focus"
                        id="date-of-birth"
                        :value="
                          changeDatetimeToDateForInput(employee.dateOfBirth)
                        "
                        @change="setDateOfBirth($event)"
                      />
                    </div>
                  </div>
                  <div class="col-sm-7 col-12 pl-0">
                    <div class="gender items-center">
                      <div class="label-input" style="padding-left: 10px">
                        Giới tính
                      </div>
                      <div class="p-t-5 flex">
                        <p>
                          <input
                            type="radio"
                            id="gender-male"
                            name="radio-group"
                            :checked="employee.gender == 0"
                          />
                          <label for="gender-male" class="mr-4">Nam</label>
                        </p>
                        <p>
                          <input
                            type="radio"
                            id="gender-female"
                            name="radio-group"
                            :checked="employee.gender == 1"
                          />
                          <label for="gender-female">Nữ</label>
                        </p>
                        <p>
                          <input
                            type="radio"
                            id="gender-other"
                            name="radio-group"
                            :checked="employee.gender == 2"
                          />
                          <label for="gender-other">Khác</label>
                        </p>
                      </div>
                    </div>
                  </div>
                </div>

                <div class="row">
                  <div class="col-sm-7 col-12 p-r-6">
                    <div class="form-group">
                      <label class="flex label-input" for="identity-number"
                        >Số CMND
                      </label>
                      <input
                        type="text"
                        class="form-control input-is-focus"
                        id="identity-number"
                        v-model="employee.identityNumber"
                      />
                    </div>
                  </div>
                  <div class="col-sm-5 col-12 pl-sm-0">
                    <div class="form-group">
                      <label class="flex label-input" for="identity-date"
                        >Ngày cấp
                      </label>
                      <input
                        type="date"
                        class="form-control input-is-focus"
                        id="identity-date"
                        :value="
                          changeDatetimeToDateForInput(employee.identityDate)
                        "
                        @change="setIdentityDate($event)"
                      />
                    </div>
                  </div>
                </div>

                <div class="form-group">
                  <label class="flex label-input" for="identity-place"
                    >Nơi cấp
                  </label>
                  <input
                    type="text"
                    class="form-control input-is-focus"
                    id="identity-place"
                    v-model="employee.identityPlace"
                  />
                </div>
              </div>
            </div>

            <!-- nav tabs -->
            <div class="w-full mt-2">
              <div class="navigation-tab">
                <ul class="nav nav-tabs" role="tablist">
                  <li class="nav-item">
                    <a
                      class="nav-link active"
                      data-toggle="tab"
                      href="#contact-tab"
                      >Liên hệ</a
                    >
                  </li>
                  <li class="nav-item">
                    <a
                      class="nav-link"
                      data-toggle="tab"
                      href="#bank-account-tab"
                      >Tài khoản ngân hàng</a
                    >
                  </li>
                </ul>

                <div class="tab-content">
                  <div id="contact-tab" class="container tab-pane active">
                    <br />

                    <div class="form-group p-r-11">
                      <label class="flex label-input" for="employee-adress"
                        >Địa chỉ
                      </label>
                      <input
                        type="text"
                        class="form-control input-is-focus"
                        id="employee-adress"
                        v-model="employee.address"
                      />
                    </div>
                    <div class="row p-r-26">
                      <div class="col-md-3 col-12 p-r-6">
                        <div class="form-group">
                          <label class="flex label-input" for="phone-number"
                            >ĐT di động
                          </label>
                          <input
                            type="tel"
                            class="form-control input-is-focus"
                            id="phone-number"
                            v-model="employee.phoneNumber"
                          />
                        </div>
                      </div>
                      <div class="col-md-3 col-12 pl-0 p-r-6">
                        <div class="form-group">
                          <label class="flex label-input" for="tele-number"
                            >ĐT cố định
                          </label>
                          <input
                            type="tel"
                            class="form-control input-is-focus"
                            id="tele-number"
                            v-model="employee.telephoneNumber"
                          />
                        </div>
                      </div>
                      <div class="col-md-3 col-12 pl-0 p-r-6">
                        <div class="form-group">
                          <label class="flex label-input" for="email"
                            >Email
                          </label>
                          <input
                            type="email"
                            class="form-control input-is-focus"
                            id="email"
                            v-model="employee.email"
                          />
                        </div>
                      </div>
                    </div>

                    <div class="form-group p-r-11">
                      <label
                        class="flex label-input"
                        for="employee-account-number"
                        >Tài khoản ngân hàng
                      </label>
                      <input
                        type="text"
                        class="form-control input-is-focus"
                        id="employee-account-number"
                        v-model="employee.bankAccountNumber"
                      />
                    </div>
                  </div>
                  <div id="bank-account-tab" class="container tab-pane fade">
                    <br />
                    <h2>Tài khoản ngân hàng</h2>
                  </div>
                </div>
              </div>
            </div>

            <div class="ms-popup-footer">
              <div class="divide"></div>
              <div class="flex footer-button-group">
                <div class="w-full flex align-right">
                  <div class="flex align-right">
                    <div class="p-x-3">
                      <button
                        class="ms-button-size-default ms-button-secondary ms-button-radius-false ms-button"
                      >
                        <div
                          class="ms-button-text ms-button--text flex align-center"
                        >
                          Cất
                        </div>
                      </button>
                    </div>
                    <div>
                      <button
                        class="ms-button-size-default ms-button-primary ms-button-radius-false ms-button"
                        @click="saveAndAddNewEmployee()"
                      >
                        <div
                          class="ms-button-text ms-button--text flex align-center"
                        >
                          Cất và Thêm
                        </div>
                      </button>
                    </div>
                  </div>
                </div>

                <div class="w-1/2" style="position: absolute">
                  <button
                    class="ms-button-size-default ms-button-secondary ms-button-radius-false ms-button"
                    data-dismiss="modal"
                  >
                    <div
                      class="ms-button-text ms-button--text flex align-center"
                    >
                      Hủy
                    </div>
                  </button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="modal fade" id="error-dialog">
      <div
        class="modal-dialog modal-dialog-centered"
        style="width: 444px; min-width: 444px"
      >
        <div class="modal-content">
          <div class="padding-32">
            <div class="content">
              <div class="icon-message">
                <div class="mi mi-48 mi-exclamation-error-48-2"></div>
              </div>
              <div class="message-content p-l-16 p-t-12">
                <span id="idMessageError" class="message"
                  >Tên không được để trống.</span
                >
              </div>
            </div>
            <div class="mess-line"></div>
            <div class="mess-footer">
              <div class="Center">
                <button
                  name="button"
                  class="ms-component ms-button ms-button-size-default ms-button-primary ms-button-primary-disabled-false ms-button-radius-false ms-button"
                  @click="hideErrorDialog()"
                >
                  <div class="ms-button-text ms-button--text flex align-center">
                    Đóng
                  </div>
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<style>
/**Dialog */
.modal-lg,
.modal-xl {
  min-width: 900px !important;
  max-width: 900px !important;
  width: 900px !important;
}

@media (max-width: 992px) {
  .modal-lg,
  .modal-xl {
    max-width: 100% !important;
    margin: 0 !important;
  }
}

.input-is-focus:focus {
  border: 1px solid #2ca01c !important;
  box-shadow: none !important;
}

.modal input {
  border: 1px solid #babec5 !important;
}

.ms-popup--title {
  width: 100%;
  padding: 20px 32px 20px 32px;
  padding-right: 12px;
  position: relative;
  overflow: hidden;
  border-radius: 5px 5px 0 0;
}

.header-popup .title-popup {
  font-size: 24px;
  color: #111;
  font-weight: 700;
}

/**checkbox */
.con-ms-checkbox {
  justify-content: flex-start;
  position: relative;
  display: flex;
  align-items: center;
  cursor: pointer;
}

.ms-checkbox--input {
  position: absolute;
  width: 10%;
  height: 100%;
  opacity: 0;
  z-index: 200;
  cursor: pointer;
}

.ms-checkbox--input:checked + .ms-checkbox {
  transform: rotate(0deg);
}

.ms-checkbox {
  top: 0;
  left: 0;
  transition: all 0.2s ease;
  transform: rotate(-90deg);
  cursor: pointer;
  position: relative;
  display: block;
  width: 18px;
  height: 18px;
  border-radius: 2px;
  display: flex;
  align-items: center;
  justify-content: center;
  box-sizing: border-box;
  border: 1px solid #afafaf;
  background: #fff;
}

.ms-checkbox::before {
  outline: 1px solid #2ca01c;
}

.ms-checkbox-border-checked-true {
  border: 1px solid #2ca01c;
  transform: rotate(0deg);
}

.ms-checkbox-inner {
  width: inherit;
  height: inherit;
}

.con-slot-label {
  white-space: nowrap;
  padding-left: 10px;
  font-size: 13px;
}

.mi-checkbox-active {
  background-position: -1224px -360px;
}

.mi-help {
  background-position: -89px -144px;
}

.mi-close {
  background-position: -144px -144px;
}

.mi-arrow-dropdown {
  background-position: -560px -359px;
}

/**nút tắt dialog */
.ms-popup-close {
  display: flex;
  padding: 12px;
}

/**Dialog body */
.ms-popup--content {
  transition: all 0.23s ease 0.1s;
  flex-direction: column;
  display: flex;
  overflow: auto;
  overflow-y: visible;
  padding: 0 32px 20px 32px;
}

.label-for-input-requied {
  color: red;
  margin: 0;
  margin-left: 4px;
}

.combo-main-con {
  display: flex;
  height: calc(1.5em + 0.75rem + 2px);
  border: 1px solid #babec5;
  border-radius: 2px;
  background-color: #fff;
  overflow: hidden;
}

.combo-main-con .selected-options {
  display: flex;
  flex-basis: 100%;
  flex-grow: 1;
  flex-wrap: wrap;
  width: calc(100% - 32px);
}

.combo-main-con .selected-options .combo-input {
  border: none !important;
  font-size: 13px;
  padding: 5px 10px;
  padding-right: unset;
  text-overflow: ellipsis;
  background-color: transparent;
  display: flex;
  flex-grow: 1;
  width: 100%;
}

.combo-main-con .combo-actions {
  display: flex;
}

.combo-main-con .combo-actions .btn-dropdown {
  width: 32px;
  background-color: transparent;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
}

.combo-main-con .combo-actions .btn-dropdown:hover {
  background-color: #e0e0e0;
  border-color: #e0e0e0;
}

/**Combobox Đơn vị */
.combo-menu {
  z-index: 10001;
  position: absolute;
  background-color: #fff;
  border: 1px solid #babec5;
  border-radius: 2px;
  overflow: hidden;
  box-shadow: 0 -8px 34px 0 rgb(0 0 0 / 5%);
}

.combo-menu .menu-header-container {
  background: #f4f5f8;
}

.combo-menu .menu-table {
  width: 100%;
  border-collapse: collapse;
}

.combo-menu .menu-header-container .menu-header {
  color: #111;
  height: 32px;
}

.combo-menu .menu-header-container .menu-header th {
  padding: 0 10px;
  height: 32px;
}

.combo-menu .menu-body-container {
  max-height: 160px;
  overflow-x: hidden;
  overflow-y: auto;
  padding: 2px 1px;
}

.scroller {
  scrollbar-color: #888 #f1f1f1;
  scrollbar-width: thin;
}

.combo-menu .menu-table {
  width: 100%;
  border-collapse: collapse;
}

.dropdown-item {
  display: flex;
  align-items: center;
  cursor: pointer;
  height: 32px;
  line-height: 32px;
  white-space: nowrap;
  padding: 0 !important;
}

.dropdown-item:focus,
.dropdown-item:hover {
  color: #35bf22 !important;
  background-color: #ebedf0 !important;
}

.dropdown-item .dropdown-item-td {
  padding: 0 10px;
}

.dropdown-item-td-first-col,
.dropdown-item-th-first-col {
  width: 100px;
  text-align: left;
}

.dropdown-item-td-second-col,
.dropdown-item-th-second-col {
  width: 250px;
  text-align: left;
}

.dropdown-item .dropdown-item-td .dropdown-item-td--contents {
  display: flex;
  align-items: center;
}

.dropdown-item .dropdown-item-td .dropdown-item-td--text {
  flex: 1;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

.dropdown-item .dropdown-item-td {
  padding: 0 10px;
}

.dropdown-item .dropdown-item-td .dropdown-item-td--contents {
  display: flex;
  align-items: center;
}

.dropdown-item .dropdown-item-td .dropdown-item-td--text {
  flex: 1;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

.selected-container {
  width: 36px;
  height: 20px;
}

.label-input {
  font-size: 12px;
  font-weight: 700;
  padding-bottom: 4px;
  color: #111;
}

.ms-radio-group {
  display: flex;
}

/**Radio button */
[type="radio"]:checked,
[type="radio"]:not(:checked) {
  position: absolute;
  left: -9999px;
}
[type="radio"]:checked + label,
[type="radio"]:not(:checked) + label {
  position: relative;
  padding-left: 28px;
  cursor: pointer;
  line-height: 20px;
  display: inline-block;
  /* color: #666; */
  margin-right: 12px;
}
[type="radio"]:checked + label:before,
[type="radio"]:not(:checked) + label:before {
  content: "";
  position: absolute;
  left: 0;
  top: 0;
  width: 18px;
  height: 18px;
  border: 1px solid #2ca01c;
  border-radius: 100%;
  background: #fff;
}
[type="radio"]:not(:checked) + label:before {
  border: 1px solid #afafaf;
}
[type="radio"]:checked + label:after,
[type="radio"]:not(:checked) + label:after {
  content: "";
  width: 10px;
  height: 10px;
  background: #2ca01c;
  position: absolute;
  top: 4px;
  left: 4px;
  border-radius: 100%;
  -webkit-transition: all 0.2s ease;
  transition: all 0.2s ease;
}
[type="radio"]:not(:checked) + label:after {
  opacity: 0;
  -webkit-transform: scale(0);
  transform: scale(0);
}
[type="radio"]:checked + label:after {
  opacity: 1;
  -webkit-transform: scale(1);
  transform: scale(1);
}

/**Navigation Tab */
.tab-content {
  border: 1px solid #c9ccd2;
}

.nav-tabs {
  border: none !important;
}

.nav-tabs .nav-link.active {
  color: #111 !important;
  background-color: #cce4f9 !important;
  height: 34px;
  border: 1px solid #c9ccd2 !important;
  padding: 0.5rem 1rem;
  margin-top: 0;
}

.nav-tabs .nav-link {
  border: 1px solid #c9ccd2 !important;
  margin-right: 2px;
  color: #111;
  padding: 0.2rem 1rem;
  margin-top: 8px;
  transition: all 0.2s ease;
}

.nav-tabs .nav-link:hover {
  color: #2ca01c !important;
}

/**Footer Dialog */
.ms-popup-footer {
  padding-right: 11px;
}

.divide {
  width: 100%;
  border-top: 1px solid #e0e0e0;
  margin: 32px 0 20px 0;
  position: relative;
}

.ms-button-size-default {
  height: 36px;
  padding: 8px 20px;
}

.ms-button-secondary {
  border: 1px solid #8d9096;
  color: #111;
  background-color: transparent;
}

.ms-button-secondary:hover {
  background-color: #d2d3d6;
}

.ms-button-secondary:active {
  background-color: #bbbcbc;
}

.ms-button-primary {
  border: 1px solid transparent;
  color: #fff;
  background-color: #2ca01c;
}

.ms-button-primary:focus {
  background-color: #2ca01c;
  color: #fff;
}

.ms-button-primary:hover {
  background-color: #35bf22;
  color: #fff;
}

.ms-button-primary:active {
  background-color: #248b15;
  color: #fff;
}

.ms-button-radius-false,
.ms-button-radius-false:before {
  border-radius: 3px;
}

/**Dialog cảnh báo */
.mi-exclamation-error-48-2 {
  background-position: -24px -954px;
}

.Center {
  position: absolute;
  left: 50%;
  transform: translateX(-50%);
}
</style>

<script>
import JQuery from "jquery";
let $ = JQuery;

export default {
  props: ["employee"],
  data() {
    return {
      loading: true,
      employeeId: "",
      employees: [],
      departments: [
        {
          departmentId: "11452b0c-768e-5ff7-0d63-eeb1d8ed8cef",
          departmentName: "Phòng nhân sự",
        },
        {
          departmentId: "142cb08f-7c31-21fa-8e90-67245e8b283e",
          departmentName: "Phòng Marketing",
        },
      ],
    };
  },
  mounted() {
    // $("#add-employee-dialog").modal("show");
    // $("#error-dialog").modal("show");
    $("#add-employee-dialog").on("shown.bs.modal", function () {
      document.getElementById("employee-code").focus();
    });
    //checkbox
    var checkboxIsCustomer = $("#isCustomer");
    var checkboxIsSupplier = $("#isSupplier");

    checkboxIsCustomer.click(function () {
      if (checkboxIsCustomer.is(":checked")) {
        checkboxIsCustomer.next().addClass("ms-checkbox-border-checked-true");
        checkboxIsCustomer
          .next()
          .removeClass("ms-checkbox-border-checked-false");
        checkboxIsCustomer
          .next()
          .find(".ms-checkbox-inner")
          .append(
            '<div class="mi mi-16 mi-checkbox-active icon-checked"></div>'
          );
      } else {
        checkboxIsCustomer.next().addClass("ms-checkbox-border-checked-false");
        checkboxIsCustomer
          .next()
          .removeClass("ms-checkbox-border-checked-true");
        checkboxIsCustomer.next().find(".icon-checked").remove();
      }
    });

    checkboxIsSupplier.click(function () {
      if (checkboxIsSupplier.is(":checked")) {
        checkboxIsSupplier.next().addClass("ms-checkbox-border-checked-true");
        checkboxIsSupplier
          .next()
          .removeClass("ms-checkbox-border-checked-false");
        checkboxIsSupplier
          .next()
          .find(".ms-checkbox-inner")
          .append(
            '<div class="mi mi-16 mi-checkbox-active icon-checked"></div>'
          );
      } else {
        checkboxIsSupplier.next().addClass("ms-checkbox-border-checked-false");
        checkboxIsSupplier
          .next()
          .removeClass("ms-checkbox-border-checked-true");
        checkboxIsSupplier.next().find(".icon-checked").remove();
      }
    });

    //combobox chọn đơn vị
    var btnComboEmployeeDepartment = document.getElementById(
      "btn-combo-employee-department"
    );
    var comboEmployeeDepartment = document.getElementById(
      "combo-employee-department"
    );
    btnComboEmployeeDepartment.onclick = function () {
      if (comboEmployeeDepartment.style.display === "none") {
        comboEmployeeDepartment.style.display = "block";
      } else {
        comboEmployeeDepartment.style.display = "none";
      }
    };
  },
  methods: {
    hideErrorDialog() {
      $("#error-dialog").modal("hide");
    },

    hideComboEmployeeDepartment() {
      $("#combo-employee-department").css("display", "none");
    },

    setDepartmentIdToEmployee(departmentId, departmentName) {
      this.employee.departmentId = departmentId;
      this.employee.departmentName = departmentName;
    },

    getGenderEmployee(){
      if($('#gender-male').is(":checked")){
        this.employee.gender = 0;
      }
      else if($('#gender-female').is(":checked")){
        this.employee.gender = 1;
      }
      else{
        this.employee.gender = 2;
      }
    },

    //Đổi định dạng ngày từ Db để hiển thị
    changeDatetimeToDate(datetime) {
      if (datetime) {
        var date = new Date(datetime);
        var formatOptions = {
          day: "2-digit",
          month: "2-digit",
          year: "numeric",
        };
        var dateString = date.toLocaleDateString("en-US", formatOptions);

        return dateString;
      }
      return "";
    },

    //Đổi định dạng ngày cho Input nhận
    changeDatetimeToDateForInput(datetime) {
      var date = new Date(datetime);

      var dateString =
        date.getFullYear() +
        "-" +
        ("00" + (date.getMonth() + 1)).slice(-2) +
        "-" +
        ("00" + date.getDate()).slice(-2);
      // console.log(dateString);
      return dateString;
    },

    //set ngày sinh cho nhân viên
    setDateOfBirth(event) {
      this.employee.dateOfBirth = event.target.value;
      console.log(this.employee.dateOfBirth);
    },

    //set ngày cấp CMND cho nhân viên
    setIdentityDate(event) {
      this.employee.identityDate = event.target.value;
      console.log(this.employee.identityDate);
    },

    //input chỉ có số
    isNumber: function (evt) {
      evt = evt ? evt : window.event;
      var charCode = evt.which ? evt.which : evt.keyCode;
      if (
        charCode > 31 &&
        (charCode < 48 || charCode > 57)
        // && charCode !== 46
      ) {
        evt.preventDefault();
      } else {
        return true;
      }
    },

    //input số điện thoại chỉ có số và dấu +
    //VD +84xxx
    isPhoneNumber: function (evt) {
      evt = evt ? evt : window.event;
      var charCode = evt.which ? evt.which : evt.keyCode;
      if (
        charCode > 31 &&
        (charCode < 48 || charCode > 57) &&
        charCode !== 43
      ) {
        evt.preventDefault();
      } else {
        return true;
      }
    },

    saveAndAddNewEmployee(){
      this.getGenderEmployee();
      console.log(this.employee);
      this.employee = [];
    }
  },
};
</script>