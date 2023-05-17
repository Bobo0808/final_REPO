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
        const layer = map.createLayer("toplayer", tileset, 0, 0);
        
    }
    update() {

    }
}
export default SceneMain;