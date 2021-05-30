using DataClient.DTO;
using System.Collections.ObjectModel;

namespace DataClient
{
    public partial class Repository
    {
        public DataContext data;
        public Repository(IDataFiller filler)
        {
            data = filler.Fill();
        }

        public ObservableCollection<BurgerDTO> GetListViewBurgers()
        {
            return data.ListViewBurgers;
        }

        public string GetCustomerName()
        {
            return data.customerName;
        }

        public void UpdateListViewBurgers(ObservableCollection<BurgerDTO> updatedList)
        {
            data.ListViewBurgers = updatedList;
        }

        public void AddToListViewBurgers(BurgerDTO Burger)
        {
            data.ListViewBurgers.Add(Burger);
        }

        public void UpdateCustomerName(string updatedCustomerName)
        {
            data.customerName = updatedCustomerName;
        }
    }
}
