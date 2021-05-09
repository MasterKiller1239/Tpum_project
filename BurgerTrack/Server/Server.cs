using System;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            WebSocketServer webSocketServer = new WebSocketServer();
            webSocketServer.Start("http://localhost:8080/BurgerTrack/");
            Console.ReadKey();
        }
    }
}
