var tableData = [{
    "PID": 1,
    "PName": "牛仔外套",
    "PType": "外套",
    "PPrice": 500,
    "PDescribe": "我是誰我在哪",
    "PInstock": 99,
    "PDate": "2022,04,23",
    "PDiscount": null,
    "PDiscontinuted": false,
    "PImage": "1.jpg"
}, {
    "PID": 2,
    "PName": "鮮豔圍裙",
    "PType": "圍裙",
    "PPrice": 120,
    "PDescribe": "適合廚房的東西",
    "PInstock": 99,
    "PDate": "2022 / 01 / 15",
    "PDiscount": null,
    "PDiscontinuted": false,
    "PImage": "2.jpg"
}, {
    "PID": 3,
    "PName": "西裝褲",
    "PType": "褲子",
    "PPrice": 1200,
    "PDescribe": "正式場合必備",
    "PInstock": 99,
    "PDate": "2022 / 02 / 28",
    "PDiscount": null,
    "PDiscontinuted": false,
    "PImage": "3.jpg"
}, {
    "PID": 4,
    "PName": "洋裙",
    "PType": "裙子",
    "PPrice": 800,
    "PDescribe": "適合自己的浪漫、時髦或休閒的洋裝",
    "PInstock": 99,
    "PDate": "2022 / 03 / 28",
    "PDiscount": null,
    "PDiscontinuted": false,
    "PImage": "4.jpg"
}]



var tableTd = document.querySelector('tbody');
let text = "";
tableData.forEach((item) => {
    let date = new Date(item.PDate);
    text += `<tr><td><a href="#">Edit</a>|<br><a href="#">Details</a>|<br><a href="#">Delete</a>|</td>
    <td><img src=./images/${item.PImage} class="img-fluid img-thumbnail"></td>
    <td>${item.PName}</td>
    <td>${item.PType}</td>
    <td>${item.PPrice}</td>
    <td>${item.PDescribe}</td>
    <td>${item.PInstock}</td>
    <td>${date}</td>
    <td>${item.PDiscount}</td>
    <td>${item.PDiscontinuted}</td></tr>`;
})
tableTd.innerHTML = text;
