using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using System.Text;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;
using ClassLibrary;
using System.Numerics;
using ClassLibrary.Models;

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
        public static string[] playerColors = { "blue", "red", "orange", "yellow", "green", "purple" };
        public static int idtemp = 0;

        // WebSocketServer wssv = new WebSocketServer("ws://127.0.0.1:7890");
        [Route("/[controller]")]
        public async Task Get()
        {
            //是否為webSocket請求 如果是則加入等待
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                MapDirectoriesDTO mapDTO = new MapDirectoriesDTO() { type = "Load", id = publicMap, Src = maps.MapDirectory[publicMap].Src, MinX = maps.MapDirectory[publicMap].MinX, MinY = maps.MapDirectory[publicMap].MinY, MaxX = maps.MapDirectory[publicMap].MaxX, MaxY = maps.MapDirectory[publicMap].MaxY, BlockedSpaces = maps.MapDirectory[publicMap].BlockedSpaces, client = maps.MapDirectory[publicMap].client.Values.ToList() };

                var Loadtemp = JsonSerializer.Serialize(mapDTO);
                var Load = Encoding.UTF8.GetBytes(Loadtemp);
                await webSocket.SendAsync(new ArraySegment<byte>(Load), WebSocketMessageType.Text, true, CancellationToken.None);
                try
                {
                    await Echo(webSocket, _context);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        private static async Task Echo(WebSocket webSocket, ChickenDbContext _context)
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
                    //Console.WriteLine(message);
                    var jsontemp = JObject.Parse(message);
                    var type = jsontemp.Value<string>("type");
                    //處理JSON對象
                    //...
                    switch (type)
                    {
                        case "Connect":
                            try
                            {
                                int userid = jsontemp.Value<int>("id");
                                PlayerRef player = new PlayerRef();//生成新玩家
                                maps.MapDirectory[publicMap].client.Add(webSocket, player);
                                maps.MapDirectory[publicMap].client[webSocket].type = "Connect";
                                maps.MapDirectory[publicMap].client[webSocket].id = userid;
                                var user = _context.Accounts.Where(a=>a.A_ID == userid).FirstOrDefault();
                                /*  maps.MapDirectory[publicMap].client[webSocket].id = generateID();*/ //隨機生產ID 之後從ms sql取
                                 maps.MapDirectory[publicMap].client[webSocket].gender = (int)user.A_Gender;
                                maps.MapDirectory[publicMap].client[webSocket].name = user.A_NickName; //姓名
                                maps.MapDirectory[publicMap].client[webSocket].direction = "right"; //角色方向
                                maps.MapDirectory[publicMap].client[webSocket].color = randomFromArray(playerColors); //角色顏色or外觀
                                maps.MapDirectory[publicMap].client[webSocket].x = 9728; //x
                                maps.MapDirectory[publicMap].client[webSocket].y = 6912; //y

                                //Connect並傳送人物初始數據
                                Console.WriteLine(maps.MapDirectory[publicMap].client[webSocket].name + " Has Connected");
                                var connectJson = JsonSerializer.Serialize(maps.MapDirectory[publicMap].client[webSocket]);
                                buffer = Encoding.UTF8.GetBytes(connectJson);
                                SendToAll(buffer, publicMap);
                            }
                            catch (Exception ex)
                            {
                                DebugLog debugLogtemp = new DebugLog()
                                {
                                    A_ID = maps.MapDirectory[publicMap].client[webSocket].id,
                                    D_time = DateTime.Now,
                                    D_event = ex.ToString(),
                                    D_isSolved = false,
                                };
                                await _context.AddAsync(debugLogtemp);
                                await _context.SaveChangesAsync();
                            }
                            break;

                        case "Chat":
                            try
                            {
                                var data = jsontemp.GetValue("data");
                                id = jsontemp.Value<string>("id");
                                ChatContent Chattemp = new ChatContent { type = "Chat", client = maps.MapDirectory[id].client[webSocket], content = data.Value<string>() };
                                var chatJson = JsonSerializer.Serialize(Chattemp);
                                buffer = Encoding.UTF8.GetBytes(chatJson);
                                maps.MapDirectory[id].ChatContent.Add(Chattemp);
                                SendToAll(buffer, id);
                            }
                            catch (Exception ex)
                            {
                                DebugLog debugLogtemp = new DebugLog()
                                {
                                    A_ID = maps.MapDirectory[id].client[webSocket].id,
                                    D_time = DateTime.Now,
                                    D_event = ex.ToString(),
                                    D_isSolved = false,
                                };
                                await _context.AddAsync(debugLogtemp);
                                await _context.SaveChangesAsync();
                            }

                            break;

                        case "Movement":
                            try
                            {
                                var dataMovement = JsonSerializer.Deserialize<MovementDTO?>(message);
                                if (dataMovement == null)
                                {
                                    break;
                                }
                                id = jsontemp.Value<string>("mapid");
                                MovementDTO _temp = new MovementDTO();
                                _temp = dataMovement;
                                maps.MapDirectory[id].client[webSocket].direction = _temp.data.direction;
                                maps.MapDirectory[id].client[webSocket].x = _temp.data.x;
                                maps.MapDirectory[id].client[webSocket].y = _temp.data.y;
                                _temp.data.id = maps.MapDirectory[id].client[webSocket].id;
                                _temp.data.type = "Movement";
                                var movementJson = JsonSerializer.Serialize(_temp.data);
                                buffer = Encoding.UTF8.GetBytes(movementJson);
                                SendToAll(buffer, id);
                            }
                            catch (Exception ex)
                            {
                                //DebugLog debugLogtemp = new DebugLog()
                                //{
                                //    A_ID = maps.MapDirectory[id].client[webSocket].id,
                                //    D_time = DateTime.Now,
                                //    D_event = ex.ToString(),
                                //    D_isSolved = false,
                                //};
                                //await _context.AddAsync(debugLogtemp);
                                //await _context.SaveChangesAsync();
                                //throw;
                            }

                            break;

                        case "Queue":
                            try
                            {
                                id = jsontemp.Value<string>("mapid");
                                if (maps.MapDirectory[id].client[webSocket].gender == 0)
                                {
                                    queue_M.Queue.Add(new KeyValuePair<WebSocket, PlayerRef>(webSocket, maps.MapDirectory[publicMap].client[webSocket]));
                                    if (queue_F.Queue.Count > 0 && queue_M.Queue.First().Key.State == WebSocketState.Open && queue_F.Queue.First().Key.State == WebSocketState.Open)
                                    {
                                        KeyValuePair<WebSocket, PlayerRef> maletemp = queue_M.Queue.First();
                                        KeyValuePair<WebSocket, PlayerRef> femaletemp = queue_F.Queue.First();
                                        PlayerRef malevalue = new PlayerRef()
                                        {
                                            type = maletemp.Value.type,
                                            id = maletemp.Value.id,
                                            name = maletemp.Value.name,
                                            direction = maletemp.Value.direction,
                                            color = maletemp.Value.color,
                                            gender = maletemp.Value.gender,
                                            x = 8795,
                                            y = 10810,
                                        };

                                        PlayerRef femalevalue = new PlayerRef()
                                        {
                                            type = femaletemp.Value.type,
                                            id = femaletemp.Value.id,
                                            name = femaletemp.Value.name,
                                            direction = femaletemp.Value.direction,
                                            color = femaletemp.Value.color,
                                            gender = femaletemp.Value.gender,
                                            x = 8735,
                                            y = 10810
                                        };
                                        string PrivateMapid = malevalue.name;
                                        maps.MapDirectory.Add(PrivateMapid, new MapDirectories()
                                        {
                                            id = "小房間",
                                            Src = "./images/map.png",
                                            MinX = 1,
                                            MinY = 4,
                                            MaxX = 14,
                                            MaxY = 12,
                                            BlockedSpaces = new List<BlockedSpaces>() { new BlockedSpaces { x = 7, y = 4 }, new BlockedSpaces { x = 1, y = 11 }, new BlockedSpaces { x = 12, y = 10 }, new BlockedSpaces { x = 4, y = 7 }, new BlockedSpaces { x = 5, y = 7 }, new BlockedSpaces { x = 6, y = 7 }, new BlockedSpaces { x = 8, y = 6 }, new BlockedSpaces { x = 9, y = 6 }, new BlockedSpaces { x = 10, y = 6 }, new BlockedSpaces { x = 7, y = 9 }, new BlockedSpaces { x = 10, y = 6 }, new BlockedSpaces { x = 7, y = 9 }, new BlockedSpaces { x = 8, y = 9 }, new BlockedSpaces { x = 9, y = 9 } },
                                        }
                                        );
                                        //把配對方跟小房間丟給client
  
                                        queue_M.Queue.RemoveAt(0);
                                        queue_F.Queue.RemoveAt(0);

                                        

                                        maps.MapDirectory[PrivateMapid].client.Add(maletemp.Key, malevalue);
                                        maps.MapDirectory[PrivateMapid].client.Add(femaletemp.Key, femalevalue);
                                        MapDirectoriesDTO pairtemp = new MapDirectoriesDTO()
                                        {
                                            type = "Match",
                                            id = PrivateMapid,
                                            Src = maps.MapDirectory[publicMap].Src,
                                            MinX = maps.MapDirectory[publicMap].MinX,
                                            MinY = maps.MapDirectory[publicMap].MinY,
                                            MaxX = maps.MapDirectory[publicMap].MaxX,
                                            MaxY = maps.MapDirectory[publicMap].MaxY,
                                            BlockedSpaces = maps.MapDirectory[publicMap].BlockedSpaces,
                                            client = new List<PlayerRef>() { malevalue, femalevalue }
                                        };
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
                                    else if (queue_F.Queue.Count > 0 && queue_F.Queue.First().Key.State != System.Net.WebSockets.WebSocketState.Open)
                                    {
                                        queue_F.Queue.RemoveAt(0);
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
                                else if (maps.MapDirectory[id].client[webSocket].gender == 1)
                                {
                                    queue_F.Queue.Add(new KeyValuePair<WebSocket, PlayerRef>(webSocket, maps.MapDirectory[publicMap].client[webSocket]));
                                    if (queue_M.Queue.Count > 0)
                                    {
                                        KeyValuePair<WebSocket, PlayerRef> maletemp = queue_M.Queue.First();
                                        KeyValuePair<WebSocket, PlayerRef> femaletemp = queue_F.Queue.First();
                                        queue_M.Queue.RemoveAt(0);
                                        queue_F.Queue.RemoveAt(0);
                                        PlayerRef malevalue = new PlayerRef()
                                        {
                                            type = maletemp.Value.type,
                                            id = maletemp.Value.id,
                                            name = maletemp.Value.name,
                                            direction = maletemp.Value.direction,
                                            color = maletemp.Value.color,
                                            gender = maletemp.Value.gender,
                                            x = 8795,
                                            y = 10810,
                                        };
                                        PlayerRef femalevalue = new PlayerRef()
                                        {
                                            type = femaletemp.Value.type,
                                            id = femaletemp.Value.id,
                                            name = femaletemp.Value.name,
                                            direction = femaletemp.Value.direction,
                                            color = femaletemp.Value.color,
                                            gender = femaletemp.Value.gender,
                                            x = 8735,
                                            y = 10810
                                        };

                                        string PrivateMapid = femalevalue.name;
                                        maps.MapDirectory[PrivateMapid].client.Add(maletemp.Key, malevalue);
                                        maps.MapDirectory[PrivateMapid].client.Add(femaletemp.Key, femalevalue);
                                        maps.MapDirectory.Add(PrivateMapid, new MapDirectories()
                                        {
                                            id = "小房間",
                                            Src = "./images/map.png",
                                            MinX = 1,
                                            MinY = 4,
                                            MaxX = 14,
                                            MaxY = 12,
                                            BlockedSpaces = new List<BlockedSpaces>() { new BlockedSpaces { x = 7, y = 4 }, new BlockedSpaces { x = 1, y = 11 }, new BlockedSpaces { x = 12, y = 10 }, new BlockedSpaces { x = 4, y = 7 }, new BlockedSpaces { x = 5, y = 7 }, new BlockedSpaces { x = 6, y = 7 }, new BlockedSpaces { x = 8, y = 6 }, new BlockedSpaces { x = 9, y = 6 }, new BlockedSpaces { x = 10, y = 6 }, new BlockedSpaces { x = 7, y = 9 }, new BlockedSpaces { x = 10, y = 6 }, new BlockedSpaces { x = 7, y = 9 }, new BlockedSpaces { x = 8, y = 9 }, new BlockedSpaces { x = 9, y = 9 } },
                                        }
                                        );

                                        

                                        MapDirectoriesDTO pairtemp = new MapDirectoriesDTO() { type = "Match", id = PrivateMapid, Src = maps.MapDirectory[publicMap].Src, MinX = maps.MapDirectory[publicMap].MinX, MinY = maps.MapDirectory[publicMap].MinY, MaxX = maps.MapDirectory[publicMap].MaxX, MaxY = maps.MapDirectory[publicMap].MaxY, BlockedSpaces = maps.MapDirectory[publicMap].BlockedSpaces, client = new List<PlayerRef>() { malevalue, femalevalue } };
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
                                    else if (queue_M.Queue.Count > 0 && queue_M.Queue.First().Key.State != System.Net.WebSockets.WebSocketState.Open)
                                    {
                                        queue_M.Queue.RemoveAt(0);
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
                            }
                            catch (Exception ex)
                            {
                                DebugLog debugLogtemp = new DebugLog()
                                {
                                    A_ID = maps.MapDirectory[id].client[webSocket].id,
                                    D_time = DateTime.Now,
                                    D_event = ex.ToString(),
                                    D_isSolved = false,
                                };
                                await _context.AddAsync(debugLogtemp);
                                await _context.SaveChangesAsync();
                            }

                            break;

                        case "Description":
                            try
                            {
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
                            }
                            catch (Exception ex)
                            {
                                DebugLog debugLogtemp = new DebugLog()
                                {
                                    A_ID = maps.MapDirectory[id].client[webSocket].id,
                                    D_time = DateTime.Now,
                                    D_event = ex.ToString(),
                                    D_isSolved = false,
                                };
                                await _context.AddAsync(debugLogtemp);
                                await _context.SaveChangesAsync();
                            }

                            break;

                        case "Leave":

                            try
                            {
                                id = jsontemp.Value<string>("mapid");
                                MapDirectoriesDTO mapDTO = new MapDirectoriesDTO() { type = "Load", id = publicMap, Src = maps.MapDirectory[publicMap].Src, MinX = maps.MapDirectory[publicMap].MinX, MinY = maps.MapDirectory[publicMap].MinY, MaxX = maps.MapDirectory[publicMap].MaxX, MaxY = maps.MapDirectory[publicMap].MaxY, BlockedSpaces = maps.MapDirectory[publicMap].BlockedSpaces, client = maps.MapDirectory[publicMap].client.Values.ToList() };
                                var Loadtemp = JsonSerializer.Serialize(mapDTO);
                                var Load = Encoding.UTF8.GetBytes(Loadtemp);
                                await webSocket.SendAsync(new ArraySegment<byte>(Load), WebSocketMessageType.Text, true, CancellationToken.None);

                                PlayerRef leaveplayer = new PlayerRef()
                                {
                                    type = maps.MapDirectory[id].client[webSocket].type,
                                    id = maps.MapDirectory[id].client[webSocket].id,
                                    name = maps.MapDirectory[id].client[webSocket].name,
                                    direction = maps.MapDirectory[id].client[webSocket].direction,
                                    color = maps.MapDirectory[id].client[webSocket].color,
                                    gender = maps.MapDirectory[id].client[webSocket].gender,
                                    x = 9728,
                                    y = 6912
                                };
                                maps.MapDirectory[publicMap].client.Add(webSocket, leaveplayer);
                                maps.MapDirectory[id].client.Remove(webSocket);

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
                                if (maps.MapDirectory[id].client.Count < 1)
                                {
                                    maps.MapDirectory.Remove(id);
                                }
                            }
                            catch (Exception ex)
                            {
                                DebugLog debugLogtemp = new DebugLog()
                                {
                                    A_ID = maps.MapDirectory[id].client[webSocket].id,
                                    D_time = DateTime.Now,
                                    D_event = ex.ToString(),
                                    D_isSolved = false,
                                };
                                await _context.AddAsync(debugLogtemp);
                                await _context.SaveChangesAsync();
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
            try
            {
                foreach (string map in maps.MapDirectory.Keys)
                {
                    foreach (var con in maps.MapDirectory[map].client)
                    {
                        if (con.Key.State != System.Net.WebSockets.WebSocketState.Open)
                        {
                            DiscconnectDTO Disconnect = new DiscconnectDTO();
                            Disconnect.type = "Disconnect";
                            Console.WriteLine(con.Value.id + " has discoonected");

                            if (con.Value.gender == 0)
                            {
                                queue_M.Queue.Remove(con);
                            }
                            else if (con.Value.gender == 1)
                            {
                                queue_F.Queue.Remove(con);
                            }
                            maps.MapDirectory[map].client.Remove(con.Key);
                            Disconnect.PlayerRef = con.Value;
                            if (maps.MapDirectory[map].client.Count < 1 && map != publicMap)
                            {
                                maps.MapDirectory.Remove(map);
                                continue;
                            }
                            var dctemp = JsonSerializer.Serialize(Disconnect);
                            var dc = Encoding.UTF8.GetBytes(dctemp);
                            SendToAll(dc, map);
                        }
                    }
                }
                await webSocket.CloseAsync(
                    receiveResult.CloseStatus.Value,
                    receiveResult.CloseStatusDescription, CancellationToken.None);
            }
            catch (Exception ex)
            {
                DebugLog debugLogtemp = new DebugLog()
                {
                    A_ID = maps.MapDirectory[publicMap].client[webSocket].id,
                    D_time = DateTime.Now,
                    D_event = ex.ToString(),
                    D_isSolved = false,
                };
                await _context.AddAsync(debugLogtemp);
                await _context.SaveChangesAsync();
            }
        }

        public static int generateID()
        {
            Random rand = new Random();
            return rand.Next(1, 1000);
        }

        public static string randomFromArray(string[] arr)
        {
            Random rdm = new Random();
            int temp = rdm.Next(0, arr.Length);
            return arr[temp];
        }

        public static async void SendToAll(byte[] buffer, string id)
        {
            foreach (KeyValuePair<WebSocket, PlayerRef> con in maps.MapDirectory[id].client)
            {
                if (con.Key.State != WebSocketState.Open)
                {
                    continue;
                }
                await con.Key.SendAsync(
               new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }

        public static async void SendToPeer(byte[] buffer, WebSocket maleSocket, WebSocket femaleSocket)
        {
            if (maleSocket.State == WebSocketState.Open)
            {
                await maleSocket.SendAsync(
              new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            }
            if (femaleSocket.State == WebSocketState.Open)
            {
                await femaleSocket.SendAsync(
        new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            }
            return;
        }

        public static async void SendToOne(byte[] buffer, WebSocket webSocket)
        {
            if (webSocket.State != WebSocketState.Open)
            {
                return;
            }
            await webSocket.SendAsync(
               new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }
}