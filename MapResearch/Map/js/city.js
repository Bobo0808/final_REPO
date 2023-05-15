var canvas = document.getElementById("mycanvas");
var ctx = canvas.getContext("2d");

ww = canvas.width = 1800;
wh = canvas.height = 900;

//js
//兼容向量和xy值使用
let getVec2 = (args) => {
    if (args.length == 1) {
        //向量
        return args[0];
    } else if (args.length == 2) {
        //座標
        return new Vec2(args[0], args[1]);
    }
}
let beginPath = () => { ctx.beginPath() }
let closePath = () => { ctx.closePath() }

let setFill = (color) => { ctx.fillStyle = color }
let setStroke = (color) => { ctx.strokeStyle = color }

//坐標系轉移
let save = (func) => {
    ctx.save()
    func()
    ctx.restore()
}

//定位(這一個物件到底在哪裡)
//有兩個座標(1. io格子座標 2.實際上繪圖)
class GameObject {
    //物件
    constructor(args) {
        //建議物件def
        let def = {
            //兩座標確認
            p: Vec2.ZERO,
            gridP: Vec2.ZERO,
        }
        Object.assign(def, args);
        Object.assign(this, def);
        //轉換
        this.p = GETPOS(this.gridP);
    }
    //碰撞
    collide(gobj) {
        return this.p.sub(gobj.p).length < WSPAN;
    }
}

//碰撞座標讀取
const collisionsMap = [];
for (let i = 0; i < collisions.length; i += 50) {
    // console.log(collisions.slice(i, 50 + i));
    collisionsMap.push(collisions.slice(i, 50 + i));
}
console.log(collisionsMap);
//定義碰撞
// class Boundary {
//     static width = 64;
//     static height = 64;
//     constructor() {
//         //位置相對做標定義
//         // this.position = position;
//         //地圖放大200%
//         this.width = 64;
//         this.height = 64;
//     }
//     drae() {
//         ctx.fillStyle = 'red';
//         ctx.fillRect(this.position.x, this.position.y, this.width, this.height);
//     }
// }

const boundaries = []
const TestForBoundaries = []
//起始中心移動位置
const offset = {
    x: -450,
    y: -750
}
//將碰撞區域加入新陣列
// 遍歷 collisionsMap 中的每一行，i 為行索引，row 為行數組
collisionsMap.forEach((row, i) => {
    // 遍歷行數組中的每一個符號，j 為列索引，symbol 為符號值
    row.forEach((symbol, j) => {
        // console.log(symbol);
        if (symbol == 2074) {
            TestForBoundaries.push(`${j}-${i}`)
            boundaries.push(new Boundary({
                position: {
                    x: j * Boundary.width + offset.x,
                    y: i * Boundary.height + offset.y,
                }
            }))
        }
        // console.log('boundaries=',boundaries);
    })
})
console.log(`TestForBoundaries=${TestForBoundaries}`);
console.log(`TestForBoundaries=${TestForBoundaries.length}`);
function test(){
    for (let i = 0; i < boundaries.length; i++) {
        const boundary = boundaries[i]
        // console.log(`boundaries[${i}]=${boundaries}`);
       
    }
}
test();


//讀取地圖
ctx.fillStyle = 'white';
ctx.fillRect(0, 0, canvas.width, canvas.height);

const image = new Image();
image.src = './img/city200.png';
// ctx.drawImage('../img/city.png');

function rectangularCollision({ rectangle1, rectangle2 }) {
    return (
        rectangle1.position.x + rectangle1.width >= rectangle2.position.x &&
        rectangle1.position.x <= rectangle2.position.x + rectangle2.width &&
        rectangle1.position.y <= rectangle2.position.y + rectangle2.height &&
        rectangle1.position.y + rectangle1.height >= rectangle2.position.y
    )
}

function checkForCharacterCollision({
    player,
}) {
    player.interactionAsset = null
    // monitor for character collision
    for (let i = 0; i < boundaries.length; i++) {
        const boundary = boundaries[i]
        if (
            rectangularCollision({
                rectangle1: player,
                rectangle2: {
                    ...boundary,
                    position: {
                        x: boundary.position.x + 3,
                        y: boundary.position.y
                    }
                }
            })
        ) {
            moving = false
            break
        }
    }

}



