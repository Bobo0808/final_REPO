using System.Net.WebSockets;
public class M_Queue
{
    public Queue<WebSocket> Queue = new Queue<WebSocket>(); //存取websocket 從dictionary取playerref
}