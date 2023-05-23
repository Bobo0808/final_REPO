var cursors;
export default class gameScene3C extends Phaser.Scene {
    constructor() {
        super('gameScene3C');
    }
    preload() {
        this.load.image('test', '../assets/img/phaser/test.png');
        this.load.spritesheet('stand', '../assets/img/phaser/Sprite_stand.png', {
            frameWidth: 128, frameHeight: 128
        });
        this.load.spritesheet('walk', '../assetsimg/phaser/Sprite_walk.png', {
            frameWidth: 128, frameHeight: 128
        });
        this.load.spritesheet('NpcDeerStand', '../assetsimg/phaser/DeerStand.png', {
            frameWidth: 32, frameHeight: 32
        });
        this.load.spritesheet('NpcDeerWalk', '../assetsimg/phaser/DeerWalk.png', {
            frameWidth: 32, frameHeight: 32
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
                key: 'NpcDeerStand_font',
                frames: this.anims.generateFrameNumbers('NpcDeerStand', { start: 0, end: 3 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'NpcDeerStand_left',
                frames: this.anims.generateFrameNumbers('NpcDeerStand', { start: 4, end: 7 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'NpcDeerStand_right',
                frames: this.anims.generateFrameNumbers('NpcDeerStand', { start: 8, end: 11 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'NpcDeerStand_back',
                frames: this.anims.generateFrameNumbers('NpcDeerStand', { start: 12, end: 15 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'NpcDeerWalk_font',
                frames: this.anims.generateFrameNumbers('NpcDeerWalk', { start: 0, end: 3 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'NpcDeerWalk_left',
                frames: this.anims.generateFrameNumbers('NpcDeerWalk', { start: 4, end: 7 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'NpcDeerWalk_right',
                frames: this.anims.generateFrameNumbers('NpcDeerWalk', { start: 8, end: 11 }),
                frameRate: 10,
                repeat: -1
            });
            this.anims.create({
                key: 'NpcDeerWalk_back',
                frames: this.anims.generateFrameNumbers('NpcDeerWalk', { start: 12, end: 15 }),
                frameRate: 10,
                repeat: -1
            })
        }.bind(this));
    }
    create() {

        const bg = this.add.image(0, 0, 'test').setOrigin(0);
        this.cameras.main.centerOn(800, 800);
        this.physics.world.setBounds(0, 0, 1600, 1600);

        this.player = this.physics.add.sprite(bg.width / 2, bg.height / 2, 'stand');
        this.player.anims.play('stand_anim', true);
        this.player.setCollideWorldBounds(true);
        this.player.setScale(0.5);
        this.NpcDeer = this.physics.add.sprite(bg.width / 2 + 100, bg.height / 2 + 100, 'NpcDeerStand');
        this.NpcDeer.anims.play('NpcDeerStand_font', true);
        this.NpcDeer.setCollideWorldBounds(true);
        this.NpcDeer.setScale(2);
        cursors = this.input.keyboard.createCursorKeys();
        this.cameras.main.startFollow(this.player);
    }
    update() {
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
            this.NpcDeer.y -= 4;
            if (this.NpcDeer.anims.currentAnim !== this.anims.get('NpcDeerWalk_back')) {
                this.NpcDeer.anims.play('NpcDeerWalk_back');
            }
        }
        else if (keyS.isDown) {
            this.NpcDeer.y += 4;
            if (this.NpcDeer.anims.currentAnim !== this.anims.get('NpcDeerWalk_font')) {
                this.NpcDeer.anims.play('NpcDeerWalk_font');
            }
        }
        else if (keyA.isDown) {
            this.NpcDeer.x -= 4;
            if (this.NpcDeer.anims.currentAnim !== this.anims.get('NpcDeerWalk_left')) {
                this.NpcDeer.anims.play('NpcDeerWalk_left');
            }
        }
        else if (keyD.isDown) {
            this.NpcDeer.x += 4;
            if (this.NpcDeer.anims.currentAnim !== this.anims.get('NpcDeerWalk_right')) {
                this.NpcDeer.anims.play('NpcDeerWalk_right');
            }
        }
        else {
            if (this.NpcDeer.anims.currentAnim === this.anims.get('NpcDeerWalk_back')) {
                this.NpcDeer.anims.play('NpcDeerStand_back', true);
            } else if (this.NpcDeer.anims.currentAnim === this.anims.get('NpcDeerWalk_left')) {
                this.NpcDeer.anims.play('NpcDeerStand_left', true);
            } else if (this.NpcDeer.anims.currentAnim === this.anims.get('NpcDeerWalk_right')) {
                this.NpcDeer.anims.play('NpcDeerStand_right', true);
            } else if (this.NpcDeer.anims.currentAnim === this.anims.get('NpcDeerWalk_font')) {
                this.NpcDeer.anims.play('NpcDeerStand_font', true);
            }
        }
    }
    render() {
        this.debug.cameraInfo(this.cameras.main, 32, 32);
    }
}

// const gameScence3C = {
//     key: 'gameScence3C',
//     preload: function () {
//         this.load.image('test', '/img/phaser/test.png');
//         this.load.spritesheet('stand', '/img/phaser/Sprite_stand.png', {
//             frameWidth: 128, frameHeight: 128
//         });
//         this.load.spritesheet('walk', 'img/phaser/Sprite_walk.png', {
//             frameWidth: 128, frameHeight: 128
//         });
//         this.load.spritesheet('NpcDeerStand', 'img/phaser/Rudolph_02_idle (32x32).png', {
//             frameWidth: 32, frameHeight: 32
//         });
//         this.load.spritesheet('NpcDeerWalk', 'img/phaser/Rudolph_02_walk (32x32).png', {
//             frameWidth: 32, frameHeight: 32
//         });

//         this.load.on('complete', function () {
//             this.anims.create({
//                 key: 'NpcDeerStand_font',
//                 frames: this.anims.generateFrameNumbers('NpcDeerStand', { start: 0, end: 3 }),
//                 frameRate: 10,
//                 repeat: -1
//             });
//             this.anims.create({
//                 key: 'NpcDeerStand_left',
//                 frames: this.anims.generateFrameNumbers('NpcDeerStand', { start: 4, end: 7 }),
//                 frameRate: 10,
//                 repeat: -1
//             });
//             this.anims.create({
//                 key: 'NpcDeerStand_right',
//                 frames: this.anims.generateFrameNumbers('NpcDeerStand', { start: 8, end: 11 }),
//                 frameRate: 10,
//                 repeat: -1
//             });
//             this.anims.create({
//                 key: 'NpcDeerStand_back',
//                 frames: this.anims.generateFrameNumbers('NpcDeerStand', { start: 12, end: 15 }),
//                 frameRate: 10,
//                 repeat: -1
//             });
//             this.anims.create({
//                 key: 'NpcDeerWalk_font',
//                 frames: this.anims.generateFrameNumbers('NpcDeerWalk', { start: 0, end: 3 }),
//                 frameRate: 10,
//                 repeat: -1
//             });
//             this.anims.create({
//                 key: 'NpcDeerWalk_left',
//                 frames: this.anims.generateFrameNumbers('NpcDeerWalk', { start: 4, end: 7 }),
//                 frameRate: 10,
//                 repeat: -1
//             });
//             this.anims.create({
//                 key: 'NpcDeerWalk_right',
//                 frames: this.anims.generateFrameNumbers('NpcDeerWalk', { start: 8, end: 11 }),
//                 frameRate: 10,
//                 repeat: -1
//             });
//             this.anims.create({
//                 key: 'NpcDeerWalk_back',
//                 frames: this.anims.generateFrameNumbers('NpcDeerWalk', { start: 12, end: 15 }),
//                 frameRate: 10,
//                 repeat: -1
//             })
//         }.bind(this));
//     },
//     create: function () {
//         const bg = this.add.image(0, 0, 'test').setOrigin(0);
//         this.cameras.main.centerOn(800, 800);
//         this.physics.world.setBounds(0, 0, 1600, 1600);

//         this.player = this.physics.add.sprite(bg.width / 2, bg.height / 2, 'stand');
//         this.player.anims.play('stand_anim', true);
//         this.player.setCollideWorldBounds(true);
//         this.player.setScale(0.25);
//         this.NpcDeer = this.physics.add.sprite(bg.width / 2 + 100, bg.height / 2 + 100, 'NpcDeerStand');
//         this.NpcDeer.anims.play('NpcDeerStand_font', true);
//         this.NpcDeer.setCollideWorldBounds(true);
//         cursors = this.input.keyboard.createCursorKeys();
//         this.cameras.main.startFollow(this.player);
//     },
//     update: function () {
//         var keyW = this.input.keyboard.addKey('W');
//         var keyS = this.input.keyboard.addKey('S');
//         var keyA = this.input.keyboard.addKey('A');
//         var keyD = this.input.keyboard.addKey('D');
//         if (cursors.up.isDown) {
//             this.player.y -= 4;
//             if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
//                 this.player.anims.play('walk_anim');
//             }
//             this.cameras.main.scrollY -= 4;
//         }
//         else if (cursors.down.isDown) {
//             this.player.y += 4;
//             if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
//                 this.player.anims.play('walk_anim');
//             }
//             this.cameras.main.scrollY += 4;
//         }
//         else if (cursors.left.isDown) {
//             this.player.x -= 4;
//             if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
//                 this.player.anims.play('walk_anim');
//             }
//             this.cameras.main.scrollX -= 4;
//             this.player.flipX = true;
//         }
//         else if (cursors.right.isDown) {
//             this.player.x += 4;
//             if (this.player.anims.currentAnim !== this.anims.get('walk_anim')) {
//                 this.player.anims.play('walk_anim');
//             }
//             this.cameras.main.scrollX += 4;
//             this.player.flipX = false;
//         }
//         else {
//             this.player.anims.play('stand_anim', true);
//         }

//         if (keyW.isDown) {
//             this.NpcDeer.y -= 4;
//             if (this.NpcDeer.anims.currentAnim !== this.anims.get('NpcDeerWalk_back')) {
//                 this.NpcDeer.anims.play('NpcDeerWalk_back');
//             }
//         }
//         else if (keyS.isDown) {
//             this.NpcDeer.y += 4;
//             if (this.NpcDeer.anims.currentAnim !== this.anims.get('NpcDeerWalk_font')) {
//                 this.NpcDeer.anims.play('NpcDeerWalk_font');
//             }
//         }
//         else if (keyA.isDown) {
//             this.NpcDeer.x -= 4;
//             if (this.NpcDeer.anims.currentAnim !== this.anims.get('NpcDeerWalk_left')) {
//                 this.NpcDeer.anims.play('NpcDeerWalk_left');
//             }
//         }
//         else if (keyD.isDown) {
//             this.NpcDeer.x += 4;
//             if (this.NpcDeer.anims.currentAnim !== this.anims.get('NpcDeerWalk_right')) {
//                 this.NpcDeer.anims.play('NpcDeerWalk_right');
//             }
//         }
//         else {
//             if (this.NpcDeer.anims.currentAnim === this.anims.get('NpcDeerWalk_back')) {
//                 this.NpcDeer.anims.play('NpcDeerStand_back', true);
//             } else if (this.NpcDeer.anims.currentAnim === this.anims.get('NpcDeerWalk_left')) {
//                 this.NpcDeer.anims.play('NpcDeerStand_left', true);
//             } else if (this.NpcDeer.anims.currentAnim === this.anims.get('NpcDeerWalk_right')) {
//                 this.NpcDeer.anims.play('NpcDeerStand_right', true);
//             } else if (this.NpcDeer.anims.currentAnim === this.anims.get('NpcDeerWalk_font')) {
//                 this.NpcDeer.anims.play('NpcDeerStand_font', true);
//             }
//         }
//     },
//     render: function () {
//         this.debug.cameraInfo(this.cameras.main, 32, 32);
//     }
// };