//角色

const foregroundImage = new Image()
foregroundImage.src = './img/foregroundobjects200.png'

const playerDownImage = new Image()
playerDownImage.src = './img/playerDown.png'

const playerUpImage = new Image()
playerUpImage.src = './img/playerUp.png'

const playerLeftImage = new Image()
playerLeftImage.src = './img/playerLeft.png'

const playerRightImage = new Image()
playerRightImage.src = './img/playerRight.png'

// class Sprite{
//     constructor({position,velocity,image }){
//         this.position=position;
//         this.image=image;
//     }
//     draw(){
//         ctx.drawImage(image, -400, -700);
//     }
// }

// image.onload = () => {
//     ctx.drawImage(image, -400, -700);
//     ctx.drawImage(
//         playerDownImage,
//         //cropping
//         0,
//         0,
//         playerDownImage.width / 4,
//         playerDownImage.height,
//         //actual
//         canvas.width / 2 - playerDownImage.width / 4 / 2,
//         canvas.height / 2 - playerDownImage.height / 2,
//         playerDownImage.width / 4,
//         playerDownImage.height,
//     );

// }
const player = new Sprite({
    position: {
        //192圖片直徑
        //68圖片
        x: canvas.width / 2 - 192 / 4 / 2,
        y: canvas.height / 2 - 68 / 2
    },
    image: playerDownImage,
    frames: {
        max: 4,
        hold: 10
    },
    sprites: {
        up: playerUpImage,
        left: playerLeftImage,
        right: playerRightImage,
        down: playerDownImage
    }
})

const background = new Sprite({
    position: {
        x: offset.x,
        y: offset.y
    },
    image: image
})

const foreground = new Sprite({
    position: {
        x: offset.x,
        y: offset.y
    },
    image: foregroundImage
})

const keys = {
    w: {
        pressed: false
    },
    a: {
        pressed: false
    },
    s: {
        pressed: false
    },
    d: {
        pressed: false
    }
}

const movables = [
    background,
    ...boundaries,
    foreground,
]
const renderables = [
    background,
    ...boundaries,
    player,
    foreground
]
//action
function animate() {
    const animationId = window.requestAnimationFrame(animate)
    renderables.forEach((renderable) => {
        renderable.draw()
    })

    let moving = true
    player.animate = false

    if (keys.w.pressed && lastKey === 'w') {
        player.animate = true
        player.image = player.sprites.up

        checkForCharacterCollision({
            player,
            characterOffset: { x: 0, y: 3 }
        })

        for (let i = 0; i < boundaries.length; i++) {
            const boundary = boundaries[i]
            if (
                rectangularCollision({
                    rectangle1: player,
                    rectangle2: {
                        ...boundary,
                        position: {
                            x: boundary.position.x,
                            y: boundary.position.y + 3
                        }
                    }
                })
            ) {
                moving = false
                break
            }
        }

        if (moving)
            movables.forEach((movable) => {
                movable.position.y += 3
            })
    } else if (keys.a.pressed && lastKey === 'a') {
        player.animate = true
        player.image = player.sprites.left

        checkForCharacterCollision({
            player,
            characterOffset: { x: 3, y: 0 }
        })

        for (let i = 0; i < boundaries.length; i++) {
            const boundary = boundaries[i]
            if (
                rectangularCollision({
                    rectangle1: player,
                    rectangle2: {
                        ...boundary,
                        position: {
                            x: boundary.position.x + 3,
                            y: boundary.position.y
                        }
                    }
                })
            ) {
                moving = false
                break
            }
        }

        if (moving)
            movables.forEach((movable) => {
                movable.position.x += 3
            })
    } else if (keys.s.pressed && lastKey === 's') {
        player.animate = true
        player.image = player.sprites.down

        checkForCharacterCollision({
            player,
            characterOffset: { x: 0, y: -3 }
        })

        for (let i = 0; i < boundaries.length; i++) {
            const boundary = boundaries[i]
            if (
                rectangularCollision({
                    rectangle1: player,
                    rectangle2: {
                        ...boundary,
                        position: {
                            x: boundary.position.x,
                            y: boundary.position.y - 3
                        }
                    }
                })
            ) {
                moving = false
                break
            }
        }

        if (moving)
            movables.forEach((movable) => {
                movable.position.y -= 3
            })
    } else if (keys.d.pressed && lastKey === 'd') {
        player.animate = true
        player.image = player.sprites.right

        checkForCharacterCollision({
            player,
            characterOffset: { x: -3, y: 0 }
        })

        for (let i = 0; i < boundaries.length; i++) {
            const boundary = boundaries[i]
            if (
                rectangularCollision({
                    rectangle1: player,
                    rectangle2: {
                        ...boundary,
                        position: {
                            x: boundary.position.x - 3,
                            y: boundary.position.y
                        }
                    }
                })
            ) {
                moving = false
                break
            }
        }

        if (moving)
            movables.forEach((movable) => {
                movable.position.x -= 3
            })
    }
}
// animate()

