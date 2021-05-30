using Logic;
using Logic.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;


namespace Server
{
    public class WebSocketServer
    {
        private OrderSystem os;

        public async void Start(string httpListenerPrefix)
        {
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add(httpListenerPrefix);
            httpListener.Start();
            Console.WriteLine("[{0}] Server nasłuchuje...", DateTime.Now.ToString("HH:mm:ss.fff"));

            os = new OrderSystem();
            os.StartWorkDay();

            while (true)
            {
                HttpListenerContext httpListenerContext = await httpListener.GetContextAsync();
                if (httpListenerContext.Request.IsWebSocketRequest)
                {
                    ProcessRequest(httpListenerContext);
                }
            }
        }

        private string ProcessData(string inp, string ipAddress)
        {
            RequestWeb request = JsonConvert.DeserializeObject<RequestWeb>(inp);
            Console.WriteLine("[{0}] Serwer otrzymał zapytanie: \"{1}\" od {2}, status: {3}", DateTime.Now.ToString("HH:mm:ss.fff"), request.Tag, ipAddress, request.Status);

            string output = String.Empty;
            switch (request.Tag)
            {
                case "order":
                    RequestBurgerOrder requestBurgerOrder = JsonConvert.DeserializeObject<RequestBurgerOrder>(inp);
                    output = ProcessOrderRequest(requestBurgerOrder);
                    break;
                case "burgers":
                    output =  ProcessBurgerRequest();
                    break;
                case "subscription":
                    RequestCustomerSubscription requestCustomerSubscription = JsonConvert.DeserializeObject<RequestCustomerSubscription>(inp);
                    output = ProcessSubscriptionRequest(requestCustomerSubscription);
                    break;
            }

            return output;
        }

        private string ProcessOrderRequest(RequestBurgerOrder request)
        {
           
            RequestWeb response = new RequestWeb("order");
            string json;
            if (os.GetCustomerDTO(request.customer.name) == null)
            {
                response.Status = RequestStatus.FAIL;
                json = JsonConvert.SerializeObject(response, Formatting.Indented);
                return json;
            }
            os.OrderBurger(request.burgers, request.customer);
            json = JsonConvert.SerializeObject(response, Formatting.Indented);
            return json;
        }

        private string ProcessBurgerRequest()
        {
           
            RequestWeb response = new ResponseBurgerList("burgers", os.GetAllBurgersDTO());
            string json = JsonConvert.SerializeObject(response, Formatting.Indented);
            return json;
        }

        private string ProcessSubscriptionRequest(RequestCustomerSubscription request)
        {
           
            RequestWeb response = new RequestWeb("order");
            string json;
            if (os.GetCustomerDTO(request.customer.name) == null)
            {
                response.Status = RequestStatus.FAIL;
                json = JsonConvert.SerializeObject(response, Formatting.Indented);
                return json;
            }
            os.SubscribeToPromotion(request.customer);
            response = new RequestWeb("subscription");
            json = JsonConvert.SerializeObject(response, Formatting.Indented);
            return json;
        }

        private async void ProcessRequest(HttpListenerContext httpListenerContext)
        {
            WebSocketContext webSocketContext = null;
            string ipAddress = string.Empty;
            try
            {
                webSocketContext = await httpListenerContext.AcceptWebSocketAsync(subProtocol: null);
                ipAddress = httpListenerContext.Request.RemoteEndPoint.Address.ToString();
                Console.WriteLine("[{0}] Połączono z IPAdress: {1}", DateTime.Now.ToString("HH:mm:ss.fff"), ipAddress);
            }
            catch (Exception e)
            {
                httpListenerContext.Response.StatusCode = 500;
                httpListenerContext.Response.Close();
                Console.WriteLine("Exception {0}", e);
                return;
            }

            WebSocket webSocket = webSocketContext.WebSocket;

            try
            {
                int size = 8192;
                byte[] receiveBuffer = new byte[size];
                while (webSocket.State == WebSocketState.Open)
                {
                    Array.Clear(receiveBuffer, 0, receiveBuffer.Length);
                    WebSocketReceiveResult receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);
                    
                    if (receiveResult.MessageType == WebSocketMessageType.Close)
                    {
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Connection closed.", CancellationToken.None);
                    }
                    else
                    {
                        string response = ProcessData(Encoding.UTF8.GetString(receiveBuffer).TrimEnd('\0'), ipAddress);
                        ArraySegment<byte> outb = new ArraySegment<byte>(Encoding.UTF8.GetBytes(response));
                        await webSocket.SendAsync(outb, WebSocketMessageType.Binary, receiveResult.EndOfMessage, CancellationToken.None);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
            finally
            {
                if (webSocket != null)
                {
                    webSocket.Dispose();
                }
            }
        }
    }
}
