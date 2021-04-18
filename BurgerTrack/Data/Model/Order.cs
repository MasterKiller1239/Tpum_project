using System;
using System.Collections.Generic;

namespace Data.Model
{
    public class Order
    {
        public Guid id { get; }
        public Employee supplier { get; set; }
        public List<Burger> burgers { get; set; }
        public Customer customer { get; set; }
        public DateTime orderTime { get; }
        public int realizationTime { get; set; }
        public Order(Customer customer, List<Burger> Burgers, Employee employee, int deliveryTimeInMinutes)
        {
            this.id = Guid.NewGuid();
            this.customer = customer;
            this.burgers = Burgers;
            this.supplier = employee;
            this.orderTime = DateTime.Now;
            this.realizationTime = deliveryTimeInMinutes;
        }

        public Order(Customer customer, List<Burger> Burgers, int deliveryTimeInMinutes)
        {
            this.id = Guid.NewGuid();
            this.customer = customer;
            this.burgers = Burgers;
            this.orderTime = DateTime.Now;
            this.realizationTime = deliveryTimeInMinutes;
        }

        public override string ToString()
        {
            string orderInfo = "\n";
            orderInfo += "\tEmployee ID      : " + id;
            orderInfo += "\tEmployee         : " + supplier.name;
            orderInfo += "\tCustomer         : " + customer.name;
            orderInfo += "\tBurgers         : " + burgers;
            orderInfo += "\tOrder Time       : " + orderTime;
            orderInfo += "\tRealization Time : " + realizationTime;
            return orderInfo;
        }

        public override bool Equals(object value)
        {
            if ((value == null) || !this.GetType().Equals(value.GetType()))
            {
                return false;
            }

            Order order = value as Order;

            return (order != null)
                && (id == order.id);
        }

        public override int GetHashCode()
        {
            var hashCode = -1323047339;
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<Employee>.Default.GetHashCode(supplier);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Burger>>.Default.GetHashCode(burgers);
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(customer);
            hashCode = hashCode * -1521134295 + orderTime.GetHashCode();
            hashCode = hashCode * -1521134295 + realizationTime.GetHashCode();
            return hashCode;
        }
    }
}
