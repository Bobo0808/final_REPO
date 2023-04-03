using System;
using System.Net.WebSockets;
public class PlayerRef
{
    //玩家基本資料
    public string type { get; set; } = default!;
    public string id { get; set; } = default!;
    public string name { get; set; } = default!;
    public string direction { get; set; } = default!;
    public string color { get; set; } = default!;
    public int x { get; set; }
    public int y { get; set; }

}