using System.Net.WebSockets;
public class MapDirectories
{
    //地圖詳細資料
    public string Src { get; set; } = default!;
    public string id { get; set; } = default!;
    public int MinX { get; set; }
    public int MinY { get; set; }
    public int MaxX { get; set; }
    public int MaxY { get; set; }
    public List<BlockedSpaces> BlockedSpaces { get; set; } = new List<BlockedSpaces>();
    public Dictionary<WebSocket, PlayerRef> client { get; set; } = new Dictionary<WebSocket, PlayerRef>();
    public List<ChatContent> ChatContent { get; set; } = new List<ChatContent>();
}