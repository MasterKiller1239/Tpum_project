//using Logic;
using Logic.DTO;
using Logic.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

namespace GUI.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        private readonly Dispatcher _dispatcher;

        public ObservableCollection<BurgerDTO> ListViewBurgers { get; set; }
        public BurgerDTO selectedBurger { get; set; }
        public ObservableCollection<BurgerDTO> cart { get; set; } = new ObservableCollection<BurgerDTO>();
        public BurgerDTO selectedCart { get; set; }
        public string customerName { get; set; }
        //private OrderSystem os;
        private WebSocketClient webSocketClient;


        #endregion

        #region RelayCommands

        public RelayCommand AddToCartCommand { get; }
        public RelayCommand DeleteFromCartCommand { get; }
        public RelayCommand OrderBurgerCommand { get; }
        public RelayCommand SubscribeCommand { get; }
        #endregion

        #region Constructors

        public MainViewModel()
        {
            //os = new OrderSystem();
            //os.StartWorkDay();
            webSocketClient = new WebSocketClient();
            webSocketClient.Connect("ws://localhost:8080/BurgerTrack/");
  
            webSocketClient.onMessage = new Action<string>(receiveMessage);
            this._dispatcher = Dispatcher.CurrentDispatcher;
            webSocketClient.RequestBurger();
            this.ListViewBurgers = new ObservableCollection<BurgerDTO>();   
            this.AddToCartCommand = new RelayCommand(param => AddToCart(), null);
            this.DeleteFromCartCommand = new RelayCommand(param => DeleteFromCart(), null);
            this.OrderBurgerCommand = new RelayCommand(param => OrderBurger(), null);
            this.SubscribeCommand = new RelayCommand(param => Subscribe(), null);
        }

        #endregion

        #region Methods
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
                        MessageBoxResult success = MessageBox.Show("Zamówienie udane, prosimy czekać na zamówienie.", "Zamówienie udane.", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBoxResult noCustomer = MessageBox.Show("Nie ma takiego użytkownika.", "Nie ma takiego użytkownika.", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    break;
                case "burgers":
                    ResponseBurgerList responseBurgerList = JsonConvert.DeserializeObject<ResponseBurgerList>(message);
                    foreach (BurgerDTO Burger in responseBurgerList.burgers)
                    {
                        ListViewBurgers.Add(Burger);
                    }
                    break;
                case "subscription":
                    if (request.Status == RequestStatus.SUCCESS)
                    {
                        MessageBoxResult success = MessageBox.Show("Drogi kliencie, od teraz będziesz dostawał powiadomienia o super okazjach w naszym Burgertracku.", "Subskrybujesz naszą Burgertrack.", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBoxResult noCustomer = MessageBox.Show("Nie ma takiego użytkownika.", "Nie ma takiego użytkownika.", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    break;
            }
        }

        public void AddToCart()
        {
            cart.Add(selectedBurger);
        }

        public void DeleteFromCart()
        {
            if (cart.Contains(selectedCart))
            {
                cart.Remove(selectedCart);
            }
        }

        public void OrderBurger()
        {
            if(string.IsNullOrEmpty(customerName))
            {
                MessageBoxResult noString = MessageBox.Show("Nie wpisano nazwy użytkownika.", "Nie wpisano nazwy użytkownika.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.name = customerName;
    

            List<BurgerDTO> BurgersToOrder = new List<BurgerDTO>(cart);
            if(BurgersToOrder.Count == 0)
            {
                MessageBoxResult noCustomer = MessageBox.Show("Nie wybrano burgera.", "Nie wybrano burgera.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            webSocketClient.RequestOrder(BurgersToOrder, customerDTO);
        }

        public void Subscribe()
        {
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBoxResult noString = MessageBox.Show("Nie wpisano nazwy użytkownika. Wpisz ją w wyznaczonym miejscu.", "Nie wpisano nazwy użytkownika.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            //    CustomerDTO customerDTO = os.GetCustomerDTO(customerName);
            //    if (customerDTO == null)
            //    {
            //        MessageBoxResult noCustomer = MessageBox.Show("Nie ma takiego użytkownika. Wpisz ją w wyznaczonym miejscu.", "Nie ma takiego użytkownika.", MessageBoxButton.OK, MessageBoxImage.Warning);
            //        return;
            //    }

            //    os.SubscribeToPromotion(customerDTO);

            //    MessageBoxResult success = MessageBox.Show("Drogi kliencie, od teraz będziesz dostawał powiadomienia o super okazjach w naszym BurgerTracku.", "Subskrybujesz naszą usługę.", MessageBoxButton.OK, MessageBoxImage.Information);
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.name = customerName;

            webSocketClient.RequestSubscription(customerDTO);
        }

        #endregion
    }
}
