using System.IO.MemoryMappedFiles;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using WebSocketSharp.Server;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

public class WebSocketController : Controller
{
    public static MapData maps = new MapData();
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
            maps.MapDirectory["測試服"].client[webSocket].Uid = generateID(); //隨機生產ID 之後從ms sql取
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

    private static async Task Echo(System.Net.WebSockets.WebSocket webSocket)
    {

        var buffer = new byte[1024 * 4];
        //等待接收訊息
        var receiveResult = await webSocket.ReceiveAsync(
             new ArraySegment<byte>(buffer), CancellationToken.None);
        // string jsontemp = Encoding.UTF8.GetString(buffer, 0, receiveResult.Count);
        // Console.WriteLine("New message received : " + receiveResult);
        // clients = JsonSerializer.Deserialize<Clients>(jsontemp);

        //檢查是否為連線狀態
        while (!receiveResult.CloseStatus.HasValue)
        {
            var message = Encoding.UTF8.GetString(buffer, 0, receiveResult.Count);
            var jsontemp = JObject.Parse(message);
            //訊息發到前端
            var type = jsontemp.Value<string>("type");
            var data = jsontemp.GetValue("data");
            switch (type)
            {
                case "Chat":
                    ChatContent Chattemp = new ChatContent { type = "Chat", client = maps.MapDirectory["測試服"].client[webSocket], content = data.Value<string>() };
                    var chatJson = JsonSerializer.Serialize(Chattemp);
                    buffer = Encoding.UTF8.GetBytes(chatJson);
                    maps.MapDirectory["測試服"].ChatContent.Add(Chattemp);
                    Console.WriteLine("Chat");
                    break;
                case "movement":
                    maps.MapDirectory["測試服"].client[webSocket] = data.ToObject<PlayerRef>();
                    Console.WriteLine("message");
                    break;
            }
            foreach (KeyValuePair<WebSocket, PlayerRef> con in maps.MapDirectory["測試服"].client)
            {
                Console.WriteLine(con.Value.Uid);
                if (con.Key.State != System.Net.WebSockets.WebSocketState.Open)
                {
                    continue;
                }
                await con.Key.SendAsync(
               new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
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
            Console.WriteLine(con.Value.Uid);
            if (con.Key.State != System.Net.WebSockets.WebSocketState.Open)
            {
                continue;
            }
            await con.Key.SendAsync(
           new ArraySegment<byte>(dc), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        Console.WriteLine(maps.MapDirectory["測試服"].client[webSocket].Uid + " has discoonected");
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
}

