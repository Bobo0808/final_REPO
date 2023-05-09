using System.Net.WebSockets;

public class Queue_F
{
    public KeyValuePair<WebSocket, PlayerRef> Queue { get; set; } = new KeyValuePair<WebSocket, PlayerRef>();

}