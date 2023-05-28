﻿var today = new Date();
var toastContainer = document.getElementById("toastContainer");

document.getElementById('form_AD').addEventListener("submit", function (e) {
    var startDate = new Date(document.getElementById('startDate').value);
    var endDate = new Date(document.getElementById('endDate').value);
    if (startDate.getTime() > endDate.getTime()) {
        e.preventDefault();
        document.getElementById('dateError').style.display = "block";
    }
    else if (startDate < today) {
        e.preventDefault();
        document.getElementById("endDateError").style.display = "block"; // 显示错误消息
    }
    else {
        var toast = $('<div class="toast align-items-center text-white bg-success border-0" role="alert" aria-live="assertive" aria-atomic="true"><div class="d-flex"><div class="toast-body"><i class="fa-solid fa-circle-check" style="color: #ffffff;"></i>&nbsp;廣告上架成功！</div><button type="button" class="btn-close me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button></div></div>');
        $('.toast-container').append(toast);

        var toastInstance = new bootstrap.Toast(toast.get(0), { autohide: true, delay: 2000 });
        toastInstance.show();
    }
});