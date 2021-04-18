using Logic;
using Logic.DTO;
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

        public List<BurgerDTO> ListViewBurgers { get; set; }
        public BurgerDTO selectedBurger { get; set; }
        public ObservableCollection<BurgerDTO> cart { get; set; } = new ObservableCollection<BurgerDTO>();
        public BurgerDTO selectedCart { get; set; }
        public string customerName { get; set; }
        private OrderSystem os;



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
            os = new OrderSystem();
            os.StartWorkDay();

            this._dispatcher = Dispatcher.CurrentDispatcher;
            this.ListViewBurgers = (List<BurgerDTO>)os.GetAllBurgersDTO();   
            this.AddToCartCommand = new RelayCommand(param => AddToCart(), null);
            this.DeleteFromCartCommand = new RelayCommand(param => DeleteFromCart(), null);
            this.OrderBurgerCommand = new RelayCommand(param => OrderBurger(), null);
            this.SubscribeCommand = new RelayCommand(param => Subscribe(), null);
        }

        #endregion

        #region Methods

   
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

            CustomerDTO customerDTO = os.GetCustomerDTO(customerName);
            if(customerDTO == null)
            {
                MessageBoxResult noCustomer = MessageBox.Show("Nie ma takiego użytkownika.", "Nie ma takiego użytkownika.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            List<BurgerDTO> BurgersToOrder = new List<BurgerDTO>(cart);
            if(BurgersToOrder.Count == 0)
            {
                MessageBoxResult noCustomer = MessageBox.Show("Nie wybrano burgera.", "Nie wybrano burgera.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            os.OrderBurger(BurgersToOrder, customerDTO);

            MessageBoxResult success = MessageBox.Show("Zamówienie udane, prosimy czekać na zamówienie.", "Zamówienie udane.", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }

        public void Subscribe()
        {
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBoxResult noString = MessageBox.Show("Nie wpisano nazwy użytkownika. Wpisz ją w wyznaczonym miejscu.", "Nie wpisano nazwy użytkownika.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            CustomerDTO customerDTO = os.GetCustomerDTO(customerName);
            if (customerDTO == null)
            {
                MessageBoxResult noCustomer = MessageBox.Show("Nie ma takiego użytkownika. Wpisz ją w wyznaczonym miejscu.", "Nie ma takiego użytkownika.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            os.SubscribeToPromotion(customerDTO);

            MessageBoxResult success = MessageBox.Show("Drogi kliencie, od teraz będziesz dostawał powiadomienia o super okazjach w naszym BurgerTracku.", "Subskrybujesz naszą usługę.", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        #endregion
    }
}
