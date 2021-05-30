using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Server;
using LogicClient;
using DataClient.DTO;
using System.Diagnostics;

namespace Tests
{
    [TestClass]
    public class ConnectionTests
    {
        bool resultTest = true;
        bool gotResponse = false;

        [TestMethod]
        public void GetListOfBurgersFromServerTest()
        {
            // Serwer
            WebSocketServer webSocketServer = new WebSocketServer();
            webSocketServer.Start("http://localhost:8080/BurgerTrack/");

            // Klient
            SystemController systemController = new SystemController();
            systemController.onProcess = new Action<string>(ReceiveMessage);
        
            Stopwatch timeoutStopwatch = new Stopwatch();
            timeoutStopwatch.Start();
            while (!systemController.webSocketController.webSocketClient.CheckConnectionStatus())
            {
                if (timeoutStopwatch.ElapsedMilliseconds > 15000.0f) throw new TimeoutException();
            }

            systemController.RequestListOfBurgers();
            timeoutStopwatch.Restart();
            while (!gotResponse)
            {
                if (timeoutStopwatch.ElapsedMilliseconds > 15000.0f) throw new TimeoutException();
            }
            gotResponse = false;
            int NumberOfBurgers = systemController.repository.GetListViewBurgers().Count;
            Assert.AreEqual(14, NumberOfBurgers);
        }

        [TestMethod]
        public void CheckIfOrderWorksTest()
        {
            // Serwer
            WebSocketServer webSocketServer = new WebSocketServer();
            webSocketServer.Start("http://localhost:8080/BurgerTrack/");

            // Klient
            SystemController systemController = new SystemController();
            systemController.onProcess = new Action<string>(ReceiveMessage);

            Stopwatch timeoutStopwatch = new Stopwatch();
            timeoutStopwatch.Start();
            while (!systemController.webSocketController.webSocketClient.CheckConnectionStatus())
            {
                if (timeoutStopwatch.ElapsedMilliseconds > 15000.0f) throw new TimeoutException();
            }

            systemController.RequestListOfBurgers();
            timeoutStopwatch.Restart();
            while (!gotResponse)
            {
                if (timeoutStopwatch.ElapsedMilliseconds > 15000.0f) throw new TimeoutException();
            }
            gotResponse = false;
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.name = "Kuba";

            BurgerDTO Burger = systemController.repository.GetListViewBurgers()[0];
            List<BurgerDTO> BurgersToOrder = new List<BurgerDTO>();
            BurgersToOrder.Add(Burger);
            systemController.RequestOrder(BurgersToOrder, customerDTO);
            timeoutStopwatch.Restart();
            while (!gotResponse)
            {
                if (timeoutStopwatch.ElapsedMilliseconds > 15000.0f) throw new TimeoutException();
            }
            gotResponse = false;

            Assert.AreEqual(true, resultTest);

            customerDTO.name = "Merlin";
            systemController.RequestOrder(BurgersToOrder, customerDTO);
            timeoutStopwatch.Restart();
            while (!gotResponse)
            {
                if (timeoutStopwatch.ElapsedMilliseconds > 15000.0f) throw new TimeoutException();
            }
            gotResponse = false;

            Assert.AreEqual(false, resultTest);
        }

        public void ReceiveMessage(string message)
        {
            switch (message)
            {
                case "ORDER SUCCESSFUL - 200":
                    resultTest = true;
                    gotResponse = true;
                    break;
                case "ORDER FAILED - 404":
                    resultTest = false;
                    gotResponse = true;
                    break;
                case "SUBSCRIPTION SUCCESSFUL - 200":
                    resultTest = true;
                    gotResponse = true;
                    break;
                case "SUBSCRIPTION FAILED - 404":
                    resultTest = false;
                    gotResponse = true;
                    break;
                case "BURGERS RECEIVED":
                    gotResponse = true;
                    break;
            }
        }
    }
}
