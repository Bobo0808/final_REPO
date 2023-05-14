public class MapData
{
    //地圖名稱對應地圖資料
    public Dictionary<string, MapDirectories> MapDirectory { get; set; } = new Dictionary<string, MapDirectories>()
    {
        {
            //地圖設定
        "測試服", new MapDirectories()
        {
            id = "測試服",
            Src = "./images/map.png",
            MinX = 1,
            MinY = 4,
            MaxX = 14,
            MaxY = 12,
            BlockedSpaces = new List<BlockedSpaces>(){new BlockedSpaces{x=7,y=4},new BlockedSpaces{x=1,y=11},new BlockedSpaces{x=12,y=10},new BlockedSpaces{x=4,y=7},new BlockedSpaces{x=5,y=7},new BlockedSpaces{x=6,y=7},new BlockedSpaces{x=8,y=6},new BlockedSpaces{x=9,y=6},new BlockedSpaces{x=10,y=6},new BlockedSpaces{x=7,y=9},new BlockedSpaces{x=10,y=6},new BlockedSpaces{x=7,y=9},new BlockedSpaces{x=8,y=9},new BlockedSpaces{x=9,y=9}},
        }
        },{
             "小房間", new MapDirectories()
        {
            id = "小房間",
            Src = "./images/map.png",
            MinX = 1,
            MinY = 4,
            MaxX = 14,
            MaxY = 12,
            BlockedSpaces = new List<BlockedSpaces>(){new BlockedSpaces{x=7,y=4},new BlockedSpaces{x=1,y=11},new BlockedSpaces{x=12,y=10},new BlockedSpaces{x=4,y=7},new BlockedSpaces{x=5,y=7},new BlockedSpaces{x=6,y=7},new BlockedSpaces{x=8,y=6},new BlockedSpaces{x=9,y=6},new BlockedSpaces{x=10,y=6},new BlockedSpaces{x=7,y=9},new BlockedSpaces{x=10,y=6},new BlockedSpaces{x=7,y=9},new BlockedSpaces{x=8,y=9},new BlockedSpaces{x=9,y=9}},
        }
        }
    };
}
