var canvas = document.querySelector("canvas");
var ctx = canvas.getContext("2d");
var tilesetContainer = document.querySelector(".tileset-container");
var tilesetSelection = document.querySelector(".tileset-container_selection");
var tilesetImage = document.querySelector("#tileset-source");
//BlockCheck
var checkbox = document.getElementById('blockCheck');
var isCheckForBlock = false;

var ww = canvas.width;
var wh = canvas.height;
var boxWidth = 32;
var boxHeight = 32;
var numRows = ww / boxWidth;
var numCols = wh / boxHeight;

var selection = [0, 0]; //Which tile we will paint from the menu
var selectionEnd = [0, 0];
var selectionStart = null; //選擇起始點

var isMouseDown = false;

var currentLayer = 0;
var layers = [
    //Bottom
    {
        //Structure is "x-y": ["tileset_x", "tileset_y"] ex:"1-1": [3, 4],
    },
    //Middle
    {},
    //Top
    {},
    //Block
    {}
];

//坐標系轉移
let save = (func) => {
    ctx.save()
    func()
    ctx.restore()
}


//Select tile from the Tiles grid
//滑鼠按下
tilesetContainer.addEventListener("mousedown", (event) => {
    selection = getCoords(event);
    // selectionStart = getCoords(event);
    tilesetSelection.style.left = selection[0] * boxWidth + "px";
    tilesetSelection.style.top = selection[1] * boxHeight + "px";
});

//滑鼠彈回
// tilesetContainer.addEventListener('mouseup', (event) => {
//     selectionEnd = getCoords(event);
//     const x1 = Math.min(selectionStart[0], selectionEnd[0]);
//     const y1 = Math.min(selectionStart[1], selectionEnd[1]);
//     const x2 = Math.max(selectionStart[0], selectionEnd[0]);
//     const y2 = Math.max(selectionStart[1], selectionEnd[1]);
//     const width = (x2 - x1 + 1) * 32;
//     const height = (y2 - y1 + 1) * 32;
//     // 設置選擇框的位置和大小
//     tilesetSelection.style.left = x1 * 32 + "px";
//     tilesetSelection.style.top = y1 * 32 + "px";
//     tilesetSelection.style.width = width + "px";
//     tilesetSelection.style.height = height + "px";
//     for (let x = x1; x <= x2; x++) {
//         for (let y = y1; y <= y2; y++) {
//             const key = x + "-" + y;
//             layers[currentLayer][key] = [x, y];
//         }
//     }
// });

//Utility for getting coordinates of mouse click
function getCoords(e) {
    const { x, y } = e.target.getBoundingClientRect();
    const mouseX = e.clientX - x;
    const mouseY = e.clientY - y;

    return [Math.floor(mouseX / boxWidth), Math.floor(mouseY / boxHeight)];
}
//畫布大小為外圍的兩倍
function getCanvasCoords(e) {
    const { x, y } = e.target.getBoundingClientRect();
    //座標取得正確，在計算時除以目前的 scale
    const mouseX = ((e.clientX - x) / size) * 1.5;
    const mouseY = ((e.clientY - y) / size) * 2;
    const tileX = Math.floor(mouseX / boxWidth);
    const tileY = Math.floor(mouseY / boxHeight);
    return [tileX, tileY];
}

//Canvas的地圖位置
//Handler for placing new tiles on the map
function addTile(mouseEvent) {
    var clicked = getCanvasCoords(event);
    var key = clicked[0] + "-" + clicked[1];
    console.log(key);
    if (mouseEvent.shiftKey) {
        delete layers[3][key];
        delete layers[currentLayer][key];
    } else {
        if (isCheckForBlock === false) {
            layers[3][key] = [0];
        } else {
            layers[3][key] = [1];
        }
        layers[currentLayer][key] = [selection[0], selection[1]];
    }
    draw();
}

//Bind mouse events for painting (or removing) tiles on click/drag
canvas.addEventListener("mousedown", () => {
    isMouseDown = true;
});
canvas.addEventListener("mouseup", () => {
    isMouseDown = false;
});
canvas.addEventListener("mouseleave", () => {
    isMouseDown = false;
});
canvas.addEventListener("mousedown", addTile);
canvas.addEventListener("mousemove", (event) => {
    if (isMouseDown) {
        addTile(event);
    }
});



