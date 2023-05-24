using System;
using System.Net.WebSockets;
public class PlayerRef
{
    //玩家基本資料
    public string type { get; set; } = default!;
    public int id { get; set; } = default!;
    public string name { get; set; } = default!;
    public string direction { get; set; } = default!;
    public string color { get; set; } = default!;
    public int gender { get; set; } = default!;
    public float x { get; set; }
    public float y { get; set; }

}