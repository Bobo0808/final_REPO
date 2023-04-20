function deletePartner(id) {
    if (confirm("確定刪除該廠商？")) {
        $.ajax({
            url: "/AD/AD_Home/DeletePartner?id=" + id,
            type: "POST",
            success: function (result) {
                if (result.success) {
                    // 更新畫面
                    location.reload();
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
                    var partners = result.partners;
                    var partnerTableBody = $("#partnerTable tbody");
                    partnerTableBody.empty();
                    for (var i = 0; i < partners.length; i++) {
                        var partner = partners[i];
                        var tr = $("<tr>");
                        tr.attr("data-id", partner.id);
                        tr.append($("<td>").text(partner.p_Name));
                        tr.append($("<td>").text(partner.contact));
                        tr.append($("<td>").text(partner.email));
                        tr.append($("<td>").text(partner.phone));
                        tr.append($("<td>").text(partner.p_Note));
                        tr.append($("<td>").html("<a href='#' onclick='deletePartner(" + partner.id + ")'>刪除</a>"));
                        partnerTableBody.append(tr);
                    }
                } else {
                    alert("新增廠商失敗");
                }
        
            }
        });
    });
});







