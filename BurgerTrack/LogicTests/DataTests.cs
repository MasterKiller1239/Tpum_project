using System;
using System.Collections.Generic;
using Data;
using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentAssertions;

namespace Tests
{
    [TestClass]
    public class DataTests
    {
        DataContext data;

        [TestInitialize]
        public void TestInitialize()
        {
            List<Customer> customers = new List<Customer>()
            {
                  new Customer("Kuba", "Avalon Hill", "Kuba@imaking.eu", "(360) 6104514"),
                  new Customer("Morgana Le Fay", "Wavery Place ", "dvarney15@mit.edu", "(925) 8527446"),
                  new Customer("Merlin ", "Neverland", "ryea16@fema.gov", "(926) 3852562"),
                  new Customer("Uther Pendragon", "Camelot King Chamber", "yoldey17@flavors.me", "(719) 5899787")
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee("Boruta"),
                new Employee("Jaga"),
                new Employee("Leszek")
            };

            List<Burger> Burgers = new List<Burger>()
            {
                 new Burger("Big-King", 2.87f, "Pyszny i malutki"),

                new Burger("Small King", 2.18f,"Mniam"),
              
                new Burger("Big-King-XXL", 1.55f, "Smakowity")
            };

            data = new DataContext();
            data.customers = customers;
            data.employees = employees;
            data.burgers = Burgers;
        }

        [TestMethod]
        public void DoesRepositoryBuildsCorrectly()
        {
            Mock<IDataFiller> mockRepository = new Mock<IDataFiller>();
            mockRepository.Setup(x => x.Fill()).Returns(data);
            Repository repository = new Repository(mockRepository.Object);

            List<Burger> Burgers = (List<Burger>)repository.GetAllBurgers();
            List<Customer> customers = (List<Customer>)repository.GetAllCustomers();
            List<Employee> employees = (List<Employee>)repository.GetAllEmployees();
            List<Order> orders = (List<Order>)repository.GetAllOrders();

            repository.Should().NotBeNull();
            Burgers.Count.Should().Be(3, "because we thought we put three items in the collection");
            customers.Count.Should().Be(4, "because we thought we put four items in the collection");
            employees.Count.Should().Be(3, "because we thought we put three items in the collection");
            orders.Count.Should().Be(0, "because we thought we did not put items in the collection");
        }

        [TestMethod]
        public void AddingTest()
        {
            Mock<IDataFiller> mockRepository = new Mock<IDataFiller>();
            mockRepository.Setup(x => x.Fill()).Returns(data);
            Repository repository = new Repository(mockRepository.Object);


            List<Burger> Burgers = new List<Burger>();
            Burger Burger = new Burger("Testowa", 12.34f, "test");
            Burgers.Add(Burger);
            Customer customer = new Customer("Ala", "kotowa", "Ola@as", "123456789");
            Employee employee = new Employee("Włodek");
            Order order = new Order(customer, Burgers, employee, 10);

            repository.AddCustomer(customer);
            repository.AddEmployee(employee);
            repository.AddOrder(order);
            repository.AddBurger(Burger);
            repository.AddOrderToArchive(order);

            List<Burger> BurgersL = (List<Burger>)repository.GetAllBurgers();
            List<Customer> customers = (List<Customer>)repository.GetAllCustomers();
            List<Employee> employees = (List<Employee>)repository.GetAllEmployees();
            List<Order> orders = (List<Order>)repository.GetAllOrders();

            BurgersL.Count.Should().Be(4, "because we added one item to three items in the collection");
            customers.Count.Should().Be(5, "because we added one item to four items in the collection");
            employees.Count.Should().Be(4, "because we added one item to three items in the collection");
            orders.Count.Should().Be(1, "because we added one item to zero items in the collection");

            Assert.IsTrue(BurgersL.Contains(Burger));
            Assert.IsTrue(customers.Contains(customer));
            Assert.IsTrue(employees.Contains(employee));
            Assert.IsTrue(orders.Contains(order));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Mock<IDataFiller> mockRepository = new Mock<IDataFiller>();
            mockRepository.Setup(x => x.Fill()).Returns(data);
            Repository repository = new Repository(mockRepository.Object);

            List<Burger> Burgers = (List<Burger>)repository.GetAllBurgers();
            List<Customer> customers = (List<Customer>)repository.GetAllCustomers();
            List<Employee> employees = (List<Employee>)repository.GetAllEmployees();
            List<Order> orders = (List<Order>)repository.GetAllOrders();

            Burger Burger = Burgers[0];
            Customer customer = customers[0];
            Employee employee = employees[1];
            Order order1 = new Order(customer, Burgers, employee, 10);
            Order order2 = new Order(customer, Burgers, employee, 20);
            repository.AddOrder(order1);
            repository.AddOrder(order2);

            Burgers.Count.Should().Be(3);
            customers.Count.Should().Be(4);
            employees.Count.Should().Be(3);
            orders.Count.Should().Be(2);

            repository.DeleteCustomer(customer);
            repository.DeleteBurger(Burger);
            repository.DeleteOrderHead();
            repository.DeleteOrder(0);
            repository.DeleteEmployee(employee);

            Burgers.Count.Should().Be(2);
            customers.Count.Should().Be(3);
            employees.Count.Should().Be(2);
            orders.Count.Should().Be(0);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Mock<IDataFiller> mockRepository = new Mock<IDataFiller>();
            mockRepository.Setup(x => x.Fill()).Returns(data);
            Repository repository = new Repository(mockRepository.Object);

            List<Burger> Burgers = (List<Burger>)repository.GetAllBurgers();
            List<Customer> customers = (List<Customer>)repository.GetAllCustomers();

            Burger Burger = new Burger("Big-King", 2.23f, "bez");
            Customer customer = new Customer("Kuba", "Pokatna", "Kuba@imaking.pl", "987654321");

            Burger dbb = Burgers[0];
            Customer dbc = customers[0];

            dbb.description.Should().Be("Pyszny i malutki");
            dbb.price.Should().Be(2.87f);
            dbc.address.Should().Be("Avalon Hill");
            dbc.email.Should().Be("Kuba@imaking.eu");
            dbc.phone.Should().Be("(360) 6104514");
           
            repository.UpdateCustomer(customer);
            repository.UpdateBurger(Burger);

            dbb.description.Should().Be("bez");
            dbb.price.Should().Be(2.23f);
            dbc.address.Should().Be("Pokatna");
            dbc.email.Should().Be("Kuba@imaking.eu");
            dbc.phone.Should().Be("987654321");
        }
    }
}