let lastKey = ''
window.addEventListener('keydown', (e) => {
    if (player.isInteracting) {
        switch (e.key) {
            case ' ':
                player.interactionAsset.dialogueIndex++

                const { dialogueIndex, dialogue } = player.interactionAsset
                if (dialogueIndex <= dialogue.length - 1) {
                    document.querySelector('#characterDialogueBox').innerHTML =
                        player.interactionAsset.dialogue[dialogueIndex]
                    return
                }

                // finish conversation
                player.isInteracting = false
                player.interactionAsset.dialogueIndex = 0
                document.querySelector('#characterDialogueBox').style.display = 'none'

                break
        }
        return
    }

    switch (e.key) {
        case ' ':
            if (!player.interactionAsset) return

            // beginning the conversation
            const firstMessage = player.interactionAsset.dialogue[0]
            document.querySelector('#characterDialogueBox').innerHTML = firstMessage
            document.querySelector('#characterDialogueBox').style.display = 'flex'
            player.isInteracting = true
            break
        case 'w':
            keys.w.pressed = true
            lastKey = 'w'
            break
        case 'a':
            keys.a.pressed = true
            lastKey = 'a'
            break

        case 's':
            keys.s.pressed = true
            lastKey = 's'
            break

        case 'd':
            keys.d.pressed = true
            lastKey = 'd'
            break
    }
})

window.addEventListener('keyup', (e) => {
    switch (e.key) {
        case 'w':
            keys.w.pressed = false
            break
        case 'a':
            keys.a.pressed = false
            break
        case 's':
            keys.s.pressed = false
            break
        case 'd':
            keys.d.pressed = false
            break
    }
})

animate();





class Vec2 {
    constructor(x, y) {
        this.x = x
        this.y = y
    }
    set(x, y) {
        this.x = x
        this.y = y
    }
    move(x, y) {
        this.x += x
        this.y += y
    }
    add(v) {
        return new Vec2(this.x + v.x, this.y + v.y)
    }
    sub(v) {
        return new Vec2(this.x - v.x, this.y - v.y)
    }
    mul(s) {
        return new Vec2(this.x * s, this.y * s)
    }
    get length() {
        return Math.sqrt(this.x * this.x + this.y * this.y)
    }
    set length(nv) {
        let temp = this.unit.mul(nv)
        this.set(temp.x, temp.y)
    }
    clone() {
        return new Vec2(this.x, this.y)
    }
    toString() {
        return `(${this.x}, ${this.y})`
    }
    equal(v) {
        return this.x == v.x && this.y == v.y
    }
    get angle() {
        return Math.atan2(this.y, this.x)
    }
    get unit() {
        return this.mul(1 / this.length)
    }
    //關於事實的屬性ex: (0,-1)或是方法存於類別上
    static get ZERO() {
        return new Vec2(0, 0)
    }
    static get UP() {
        return new Vec2(0, -1)
    }
    static get DOWN() {
        return new Vec2(0, 1)
    }
    static get LEFT() {
        return new Vec2(-1, 0)
    }
    static get RIGHT() {
        return new Vec2(1, 0)
    }
    //方向向量靜態
    static DIR(str) {
        if (!str) {
            return Vec2.ZERO
        }
        let type = ("" + str).toUpperCase()
        return Vec2[type]
    }
    //角度
    static DIR_ANGLE(str) {
        switch (str) {
            case "right":
                return 0
            case "left":
                return PI()
            case "up":
                return PI(-0.5)
            case "down":
                return PI(0.5)
        }
        return 0
    }

}