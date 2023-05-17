using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using System.Text;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Microsoft.EntityFrameworkCore;
using ClassLibrary;

namespace ChickenLife.Controllers
{

    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class WebSocketController : Controller
    {
        private readonly ChickenDbContext _context;
        public WebSocketController(ChickenDbContext context)
        {
            _context = context;
        }
        public static MapData maps = new MapData();
        public static Queue_F queue_F = new Queue_F();
        public static Queue_M queue_M = new Queue_M();
        public static bool isMale = true;
        public static string publicMap = "測試服";
        string[] playerColors = { "blue", "red", "orange", "yellow", "green", "purple" };




        // WebSocketServer wssv = new WebSocketServer("ws://127.0.0.1:7890");
        [Route("/[controller]")]
        public async Task Get()
        {

            //是否為webSocket請求 如果是則加入等待
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                Console.WriteLine(_context.Products.Count());
                PlayerRef player = new PlayerRef();//生成新玩家
                using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                MapDirectoriesDTO mapDTO = new MapDirectoriesDTO() { type = "Load", id = publicMap, Src = maps.MapDirectory[publicMap].Src, MinX = maps.MapDirectory[publicMap].MinX, MinY = maps.MapDirectory[publicMap].MinY, MaxX = maps.MapDirectory[publicMap].MaxX, MaxY = maps.MapDirectory[publicMap].MaxY, BlockedSpaces = maps.MapDirectory[publicMap].BlockedSpaces, client = maps.MapDirectory[publicMap].client.Values.ToList() };

                var Loadtemp = JsonSerializer.Serialize(mapDTO);
                var Load = Encoding.UTF8.GetBytes(Loadtemp);
                await webSocket.SendAsync(new ArraySegment<byte>(Load), WebSocketMessageType.Text, true, CancellationToken.None);



                maps.MapDirectory[publicMap].client.Add(webSocket, player);
                maps.MapDirectory[publicMap].client[webSocket].type = "Connect";
                maps.MapDirectory[publicMap].client[webSocket].id = generateID(); //隨機生產ID 之後從ms sql取
                if (isMale == true)
                {
                    maps.MapDirectory[publicMap].client[webSocket].gender = 1;
                    isMale = false;
                }
                else if (isMale == false)
                {
                    maps.MapDirectory[publicMap].client[webSocket].gender = 2;
                    isMale = true;
                }
                maps.MapDirectory[publicMap].client[webSocket].name = "Test";
                maps.MapDirectory[publicMap].client[webSocket].direction = "right";
                maps.MapDirectory[publicMap].client[webSocket].color = randomFromArray(playerColors);
                maps.MapDirectory[publicMap].client[webSocket].x = 1;
                maps.MapDirectory[publicMap].client[webSocket].y = 4;

                //Connect並傳送人物初始數據
                Console.WriteLine(maps.MapDirectory[publicMap].client[webSocket].name + " Has Connected");
                var json = JsonSerializer.Serialize(maps.MapDirectory[publicMap].client[webSocket]);
                var buffer = Encoding.UTF8.GetBytes(json);
                foreach (KeyValuePair<WebSocket, PlayerRef> con in maps.MapDirectory[publicMap].client)
                {
                    if (con.Key.State != System.Net.WebSockets.WebSocketState.Open)
                    {
                        continue;
                    }
                    await con.Key.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
                }
                try
                {
                    await Echo(webSocket);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }

            }
            else
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        private static async Task Echo(WebSocket webSocket)
        {
            string id = "";
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
                    // Console.WriteLine(message);
                    var jsontemp = JObject.Parse(message);
                    var type = jsontemp.Value<string>("type");
                    //處理JSON對象
                    //...
                    switch (type)
                    {
                        case "Chat":
                            var data = jsontemp.GetValue("data");
                            id = jsontemp.Value<string>("id");
                            ChatContent Chattemp = new ChatContent { type = "Chat", client = maps.MapDirectory[id].client[webSocket], content = data.Value<string>() };
                            var chatJson = JsonSerializer.Serialize(Chattemp);
                            buffer = Encoding.UTF8.GetBytes(chatJson);
                            maps.MapDirectory[id].ChatContent.Add(Chattemp);
                            SendToAll(buffer, id);
                            break;
                        case "Movement":
                            var dataMovement = JsonSerializer.Deserialize<MovementDTO?>(message);
                            if (dataMovement == null)
                            {
                                break;
                            }
                            id = jsontemp.Value<string>("mapid");
                            MovementDTO temp = new MovementDTO();
                            temp = dataMovement;
                            maps.MapDirectory[id].client[webSocket].direction = temp.data.direction;
                            maps.MapDirectory[id].client[webSocket].x = temp.data.x;
                            maps.MapDirectory[id].client[webSocket].y = temp.data.y;
                            temp.data.id = maps.MapDirectory[id].client[webSocket].id;
                            temp.data.type = "Movement";
                            var movementJson = JsonSerializer.Serialize(temp.data);
                            buffer = Encoding.UTF8.GetBytes(movementJson);
                            SendToAll(buffer, id);
                            break;
                        case "Queue":
                            id = jsontemp.Value<string>("mapid");
                            if (maps.MapDirectory[publicMap].client[webSocket].gender == 1)
                            {
                                queue_M.Queue.Enqueue(new KeyValuePair<WebSocket, PlayerRef>(webSocket, maps.MapDirectory[publicMap].client[webSocket]));
                                if (queue_F.Queue.Count > 0 && queue_M.Queue.Peek().Key.State == System.Net.WebSockets.WebSocketState.Open && queue_F.Queue.Peek().Key.State == System.Net.WebSockets.WebSocketState.Open)
                                {
                                    string PrivateMapid = "小房間";
                                    //把配對方跟小房間丟給client
                                    KeyValuePair<WebSocket, PlayerRef> maletemp = queue_M.Queue.Dequeue();
                                    KeyValuePair<WebSocket, PlayerRef> femaletemp = queue_F.Queue.Dequeue();
                                    maps.MapDirectory[PrivateMapid].client.Add(maletemp.Key, maletemp.Value);
                                    maps.MapDirectory[PrivateMapid].client.Add(femaletemp.Key, femaletemp.Value);
                                    MapDirectoriesDTO pairtemp = new MapDirectoriesDTO() { type = "Match", id = PrivateMapid, Src = maps.MapDirectory[publicMap].Src, MinX = maps.MapDirectory[publicMap].MinX, MinY = maps.MapDirectory[publicMap].MinY, MaxX = maps.MapDirectory[publicMap].MaxX, MaxY = maps.MapDirectory[publicMap].MaxY, BlockedSpaces = maps.MapDirectory[publicMap].BlockedSpaces, client = new List<PlayerRef>() { maletemp.Value, femaletemp.Value } };
                                    var matchJson = JsonSerializer.Serialize(pairtemp);
                                    buffer = Encoding.UTF8.GetBytes(matchJson);
                                    SendToPeer(buffer, maletemp.Key, femaletemp.Key);

                                    //把配對到的人從地圖移除
                                    maps.MapDirectory[publicMap].client.Remove(maletemp.Key);
                                    maps.MapDirectory[publicMap].client.Remove(femaletemp.Key);
                                    for (int i = 0; i < pairtemp.client.Count; i++)
                                    {
                                        DiscconnectDTO dcdto = new DiscconnectDTO();
                                        dcdto.type = "Disconnect";
                                        dcdto.PlayerRef = pairtemp.client[i];
                                        var dcdtotemp = JsonSerializer.Serialize(dcdto);
                                        buffer = Encoding.UTF8.GetBytes(dcdtotemp);
                                        SendToAll(buffer, publicMap);
                                    }

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
                            else if (maps.MapDirectory[publicMap].client[webSocket].gender == 2)
                            {
                                queue_F.Queue.Enqueue(new KeyValuePair<WebSocket, PlayerRef>(webSocket, maps.MapDirectory[publicMap].client[webSocket]));
                                if (queue_M.Queue.Count > 0)
                                {
                                    string PrivateMapid = "小房間";
                                    KeyValuePair<WebSocket, PlayerRef> maletemp = queue_M.Queue.Dequeue();
                                    KeyValuePair<WebSocket, PlayerRef> femaletemp = queue_F.Queue.Dequeue();
                                    maps.MapDirectory[PrivateMapid].client.Add(maletemp.Key, maletemp.Value);
                                    maps.MapDirectory[PrivateMapid].client.Add(femaletemp.Key, femaletemp.Value);
                                    MapDirectoriesDTO pairtemp = new MapDirectoriesDTO() { type = "Match", id = PrivateMapid, Src = maps.MapDirectory[publicMap].Src, MinX = maps.MapDirectory[publicMap].MinX, MinY = maps.MapDirectory[publicMap].MinY, MaxX = maps.MapDirectory[publicMap].MaxX, MaxY = maps.MapDirectory[publicMap].MaxY, BlockedSpaces = maps.MapDirectory[publicMap].BlockedSpaces, client = new List<PlayerRef>() { maletemp.Value, femaletemp.Value } };
                                    var matchJson = JsonSerializer.Serialize(pairtemp);
                                    buffer = Encoding.UTF8.GetBytes(matchJson);
                                    SendToPeer(buffer, maletemp.Key, femaletemp.Key);


                                    maps.MapDirectory[publicMap].client.Remove(maletemp.Key);
                                    maps.MapDirectory[publicMap].client.Remove(femaletemp.Key);
                                    for (int i = 0; i < pairtemp.client.Count; i++)
                                    {
                                        DiscconnectDTO dcdto = new DiscconnectDTO();
                                        dcdto.type = "Disconnect";
                                        dcdto.PlayerRef = pairtemp.client[i];
                                        var dcdtotemp = JsonSerializer.Serialize(dcdto);
                                        buffer = Encoding.UTF8.GetBytes(dcdtotemp);
                                        SendToAll(buffer, publicMap);
                                    }
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
                        case "Description":
                            id = jsontemp.Value<string>("mapid");
                            string descriptiontemp;
                            string candidatetemp;
                            PeerDTO peertemp = new PeerDTO();
                            peertemp.type = "Peer";
                            if (jsontemp["description"].HasValues)
                            {
                                descriptiontemp = jsontemp["description"].ToString();
                                peertemp.description = descriptiontemp;
                            }
                            else if (jsontemp["candidate"].HasValues)
                            {
                                candidatetemp = jsontemp["candidate"].ToString();
                                peertemp.candidate = candidatetemp;
                            }

                            var peerJson = JsonSerializer.Serialize(peertemp);
                            buffer = Encoding.UTF8.GetBytes(peerJson);
                            foreach (var socket in maps.MapDirectory[id].client)
                            {
                                if (socket.Key != webSocket)
                                {
                                    SendToOne(buffer, socket.Key);
                                }
                            }

                            break;
                        case "Leave":
                            id = jsontemp.Value<string>("mapid");

                            MapDirectoriesDTO mapDTO = new MapDirectoriesDTO() { type = "Load", id = publicMap, Src = maps.MapDirectory[publicMap].Src, MinX = maps.MapDirectory[publicMap].MinX, MinY = maps.MapDirectory[publicMap].MinY, MaxX = maps.MapDirectory[publicMap].MaxX, MaxY = maps.MapDirectory[publicMap].MaxY, BlockedSpaces = maps.MapDirectory[publicMap].BlockedSpaces, client = maps.MapDirectory[publicMap].client.Values.ToList() };
                            var Loadtemp = JsonSerializer.Serialize(mapDTO);
                            var Load = Encoding.UTF8.GetBytes(Loadtemp);
                            await webSocket.SendAsync(new ArraySegment<byte>(Load), WebSocketMessageType.Text, true, CancellationToken.None);


                            maps.MapDirectory[publicMap].client.Add(webSocket, maps.MapDirectory[id].client[webSocket]);
                            maps.MapDirectory[id].client.Remove(webSocket);
                            // if (maps.MapDirectory[id].client.Count < 1)
                            // {
                            //     maps.MapDirectory.Remove(id);
                            // }
                            maps.MapDirectory[publicMap].client[webSocket].type = "Connect";
                            var leavetemp = JsonSerializer.Serialize(maps.MapDirectory[publicMap].client[webSocket]);
                            buffer = Encoding.UTF8.GetBytes(leavetemp);
                            SendToAll(buffer, publicMap);


                            DiscconnectDTO leavedto = new DiscconnectDTO();
                            leavedto.type = "Disconnect";
                            leavedto.PlayerRef = maps.MapDirectory[publicMap].client[webSocket];
                            leavetemp = JsonSerializer.Serialize(leavedto);
                            buffer = Encoding.UTF8.GetBytes(leavetemp);
                            SendToAll(buffer, id);
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
            Disconnect.PlayerRef = maps.MapDirectory[id].client[webSocket];
            var dctemp = JsonSerializer.Serialize(Disconnect);
            var dc = Encoding.UTF8.GetBytes(dctemp);
            foreach (string map in maps.MapDirectory.Keys)
            {
                foreach (var con in maps.MapDirectory[map].client)
                {
                    if (con.Key.State != System.Net.WebSockets.WebSocketState.Open)
                    {
                        Console.WriteLine(con.Value.id + " has discoonected");
                        maps.MapDirectory[map].client.Remove(con.Key);
                        continue;
                    }
                    await con.Key.SendAsync(
                   new ArraySegment<byte>(dc), WebSocketMessageType.Text, true, CancellationToken.None);
                }
            }
            await webSocket.CloseAsync(
                receiveResult.CloseStatus.Value,
                receiveResult.CloseStatusDescription, CancellationToken.None);


        }
        public static string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        public string randomFromArray(string[] arr)
        {
            Random rdm = new Random();
            int temp = rdm.Next(0, arr.Length);
            return arr[temp];
        }

        public static async void SendToAll(byte[] buffer, string id)
        {
            foreach (KeyValuePair<WebSocket, PlayerRef> con in maps.MapDirectory[id].client)
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


}
