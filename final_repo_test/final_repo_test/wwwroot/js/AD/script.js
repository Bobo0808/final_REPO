function deletePartner(id) {
    if (confirm("確定刪除該廠商？")) {
        $.ajax({
            url: "/AD/AD_Home/DeletePartner?id=" + id,
            type: "POST",
            success: function (result) {
                if (result.success) {
                    refreshTable();
                } else {
                    alert("刪除失敗");
                }
            },
            error: function () {
                alert("發生錯誤");
            }
        });
    }
}

$(document).ready(function () {
    $('.btncheck').click(function () {
        $.ajax({
            type: 'POST',
            url: '/AD/AD_Home/AddPartner',
            data: {
                PartnerName: $('input[name="PartnerName"]').val(),
                Contact: $('input[name="Contact"]').val(),
                Email: $('input[name="Email"]').val(),
                Phone: $('input[name="Phone"]').val(),
                Note: $('input[name="Note"]').val()
            },
            success: function (result) {
                if (result.success) {
                    $('input[name="PartnerName"]').val('');
                    $('input[name="Contact"]').val('');
                    $('input[name="Email"]').val('');
                    $('input[name="Phone"]').val('');
                    $('input[name="Note"]').val('');
                    refreshTable();

                    var toast = $('<div class="toast align-items-center text-white bg-success border-0" role="alert" aria-live="assertive" aria-atomic="true"><div class="d-flex"><div class="toast-body"><i class="fa-solid fa-circle-check" style="color: #ffffff;"></i>&nbsp;新增廠商成功！</div><button type="button" class="btn-close me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button></div></div>');
                    $('.toast-container').append(toast);

                    var toastInstance = new bootstrap.Toast(toast.get(0), { autohide: true, delay: 2000 });
                    toastInstance.show();
                } else {
                    alert("新增廠商失敗");
                }
            }
        });
    });
});

function refreshTable() {
    $.ajax({
        type: 'GET',
        url: '/AD/AD_Home/GetPartners',
        success: function (result) {
            var partnerTableBody = $("#partnerTable tbody");
            partnerTableBody.empty();
            for (var i = 0; i < result.length; i++) {
                var partner = result[i];
                var tr = $("<tr>");
                tr.attr("data-id", partner.p_ID);
                tr.append($("<td>").text(partner.p_ID));
                tr.append($("<td>").text(partner.p_Name));
                tr.append($("<td>").text(partner.contact));
                tr.append($("<td>").text(partner.email));
                tr.append($("<td>").text(partner.phone));
                tr.append($("<td>").text(partner.p_Note));
                tr.append($("<td>").html("<i class='fa-solid fa-pen-to-square' onclick='editPartner(" + partner.p_ID + ")'></i>"));
                tr.append($("<td>").html("<i class='fa-solid fa-trash-can' onclick='deletePartner(" + partner.p_ID + ")'></i>"));
                partnerTableBody.append(tr);
            }
            if (result.success) {
                $('input[name="PartnerName"]').val('');
                $('input[name="Contact"]').val('');
                $('input[name="Email"]').val('');
                $('input[name="Phone"]').val('');
                $('input[name="Note"]').val('');
                refreshTable();
            }
            $("#partnerTable").animate({ scrollTop: $("#partnerTable")[0].scrollHeight }, "slow");
        },
        error: function (result) {
            console.log(result.responseText);
        }
    });
}

var phoneInput = document.getElementById("phone");
var form = document.getElementById("CreateNew_form");

form.addEventListener("submit", function (e) {
    var phoneNum = phoneInput.value;
    var isValid = /^[0-9]{8,15}$/.test(phoneNum);

    if (!isValid) {
        document.getElementById('telError').style.display = "block";
        e.preventDefault();
    }
});