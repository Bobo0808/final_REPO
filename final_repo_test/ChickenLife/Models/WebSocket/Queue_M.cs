using System.Net.WebSockets;
public class Queue_M
{
    public List<KeyValuePair<WebSocket, PlayerRef>> Queue { get; set; } = new List<KeyValuePair<WebSocket, PlayerRef>>();
}