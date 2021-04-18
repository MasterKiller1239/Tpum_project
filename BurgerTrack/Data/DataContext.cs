using Data.Model;
using System.Collections.Generic;

namespace Data
{
    public class DataContext
    {
        public List<Customer> customers { get; set; }
        public List<Employee> employees { get; set; }
        public List<Burger> burgers { get; set; }
        public List<Order> orders { get; set; }
        public List<Order> ordersArchive { get; set; }

        public DataContext()
        {
            customers = new List<Customer>();
            employees = new List<Employee>();
            burgers = new List<Burger>();
            orders = new List<Order>();
            ordersArchive = new List<Order>();
        }
    }
}

