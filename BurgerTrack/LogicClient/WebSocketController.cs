using DataClient.DTO;
using DataClient.Requests;
using DataClient;

using Newtonsoft.Json;
using System;

namespace LogicClient
{
    public class WebSocketController
    {
        public WebSocketClient webSocketClient { get; set; }
        public string URI = "ws://localhost:8080/BurgerTrack/";
        public Repository repository;
        public Action<string> onStatus;

        public WebSocketController(Repository repository)
        {
            this.repository = repository;
            webSocketClient = new WebSocketClient();
            _ = webSocketClient.Connect(URI);

            webSocketClient.onMessage = new Action<string>(receiveMessage);
        }

        public void receiveMessage(string message)
        {
            RequestWeb request = JsonConvert.DeserializeObject<RequestWeb>(message);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[{0}] Klient otrzymał odpowiedź: {1} , status: {2}", DateTime.Now.ToString("HH:mm:ss.fff"), request.Tag, request.Status);
            string outp = String.Empty;
            switch (request.Tag)
            {
                case "order":
                    if (request.Status == RequestStatus.SUCCESS)
                    {
                       onStatus("ORDER SUCCESSFUL - 200");
                    }
                    else
                    {
                        onStatus("ORDER FAILED - 404");
                   }
                    break;
                case "burgers":
                    ResponseBurgerList responseBurgerList = JsonConvert.DeserializeObject<ResponseBurgerList>(message);
 
                    foreach (BurgerDTO Burger in responseBurgerList.burgers)
                    {
                        repository.AddToListViewBurgers(Burger);
                    }
                    onStatus("BURGERS RECEIVED");
                    break;
                case "subscription":
                    if (request.Status == RequestStatus.SUCCESS)
                    {
                        onStatus("SUBSCRIPTION SUCCESSFUL - 200");
                    }
                    else
                    {
                        onStatus("SUBSCRIPTION FAILED - 404");
                    }
                    break;
            }
        }
    }
}
