<template>
  <!-- The Modal -->
  <div class="modal fade" id="delete-employee-dialog">
    <div
      class="modal-dialog modal-dialog-centered"
      style="width: 444px; min-width: 444px"
    >
      <div class="modal-content">
        <div class="padding-32">
          <div class="content">
            <div class="icon-message">
              <div class="mi mi-48 mi-exclamation-warning-48"></div>
            </div>
            <div class="message-content p-l-16 p-t-12">
              <span id="idMessage" class="message"
                >Bạn có thực sự muốn xóa Nhân viên &lt;NV00002&gt; không?</span
              >
            </div>
          </div>
          <div class="mess-line"></div>
          <div class="mess-footer">
            <div class="RightSecond">
              <button
                name="button"
                class="ms-component ms-button ms-button-size-default ms-button-primary ms-button-primary-disabled-false ms-button-radius-false ms-button"
              >
                <div class="ms-button-text ms-button--text flex align-center">
                  Có
                </div>
              </button>
            </div>
            <div class="Left">
              <button
                name="button"
                class="ms-component ms-button ms-button-size-default ms-button-secondary ms-button-secondary-disabled-false ms-button-radius-false ms-button"
                data-dismiss="modal"
              >
                <div class="ms-button-text ms-button--text flex align-center">
                  Không
                </div>
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<style>
.content {
  display: flex;
  align-items: flex-start;
}

.mi-exclamation-warning-48 {
  background-position: -592px -456px;
}
.mi-48 {
  width: 48px;
  height: 48px;
  min-width: 48px;
  min-height: 48px;
}

.message-content {
  overflow: auto;
  max-height: 400px;
  margin-bottom: 32px;
}

.message {
  display: block;
}

.mess-line {
  height: 1px;
  background: #b8bcc3;
  margin-bottom: 20px;
}

.mess-footer {
  position: relative;
  height: 36px;
}

.RightSecond {
  float: right;
  padding-left: 8px;
}

.Left {
  float: left;
}
</style>