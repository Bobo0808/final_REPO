public class ChatContent
{
    public string type { get; set; } = default!;
    //對話紀錄
    public PlayerRef client { get; set; } = default!;
    public string content { get; set; } = default!;
}