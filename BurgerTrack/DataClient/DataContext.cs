using System.Collections.Generic;
using ConnectionDependencies.DTO;
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

