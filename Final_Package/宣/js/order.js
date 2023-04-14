var tableData = [{
    "OID": 1,
    "OAID": 1,
    "OTotalPrice": 1500,
    "ODate": "2022,04,23",
    "OCanel": false
}, {
    "OID": 2,
    "OAID": 2,
    "OTotalPrice": 2500,
    "ODate": "2022,01,23",
    "OCanel": true
}, {
    "OID": 3,
    "OAID": 5,
    "OTotalPrice": 3500,
    "ODate": "2022,02,15",
    "OCanel": false
}, {
    "OID": 4,
    "OAID": 7,
    "OTotalPrice": 4500,
    "ODate": "2022,03,18",
    "OCanel": false
}]

var tableTd = document.querySelector('tbody');
let text = "";
let test = "";
var StatusActivity = "";
tableData.forEach((item) => {
    if (item.OCanel === false) {
        StatusActivity = "Finished";
        test = "text-success";
    }
    else {
        StatusActivity = "canceled";
        test = "text-warning";
    }
    let date = new Date(item.PDate);
    text += `<tr>
    <td>
        <div class="d-flex align-items-center">
            <div>
                <input class="form-check-input me-3" type="checkbox" value=""
                    aria-label="...">
            </div>
            <div class="ms-2">
                <h6 class="mb-0 font-14">#${item.OID}</h6>
            </div>
        </div>
    </td>
    <td>${item.OAID}</td>
    <td>
        <div
            class="${test} badge rounded-pill bg-light-success p-2 text-uppercase px-3">
            <i class='bx bxs-circle me-1'></i>${StatusActivity}
        </div>
    </td>
    <td>${item.OTotalPrice}</td>
    <td>${item.ODate}</td>
    <td><button type="button" class="btn btn-primary btn-sm radius-30 px-4">View
            Details</button></td>
    <td>
        <div class="d-flex order-actions">
            <a href="javascript:;" class=""><i class='bx bxs-edit test'></i></a>
            <a href="javascript:;" class="ms-3"><i class='bx bxs-trash test'></i></a>
        </div>
    </td>`;

})
tableTd.innerHTML = text;


