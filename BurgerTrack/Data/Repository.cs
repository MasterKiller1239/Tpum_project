using System;
using System.Collections.Generic;
using Data.Model;
using System.Linq;

namespace Data
{
    public partial class Repository
    {
        public DataContext data;

        public Repository(IDataFiller filler)
        {
            data = filler.Fill();
        }

        #region CRUD Customer

        // Create
        public void AddCustomer(Customer customer)
        {
            if (data.customers.Contains(customer))
            {
                throw new Exception("You're trying to add the existing object.");
            }

            data.customers.Add(customer);
        }

        // Read
        public Customer GetCustomer(string nameOrMail)
        {
            return data.customers.Find(x => (x.name.Equals(nameOrMail) || x.email.Equals(nameOrMail)));
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return data.customers;
        }

        // Update 
        public void UpdateCustomer(Customer customer)
        {
            Customer customerFromDataBase = GetCustomer(customer.name);
            if (customerFromDataBase == null)
            {
                throw new Exception("There is no customer called " + customer.name);
            }
            customerFromDataBase.address = customer.address;
            customerFromDataBase.phone = customer.phone;
        }

        // Delete
        public void DeleteCustomer(Customer customer)
        {
            if(!data.customers.Contains(customer))
            {
                throw new Exception("You're trying to remove the object which is not in repository.");
            }
            data.customers.Remove(customer);
        }

        #endregion

        #region CRUD Employee

        // Create
        public void AddEmployee(Employee employee)
        {
            if (data.employees.Contains(employee))
            {
                throw new Exception("You're trying to add the existing object.");
            }

            data.employees.Add(employee);
        }

        // Read
        public Employee GetEmployee(string name)
        {
            return data.employees.Find(x => x.name.Equals(name));
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return data.employees;
        }

        // Delete
        public void DeleteEmployee(Employee employee)
        {
            if (!data.employees.Contains(employee))
            {
                throw new Exception("You're trying to remove the object which is not in repository.");
            }
            data.employees.Remove(employee);
        }

        #endregion

        #region CRUD Burger

        // Create
        public void AddBurger(Burger Burger)
        {
            if (data.burgers.Contains(Burger))
            {
                throw new Exception("You're trying to add the existing object.");
            }

            data.burgers.Add(Burger);
        }

        // Read
        public Burger GetBurger(string name)
        {
            return data.burgers.Find(x => x.name.Equals(name));
        }

        public IEnumerable<Burger> GetAllBurgers()
        {
            return data.burgers;
        }

        // Update 
        public void UpdateBurger(Burger Burger)
        {
            Burger BurgerFromDataBase = GetBurger(Burger.name);
            if (BurgerFromDataBase == null)
            {
                throw new Exception("There is no Burger called " + Burger.name);
            }
            BurgerFromDataBase.description = Burger.description;
            BurgerFromDataBase.price = Burger.price;
        }

        // Delete
        public void DeleteBurger(Burger Burger)
        {
            if (!data.burgers.Contains(Burger))
            {
                throw new Exception("You're trying to remove the object which is not in repository.");
            }
            data.burgers.Remove(Burger);
        }

        #endregion

        #region CRUD Order

        // Create
        public void AddOrder(Order order)
        {
            if (data.orders.Contains(order))
            {
                throw new Exception("You're trying to add the existing object.");
            }
            data.orders.Add(order);
        }

        // Read
        public Order GetOrder(Guid id)
        {
            return (Order)data.orders.Where(x => x.id.Equals(id));
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return data.orders;
        }

        public IEnumerable<Order> GetAllCustomerOrders(string name)
        {
            return data.ordersArchive.Where(x => x.customer.name.Equals(name)).ToList();
        }

        public IEnumerable<Order> GetOrdersArchive()
        {
            return data.ordersArchive;
        }

        public void AddOrderToArchive(Order order)
        {
            if (data.ordersArchive.Contains(order))
            {
                throw new Exception("You're trying to add the existing object.");
            }
            data.ordersArchive.Add(order);
        }

        // Update 
        public void UpdateOrder(Order order)
        {
            Order orderFromDataBase = GetOrder(order.id);
            if (orderFromDataBase == null)
            {
                throw new Exception("There is no order of ID " + order.id);
            }
            orderFromDataBase.realizationTime = order.realizationTime;
            orderFromDataBase.burgers = order.burgers;
            orderFromDataBase.supplier = order.supplier;
            orderFromDataBase.customer = order.customer;
        }

        // Delete
        public void DeleteOrder(int order)
        {
            if(data.orders.Count <= order)
            {
                throw new Exception("You're trying to remove the object which is not in repository.");
            }
            data.orders.RemoveAt(order);
        }

        public void DeleteOrderHead()
        {
            if (data.orders.Count == 0)
            {
                throw new Exception("You're trying to remove the object which is not in repository.");
            }
            data.orders.RemoveAt(0);
        }

        #endregion
    }
}
