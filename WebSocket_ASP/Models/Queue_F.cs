using System.Net.WebSockets;

public class Queue_F
{
    public Queue<KeyValuePair<WebSocket, string>> Queue { get; set; } = new Queue<KeyValuePair<WebSocket, string>>();

}