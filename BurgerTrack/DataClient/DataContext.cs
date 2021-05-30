using System.Collections.Generic;
using DataClient.DTO;
using System.Collections.ObjectModel;
namespace DataClient
{
    public class DataContext
    {
        public ObservableCollection<BurgerDTO> ListViewBurgers { get; set; }
        public string customerName { get; set; }

        public DataContext()
        {
            this.ListViewBurgers = new ObservableCollection<BurgerDTO>();
            this.customerName = string.Empty;
        }
    }
}

