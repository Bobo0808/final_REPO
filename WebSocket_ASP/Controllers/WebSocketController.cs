using System.Runtime.Serialization.Formatters.Binary;
using System.IO.MemoryMappedFiles;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using WebSocketSharp.Server;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

public class WebSocketController : Controller
{
    public static MapData maps = new MapData();
    public static Queue_F queue_F = new Queue_F();
    public static Queue_M queue_M = new Queue_M();
    public static bool isMale = true;
    string[] playerColors = { "blue", "red", "orange", "yellow", "green", "purple" };



    WebSocketServer wssv = new WebSocketServer("ws://127.0.0.1:7890");
    [Route("/ws")]
    public async Task Get()
    {

        //是否為webSocket請求 如果是則加入等待
        if (HttpContext.WebSockets.IsWebSocketRequest)
        {
            PlayerRef player = new PlayerRef();//生成新玩家
            using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
            MapDirectoriesDTO mapDTO = new MapDirectoriesDTO() { type = "Load", Src = maps.MapDirectory["測試服"].Src, MinX = maps.MapDirectory["測試服"].MinX, MinY = maps.MapDirectory["測試服"].MinY, MaxX = maps.MapDirectory["測試服"].MaxX, MaxY = maps.MapDirectory["測試服"].MaxY, BlockedSpaces = maps.MapDirectory["測試服"].BlockedSpaces, client = maps.MapDirectory["測試服"].client.Values.ToList() };

            var Loadtemp = JsonSerializer.Serialize(mapDTO);
            var Load = Encoding.UTF8.GetBytes(Loadtemp);
            await webSocket.SendAsync(new ArraySegment<byte>(Load), WebSocketMessageType.Text, true, CancellationToken.None);



            maps.MapDirectory["測試服"].client.Add(webSocket, player);
            maps.MapDirectory["測試服"].client[webSocket].type = "Connect";
            maps.MapDirectory["測試服"].client[webSocket].id = generateID(); //隨機生產ID 之後從ms sql取
            if (isMale == true)
            {
                maps.MapDirectory["測試服"].client[webSocket].gender = 1;
                isMale = false;
            }
            else if (isMale == false)
            {
                maps.MapDirectory["測試服"].client[webSocket].gender = 2;
                isMale = true;
            }
            maps.MapDirectory["測試服"].client[webSocket].name = "Test";
            maps.MapDirectory["測試服"].client[webSocket].direction = "right";
            maps.MapDirectory["測試服"].client[webSocket].color = randomFromArray(playerColors);
            maps.MapDirectory["測試服"].client[webSocket].x = 1;
            maps.MapDirectory["測試服"].client[webSocket].y = 4;

            //Connect並傳送人物初始數據
            Console.WriteLine(maps.MapDirectory["測試服"].client[webSocket].name + " Has Connected");
            var json = JsonSerializer.Serialize(maps.MapDirectory["測試服"].client[webSocket]);
            var buffer = Encoding.UTF8.GetBytes(json);
            foreach (KeyValuePair<WebSocket, PlayerRef> con in maps.MapDirectory["測試服"].client)
            {
                if (con.Key.State != System.Net.WebSockets.WebSocketState.Open)
                {
                    continue;
                }
                await con.Key.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            }
            await Echo(webSocket);
        }
        else
        {
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
    }

    private static async Task Echo(WebSocket webSocket)
    {
        var buffer = new byte[1024 * 4];
        //等待接收訊息
        var receiveBuffer = new List<byte>();
        var receiveResult = await webSocket.ReceiveAsync(
             new ArraySegment<byte>(buffer), CancellationToken.None);
        //檢查是否為連線狀態
        while (!receiveResult.CloseStatus.HasValue)
        {
            receiveBuffer.AddRange(buffer.Take(receiveResult.Count));
            if (receiveResult.EndOfMessage)
            {
                //如果收到了完整的消息，則解析JSON對象
                var message = Encoding.UTF8.GetString(receiveBuffer.ToArray());
                Console.WriteLine(message);
                var jsontemp = JObject.Parse(message);
                var type = jsontemp.Value<string>("type");
                //處理JSON對象
                //...
                switch (type)
                {
                    case "Chat":
                        var data = jsontemp.GetValue("data");
                        ChatContent Chattemp = new ChatContent { type = "Chat", client = maps.MapDirectory["測試服"].client[webSocket], content = data.Value<string>() };
                        var chatJson = JsonSerializer.Serialize(Chattemp);
                        buffer = Encoding.UTF8.GetBytes(chatJson);
                        maps.MapDirectory["測試服"].ChatContent.Add(Chattemp);
                        Console.WriteLine("Chat");
                        SendToAll(buffer);
                        break;
                    case "Movement":
                        var dataMovement = JsonSerializer.Deserialize<MovementDTO?>(message);
                        if (dataMovement == null)
                        {
                            break;
                        }
                        MovementDTO temp = new MovementDTO();
                        temp = dataMovement;
                        maps.MapDirectory["測試服"].client[webSocket].direction = temp.data.direction;
                        maps.MapDirectory["測試服"].client[webSocket].x = temp.data.x;
                        maps.MapDirectory["測試服"].client[webSocket].y = temp.data.y;
                        temp.data.id = maps.MapDirectory["測試服"].client[webSocket].id;
                        temp.data.type = "Movement";
                        var movementJson = JsonSerializer.Serialize(temp.data);
                        Console.WriteLine("movement: " + movementJson);
                        buffer = Encoding.UTF8.GetBytes(movementJson);
                        SendToAll(buffer);
                        break;
                    case "Queue":
                        var dataQueue = jsontemp.GetValue("data").ToString();
                        if (maps.MapDirectory["測試服"].client[webSocket].gender == 1)
                        {
                            queue_M.Queue.Enqueue(new KeyValuePair<WebSocket, string>(webSocket, dataQueue));
                            Console.WriteLine("Male");
                            if (queue_F.Queue.Count > 0 && queue_M.Queue.Peek().Key.State == System.Net.WebSockets.WebSocketState.Open && queue_F.Queue.Peek().Key.State == System.Net.WebSockets.WebSocketState.Open)
                            {
                                pairDTO pairtemp = new pairDTO();
                                KeyValuePair<WebSocket, string> maletemp = queue_M.Queue.Dequeue();
                                KeyValuePair<WebSocket, string> femaletemp = queue_F.Queue.Dequeue();
                                pairtemp.type = "Match";
                                pairtemp.data.Add(maletemp.Value);
                                pairtemp.data.Add(femaletemp.Value);
                                var matchJson = JsonSerializer.Serialize(pairtemp);
                                buffer = Encoding.UTF8.GetBytes(matchJson);
                                SendToPeer(buffer, maletemp.Key, femaletemp.Key);
                            }
                            else if (queue_F.Queue.Count > 0 && queue_F.Queue.Peek().Key.State != System.Net.WebSockets.WebSocketState.Open)
                            {
                                queue_F.Queue.Dequeue();
                                WaitDTO waittemp = new WaitDTO();
                                waittemp.type = "Wait";
                                var waitJson = JsonSerializer.Serialize(waittemp);
                                buffer = Encoding.UTF8.GetBytes(waitJson);
                                SendToOne(buffer, webSocket);
                            }
                            else if (queue_F.Queue.Count == 0)
                            {
                                WaitDTO waittemp = new WaitDTO();
                                waittemp.type = "Wait";
                                var waitJson = JsonSerializer.Serialize(waittemp);
                                buffer = Encoding.UTF8.GetBytes(waitJson);
                                SendToOne(buffer, webSocket);
                            }
                        }
                        else if (maps.MapDirectory["測試服"].client[webSocket].gender == 2)
                        {
                            queue_F.Queue.Enqueue(new KeyValuePair<WebSocket, string>(webSocket, dataQueue));
                            Console.WriteLine("FeMale");
                            if (queue_M.Queue.Count > 0)
                            {
                                pairDTO pairtemp = new pairDTO();
                                KeyValuePair<WebSocket, string> maletemp = queue_M.Queue.Dequeue();
                                KeyValuePair<WebSocket, string> femaletemp = queue_F.Queue.Dequeue();
                                pairtemp.type = "Match";
                                pairtemp.data.Add(maletemp.Value);
                                pairtemp.data.Add(femaletemp.Value);
                                var matchJson = JsonSerializer.Serialize(pairtemp);
                                buffer = Encoding.UTF8.GetBytes(matchJson);
                                SendToPeer(buffer, maletemp.Key, femaletemp.Key);
                            }
                            else if (queue_M.Queue.Count > 0 && queue_M.Queue.Peek().Key.State != System.Net.WebSockets.WebSocketState.Open)
                            {
                                queue_M.Queue.Dequeue();
                                WaitDTO waittemp = new WaitDTO();
                                waittemp.type = "Wait";
                                var waitJson = JsonSerializer.Serialize(waittemp);
                                buffer = Encoding.UTF8.GetBytes(waitJson);
                                SendToOne(buffer, webSocket);
                            }
                            else if (queue_M.Queue.Count == 0)
                            {
                                WaitDTO waittemp = new WaitDTO();
                                waittemp.type = "Wait";
                                var waitJson = JsonSerializer.Serialize(waittemp);
                                buffer = Encoding.UTF8.GetBytes(waitJson);
                                SendToOne(buffer, webSocket);
                            }
                        }
                        break;
                }
                //清空緩存區
                receiveBuffer.Clear();
            }







            //繼續等待接收訊息
            receiveResult = await webSocket.ReceiveAsync(
                new ArraySegment<byte>(buffer), CancellationToken.None);

        }
        //關閉連線
        DiscconnectDTO Disconnect = new DiscconnectDTO();
        Disconnect.type = "Disconnect";
        Disconnect.PlayerRef = maps.MapDirectory["測試服"].client[webSocket];
        var dctemp = JsonSerializer.Serialize(Disconnect);
        var dc = Encoding.UTF8.GetBytes(dctemp);
        foreach (KeyValuePair<WebSocket, PlayerRef> con in maps.MapDirectory["測試服"].client)
        {
            if (con.Key.State != System.Net.WebSockets.WebSocketState.Open)
            {
                continue;
            }
            await con.Key.SendAsync(
           new ArraySegment<byte>(dc), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        Console.WriteLine(maps.MapDirectory["測試服"].client[webSocket].id + " has discoonected");
        maps.MapDirectory["測試服"].client.Remove(webSocket);
        await webSocket.CloseAsync(
            receiveResult.CloseStatus.Value,
            receiveResult.CloseStatusDescription, CancellationToken.None);


    }
    public string generateID()
    {
        return Guid.NewGuid().ToString("N");
    }

    public string randomFromArray(string[] arr)
    {
        Random rdm = new Random();
        int temp = rdm.Next(0, arr.Length);
        return arr[temp];
    }

    public static async void SendToAll(byte[] buffer)
    {
        foreach (KeyValuePair<WebSocket, PlayerRef> con in maps.MapDirectory["測試服"].client)
        {
            if (con.Key.State != System.Net.WebSockets.WebSocketState.Open)
            {
                continue;
            }
            await con.Key.SendAsync(
           new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }

    public static async void SendToPeer(byte[] buffer, WebSocket maleSocket, WebSocket femaleSocket)
    {
        await maleSocket.SendAsync(
           new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        await femaleSocket.SendAsync(
        new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
    }

    public static async void SendToOne(byte[] buffer, WebSocket webSocket)
    {
        await webSocket.SendAsync(
           new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
    }
}

