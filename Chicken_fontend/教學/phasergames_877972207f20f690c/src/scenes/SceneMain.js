/*jshint esversion: 6 */
import Align from "../util/Align";
import { AlignGrid } from "../util/alignGrid";
import { UIBlock } from "../util/UIBlock";

export class SceneMain extends Phaser.Scene {
    constructor() {
        super("SceneMain");
    }
    preload() {
      this.load.image("tiles","src/assets/tiles.png");
      this.load.image("face","src/assets/face.png");
      this.load.tilemapTiledJSON('map',"src/assets/map1.json");
    }
    create() {         

      /*   const array=[[0,1,2,22],
                     [17,18,19],
                     [34,35,36]];
        const map = this.make.tilemap({ data:array, tileWidth: 64, tileHeight: 64});
        map.addTilesetImage("tiles");
        const layer = map.createLayer(0, "tiles", 0, 0); */
        const map = this.make.tilemap({ key: "map", tileWidth: 64, tileHeight: 64});
        const tileset = map.addTilesetImage("tiles1","tiles");
        const layer = map.createLayer("ground", tileset, 0, 0);
        const cactusLayer = map.createLayer("cactus", tileset, 0, 0);
        const hillLayer = map.createLayer("hills", tileset, 0, 0);

        this.player=this.physics.add.sprite(100,100,"face");
        
        Align.scaleToGameW(this.player,0.08,this);

        this.cursors=this.input.keyboard.createCursorKeys();

        cactusLayer.setCollisionBetween(38,56);
        hillLayer.setCollisionBetween(5,41);

        this.physics.add.collider(this.player,cactusLayer);
        this.physics.add.collider(this.player,hillLayer);


       
    }
    
    update() {
         this.player.setVelocityY(0);
         this.player.setVelocityX(0);

        if (this.cursors.up.isDown==true)
        {
          this.player.setVelocityY(-100);
        }
        if (this.cursors.down.isDown==true)
        {
          this.player.setVelocityY(100);
        }
         if (this.cursors.right.isDown==true)
        {
          this.player.setVelocityX(100);
        }
        if (this.cursors.left.isDown==true)
        {
          this.player.setVelocityX(-100);
        }
    }
}
export default SceneMain;