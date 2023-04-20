const w = 1200;
const h = 599;
var cursors;
const gameStart = {
    key: 'gameStart',
    preload: function () {
        this.load.image('bg01', '../images/bg01.jpg');
    },
    create: function () {
        this.bg01 = this.add.tileSprite(w / 2, h / 2, w, h, 'bg01');
        cursors = this.input.keyboard.createCursorKeys();
    },
    update: function () {
        if (cursors.up.isDown) {
            this.cameras.main.scrollY -= 4;
        }
        else if (cursors.down.isDown) {
            this.cameras.main.scrollY += 4;
        }

        if (cursors.left.isDown) {
            this.cameras.main.scrollX -= 4;
        }
        else if (cursors.right.isDown) {
            this.cameras.main.scrollX += 4;
        }
    },
    render: function () {
        this.debug.cameraInfo(this.cameras.main, 32, 32);
    }
}

const config = {
    type: Phaser.AUTO,
    width: 300,
    height: 200,
    parent: 'app',
    scene: [gameStart]
}
const game = new Phaser.Game(config);