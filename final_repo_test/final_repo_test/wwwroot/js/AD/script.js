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