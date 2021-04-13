<template>
  <div class="modal fade" id="addEmployeeDialog">
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
                  <div class="col-sm-5 col-12">
                    <div class="form-group">
                      <label class="flex label-input" for="employee-code"
                        >Mã
                        <p class="label-for-input-requied">*</p></label
                      >
                      <input
                        type="text"
                        class="form-control input-is-focus"
                        id="employee-code"
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
                              class="menu-header__th"
                              style="width: 120px; text-align: left"
                            >
                              <span>Mã đơn vị</span>
                            </th>
                            <th
                              title=""
                              class="menu-header__th"
                              style="width: 280px; text-align: left"
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
                          <tr class="dropdown-item">
                            <td
                              class="dropdown-item-td level-2"
                              style="width: 120px; text-align: left"
                            >
                              <div class="dropdown-item-td--contents">
                                <div title="002" class="dropdown-item-td--text">
                                  002
                                </div>
                              </div>
                            </td>
                            <td
                              class="dropdown-item-td"
                              style="width: 280px; text-align: left"
                            >
                              <div class="dropdown-item-td--contents">
                                <div
                                  title="PHÒNG KẾ TOÁN"
                                  class="dropdown-item-td--text"
                                >
                                  PHÒNG KẾ TOÁN
                                </div>
                              </div>
                            </td>
                            <td class="selected-container"></td>
                          </tr>
                          <tr class="dropdown-item">
                            <td
                              class="dropdown-item-td level-2"
                              style="width: 120px; text-align: left"
                            >
                              <div class="dropdown-item-td--contents">
                                <div title="002" class="dropdown-item-td--text">
                                  002
                                </div>
                              </div>
                            </td>
                            <td
                              class="dropdown-item-td"
                              style="width: 280px; text-align: left"
                            >
                              <div class="dropdown-item-td--contents">
                                <div
                                  title="PHÒNG KẾ TOÁN"
                                  class="dropdown-item-td--text"
                                >
                                  PHÒNG KẾ TOÁN
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
                  />
                </div>
              </div>
              <div class="col-md-6 col-12 p-r-26">
                <div class="row">
                  <div class="col-sm-5 col-12">
                    <div class="form-group">
                      <label class="flex label-input" for="date-of-birth"
                        >Ngày sinh
                      </label>
                      <input
                        type="date"
                        class="form-control input-is-focus"
                        id="date-of-birth"
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
                            checked
                          />
                          <label for="gender-male" class="mr-4">Nam</label>
                        </p>
                        <p>
                          <input
                            type="radio"
                            id="gender-female"
                            name="radio-group"
                          />
                          <label for="gender-female">Nữ</label>
                        </p>
                      </div>
                    </div>
                  </div>
                </div>

                <div class="row">
                  <div class="col-sm-7 col-12">
                    <div class="form-group">
                      <label class="flex label-input" for="identity-number"
                        >Số CMND
                      </label>
                      <input
                        type="text"
                        class="form-control input-is-focus"
                        id="identity-number"
                      />
                    </div>
                  </div>
                  <div class="col-sm-5 col-12 pl-sm-0">
                    <div class="form-group">
                      <label class="flex label-input" for="identity-date"
                        >Ngày sinh
                      </label>
                      <input
                        type="date"
                        class="form-control input-is-focus"
                        id="identity-date"
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
                    <div class="form-group">
                      <label class="flex label-input" for="employee-adress"
                        >Địa chỉ
                      </label>
                      <input
                        type="text"
                        class="form-control input-is-focus"
                        id="employee-adress"
                      />
                    </div>
                    <div class="row">
                      <div class="col-md-3 col-12">
                        <div class="form-group">
                          <label class="flex label-input" for="phone-number"
                            >ĐT di động
                          </label>
                          <input
                            type="tel"
                            class="form-control input-is-focus"
                            id="phone-number"
                          />
                        </div>
                      </div>
                      <div class="col-md-3 col-12">
                        <div class="form-group">
                          <label class="flex label-input" for="tele-number"
                            >ĐT cố định
                          </label>
                          <input
                            type="tel"
                            class="form-control input-is-focus"
                            id="tele-number"
                          />
                        </div>
                      </div>
                      <div class="col-md-3 col-12">
                          <div class="form-group">
                          <label class="flex label-input" for="email"
                            >Email
                          </label>
                          <input
                            type="email"
                            class="form-control input-is-focus"
                            id="email"
                          />
                        </div>
                      </div>
                    </div>
                  </div>
                  <div id="bank-account-tab" class="container tab-pane fade">
                    <br />
                    Tài khoản ngân hàng
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

        <!-- Modal footer -->
        <div class="modal-footer border-0">
          <button type="button" class="btn btn-secondary" data-dismiss="modal">
            Close
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<style>
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
}

.dropdown-item:focus,
.dropdown-item:hover {
  color: #35bf22 !important;
  background-color: #ebedf0 !important;
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

@media (max-width: 992px) {
  .modal-lg,
  .modal-xl {
    max-width: 100% !important;
    margin: 0 !important;
  }
}
</style>

<script>
import JQuery from "jquery";
let $ = JQuery;

export default {
  mounted() {
    $("#addEmployeeDialog").modal("show");
    $("#addEmployeeDialog").on("shown.bs.modal", function () {
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
};
</script>