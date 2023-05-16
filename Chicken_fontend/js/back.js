import gameScene3C from './phaser_scence_3C.JS'

const w = window.innerWidth;
const h = window.innerHeight;
var cursors;

// class gameStart extends Phaser.Scene {

//     preload() {

//     }
//     create() {

//     }
//     update() {

//     }
// }

const gameStart = {
    key: 'gameStart',
    preload: function () {
        this.load.image('bg01', '/img/phaser/bg01.png');
        this.load.spritesheet('stand', '/img/phaser/Sprite_stand.png', {
            frameWidth: 128, frameHeight: 128
        });
        this.load.spritesheet('walk', 'img/phaser/Sprite_walk.png', {
            frameWidth: 128, frameHeight: 128
        });
        this.load.spritesheet('Npc01Stand', 'img/phaser/NPC01_stand.png', {
            frameWidth: 128, frameHeight: 128
        });
        this.load.spritesheet('Npc01Walk', 'img/phaser/NPC01_walk.png', {
            frameWidth: 128, frameHeight: 128
        });

        this.load.on('complete', function () {
            this.anims.create({
                key: 'stand_anim',
                frames: this.anims.generateFrameNumbers('stand', { start: 0, end: 7 }),
                frameRate: 10,
                repeat: -1
            });

            this.anims.create({
                key: 'walk_anim',
                frames: this.anims.generateFrameNumbers('walk', { start: 0, end: 7 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'Npc01Stand_anim',
                frames: this.anims.generateFrameNumbers('Npc01Stand', { start: 0, end: 7 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'Npc01Walk_anim',
                frames: this.anims.generateFrameNumbers('Npc01Walk', { start: 0, end: 7 }),
                frameRate: 10,
                repeat: -1
            })
        }.bind(this));
    },
    create: function () {

        this.cameras.main.centerOn(800, 800);

        // 啟用物理引擎並設置邊界
        this.physics.world.setBounds(0, 0, 1600, 1600);

        const bg = this.add.image(0, 0, 'bg01').setOrigin(0);

        // 將玩家的位置設置在背景圖片的中央
        this.player = this.physics.add.sprite(bg.width / 2, bg.height / 2, 'stand');
        this.player.anims.play('stand_anim', true);
        this.player.setCollideWorldBounds(true);
        this.player.setScale(0.25);
        //創建粉紅熊熊NPC
        this.Npc01 = this.physics.add.sprite(bg.width / 2 + 100, bg.height / 2 + 100, 'Npc01Stand');
        this.Npc01.anims.play('Npc01Stand_anim', true);
        this.Npc01.setCollideWorldBounds(true);
        this.Npc01.setScale(0.5);


        cursors = this.input.keyboard.createCursorKeys();
        this.cameras.main.startFollow(this.player);

        this.input.on('pointerdown', function () {
            this.scene.add(this, gameScene3C, true);
            this.scene.remove(this, gameStart, true);

        }, this);
    },

    update: function () {
        var keyW = this.input.keyboard.addKey('W');
        var keyS = this.input.keyboard.addKey('S');
        var keyA = this.input.keyboard.addKey('A');
        var keyD = this.input.keyboard.addKey('D');

        if (cursors.up.isDown) {
            this.player.y -= 4;
            if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                this.player.anims.play('walk_anim');
            }
            this.cameras.main.scrollY -= 4;
        }
        else if (cursors.down.isDown) {
            this.player.y += 4;
            if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                this.player.anims.play('walk_anim');
            }
            this.cameras.main.scrollY += 4;
        }
        else if (cursors.left.isDown) {
            this.player.x -= 4;
            if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                this.player.anims.play('walk_anim');
            }
            this.cameras.main.scrollX -= 4;
            this.player.flipX = true;
        }
        else if (cursors.right.isDown) {
            this.player.x += 4;
            if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
                this.player.anims.play('walk_anim');
            }
            this.cameras.main.scrollX += 4;
            this.player.flipX = false;
        }
        else {
            this.player.anims.play('stand_anim', true);
        }



        if (keyW.isDown) {
            this.Npc01.y -= 4;
            if (this.Npc01.anims.currentAnim !== this.anims.get('Npc01Walk_anim')) {
                this.Npc01.anims.play('Npc01Walk_anim');
            }
        }
        else if (keyS.isDown) {
            this.Npc01.y += 4;
            if (this.Npc01.anims.currentAnim !== this.anims.get('Npc01Walk_anim')) {
                this.Npc01.anims.play('Npc01Walk_anim');
            }
        }
        else if (keyA.isDown) {
            this.Npc01.x -= 4;
            if (this.Npc01.anims.currentAnim !== this.anims.get('Npc01Walk_anim')) {
                this.Npc01.anims.play('Npc01Walk_anim');
            }
            this.Npc01.flipX = true;
        }
        else if (keyD.isDown) {
            this.Npc01.x += 4;
            if (this.Npc01.anims.currentAnim !== this.anims.get('Npc01Walk_anim')) {
                this.Npc01.anims.play('Npc01Walk_anim');
            }
            this.Npc01.flipX = false;
        }
        else {
            this.Npc01.anims.play('Npc01Stand_anim', true);
        }
    },
    render: function () {
        this.debug.cameraInfo(this.cameras.main, 32, 32);
    }
};

const config = {
    type: Phaser.AUTO,
    width: '100%',
    height: '100%',
    parent: 'gameArea',
    scene: [gameStart],
    scale: {
        mode: Phaser.Scale.FIT,
        autoCenter: Phaser.Scale.CENTER_BOTH
    },
    renderType: 2,
    backgroundColor: '#FFFFFF',
    physics: {
        default: 'arcade',
        arcade: {
            debug: false
        }
    }
};

const game = new Phaser.Game(config);