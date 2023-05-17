
import gameScene3C from './phaser_scence_3C.JS'

const w = window.innerWidth;
const h = window.innerHeight;
var cursors;

const gameStart = {
    key: 'gameStart',
    preload: function () {
        // this.load.image('bg01', '/img/phaser/bg01.png');
        this.load.image("tiles", "/tiled/snowtileset.png");
        this.load.tilemapTiledJSON('map', '/tiled/F01.json');


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
        const map = this.make.tilemap({ key: "map", tileWidth: 32, tileHeight: 32 });
        const tileset = map.addTilesetImage("snowtileset", "tiles");
        const layer = map.createLayer("bg", tileset, 0, 0);
        const Houselayer = map.createLayer("clo", tileset, 0, 0);

        this.cameras.main.centerOn(1600, 1600);
        // 啟用物理引擎並設置邊界
        this.physics.world.setBounds(0, 0, 3200, 3200);

        // const bg = this.add.image(0, 0, 'bg01').setOrigin(0);

        // 將玩家的位置設置在背景圖片的中央
        this.player = this.physics.add.sprite(1600, 1600, 'stand');
        this.player.anims.play('stand_anim', true);

        this.player.setScale(0.25);
        Houselayer.setCollisionBetween(704, 870, true, Houselayer)
        map.setCollisionBetween(704, 870, true, Houselayer);
        this.physics.add.collider(Houselayer, this.player);
        // this.player.setCollideWorldBounds(true);

        console.log(this.physics);

        //創建粉紅熊熊NPC
        this.Npc01 = this.physics.add.sprite(1700, 1700, 'Npc01Stand');
        this.Npc01.anims.play('Npc01Stand_anim', true);
        this.Npc01.setCollideWorldBounds(true);
        this.Npc01.setScale(0.5);

        this.Npc01.setCollideWorldBounds(true);

        this.physics.add.collider(this.player, this.Npc01);
        cursors = this.input.keyboard.createCursorKeys();
        this.cameras.main.startFollow(this.player);

        // this.input.on('pointerdown', function () {
        //     this.scene.add(this, gameScene3C, true);
        //     this.scene.remove(this, gameStart, true);
        // }, this);
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
            debug: true
        }
    }
};

const game = new Phaser.Game(config);