//converts data to image:data string and pipes into new browser tab
function exportImage() {
    var data = canvas.toDataURL();
    var image = new Image();
    image.src = data;
    console.log(layers);
    var w = window.open("");
    w.document.write(image.outerHTML);
}

//Reset state to empty
function clearCanvas() {
    layers = [{}, {}, {}];
    draw();
}

setLayer(0);
function setLayer(newLayer) {
    //Update the layer
    currentLayer = newLayer;

    //Update the UI to show updated layer
    var oldActiveLayer = document.querySelector(".layer.active");
    if (oldActiveLayer) {
        oldActiveLayer.classList.remove("active");
    }
    document.querySelector(`[tile-layer="${currentLayer}"]`).classList.add("active");
}

function draw() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    var size_of_crop = 32;

    layers.forEach((layer) => {
        Object.keys(layer).forEach((key) => {
            //Determine x/y position of this placement from key ("3-4" -> x=3, y=4)
            var positionX = Number(key.split("-")[0]);
            var positionY = Number(key.split("-")[1]);
            var [tilesheetX, tilesheetY] = layer[key];

            ctx.drawImage(
                //圖像來源
                tilesetImage,
                //源圖像的裁剪位置，指的是從源圖像中截取哪一部分
                tilesheetX * boxWidth,
                tilesheetY * boxHeight,
                //源圖像的裁剪寬度和高度
                size_of_crop,
                size_of_crop,
                //繪製到 canvas 上的位置，指的是在 canvas 的哪一個位置繪製圖像
                positionX * boxWidth,
                positionY * boxHeight,
                //繪製到 canvas 上的寬度和高度
                size_of_crop,
                size_of_crop
            );
        });
    });
}


//Initialize app when tileset source is done loading
// tilesetImage.onload = function () {
//     layers = defaultState;
//     draw();
//     setLayer(0);
// }
// tilesetImage.src = "https://assets.codepen.io/21542/TileEditorSpritesheet.2x_2.png";
tilesetImage.src = "/img/MapEdit/atlas_32x.png";


// BlockChange
function BlockChange() {
    if (checkbox.checked === true) {
        isCheckForBlock = true;
    }
    else {
        isCheckForBlock = false
    }
    // console.log(isCheckForBlock);
    // for (let i = 0; i < numCols; i++) {
    //     matrix[i] = [];
    //     for (let j = 0; j < numRows; j++) {
    //         matrix[i][j] = checked ? 1 : 0;
    //     }
    // }
    // console.log(matrix);
}

// 初始畫布大小
var size = 1;

// 監聽滑動條事件，調整進度條大小
const sizeRange = document.getElementById("sizeRange");
sizeRange.addEventListener("input", () => {
    size = sizeRange.value / 50;
    //console.log(size);
    canvas.style.transform = `scale(${size})`;
});

// slider比例調整
//function slider() {
//    // 定義縮放比例
//    var scales = new [] { .125, .25, .5, 1, 2, 4, 8 };
//    // 根據 Slider 控制項的值選擇縮放比例
//    var scale = scales[(int)((Slider)sender).Value];

//    // 計算當前 Canvas 元素的中心點位置
//    var relativeMiddle = new Point((Map.ActualWidth + 20) / 2, (Map.ActualHeight + 20) / 2);
//    // 將中心點位置轉換為 Canvas 元素的座標系統中的位置
//    var oldLocation = CanvasScale.Transform(TemplateCanvas.PointFromScreen(relativeMiddle));

//    // 呼叫 ScaleChanged 方法，將 Canvas 元素進行縮放
//    ScaleChanged(scale, CanvasScale);

//    // 計算縮放後 Canvas 元素的中心點位置
//    var newLocation = CanvasScale.Transform(TemplateCanvas.PointFromScreen(relativeMiddle));

//    // 計算當前位置和縮放後位置的差距，並將地圖滾動到新位置以保持畫面不變
//    var shift = newLocation - oldLocation;
//    Map.ScrollToVerticalOffset(Map.VerticalOffset + shift.Y);
//    Map.ScrollToHorizontalOffset(Map.HorizontalOffset + shift.X);

//    // 更新顯示縮放比例的標籤內容
//    lblScale.Content = scale.ToString("P1").Replace(".0", string.Empty);

//}