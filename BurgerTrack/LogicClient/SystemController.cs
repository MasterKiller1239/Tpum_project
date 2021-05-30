using DataClient.DTO;
using DataClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LogicClient
{
    public class SystemController
    {
        public Repository repository { get; set; }
        public WebSocketController webSocketController { get; set; }
        public Action<string> onProcess;
       
        public SystemController(IDataFiller filler)
        {
            this.repository = new Repository(filler);
            this.webSocketController = new WebSocketController(repository);
        }

        public SystemController()
        {
            IDataFiller filler = new DataFactory();
            this.repository = new Repository(filler);
            this.webSocketController = new WebSocketController(repository);
            webSocketController.onStatus = new Action<string>(receiveStatus);
        }

        public void receiveStatus(string statusMessage)
        {
            onProcess(statusMessage);
        }

        public void RequestListOfBurgers()
        {
            webSocketController.webSocketClient.RequestBurger();
        }

        public void RequestOrder(List<BurgerDTO> BurgersToOrder, CustomerDTO customerDTO)
        {
            webSocketController.webSocketClient.RequestOrder(BurgersToOrder, customerDTO);
        }

        public void RequestSubscription(CustomerDTO customerDTO)
        {
            webSocketController.webSocketClient.RequestSubscription(customerDTO);
        }

        public ObservableCollection<BurgerDTO> GetListViewBurger()
        {
            return repository.GetListViewBurgers();
        }
        //public ObservableCollection<BurgerDTO> ListViewBurgers { get; set; }
        //public BurgerDTO selectedBurger { get; set; }
        //public ObservableCollection<BurgerDTO> cart { get; set; } = new ObservableCollection<BurgerDTO>();
        //public BurgerDTO selectedCart { get; set; }
        //public void AddToCart()
        //{
        //    cart.Add(selectedBurger);
        //}

        //public void DeleteFromCart()
        //{
        //    if (cart.Contains(selectedCart))
        //    {
        //        cart.Remove(selectedCart);
        //    }
        //}
    }
}
