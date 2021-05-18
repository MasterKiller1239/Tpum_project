using Data.Model;
using ConnectionDependencies.DTO;
using System.Collections.Generic;

namespace Logic
{
    public static class DTOMappings
    {
        public static CustomerDTO MapCustomer(Customer customer)
        {
            CustomerDTO customerDTO = new CustomerDTO
            {
                name = customer.name,
                address = customer.address,
                email = customer.email,
                phone = customer.phone,
            };

            return customerDTO;
        }

        public static EmployeeDTO MapEmployee(Employee employee)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO
            {
                name = employee.name
            };

            return employeeDTO;
        }

        public static OrderDTO MapOrder(Order order)
        {
            OrderDTO orderDTO = new OrderDTO
            {
                id = order.id,
                supplier = MapEmployee(order.supplier),
                burgers = MapBurgerList(order.burgers),
                customer = MapCustomer(order.customer),
                orderTime = order.orderTime,
                realizationTime = order.realizationTime
            };
            return orderDTO;
        }

        public static BurgerDTO MapBurger(Burger burger)
        {
            BurgerDTO BurgerDTO = new BurgerDTO
            {
                name = burger.name,
                price = burger.price,
                description = burger.description,
                discount = burger.discount,
                image = burger.image
            };
            return BurgerDTO;
        }

        public static List<BurgerDTO> MapBurgerList(List<Burger> burgerList)
        {
            List<BurgerDTO> burgersDTO = new List<BurgerDTO>();
            foreach(Burger burger in burgerList)
            {
                BurgerDTO newBurgerDTO = MapBurger(burger);
                burgersDTO.Add(newBurgerDTO);
            }

            return burgersDTO;
        }
    }
}
