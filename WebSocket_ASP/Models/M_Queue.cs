using System.Net.WebSockets;
public class M_Queue
{
    public Queue<KeyValuePair<WebSocket, string>> Queue = new Queue<KeyValuePair<WebSocket, string>>(); //存取websocket 從dictionary取playerref
}
