using System.Net.WebSockets;
public class Queue_M
{
    public Queue<KeyValuePair<WebSocket, PlayerRef>> Queue { get; set; } = new Queue<KeyValuePair<WebSocket, PlayerRef>>();
}