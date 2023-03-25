public class DiscconnectDTO
{
    //客戶端
    public string type { get; set; } = default!;
    public PlayerRef PlayerRef { get; set; } = default!;
    public string MapData { get; set; } = default!;
    public string Chat { get; set; } = default!;

}