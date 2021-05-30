using DataClient.DTO;
using LogicClient.OTD;
using System.Collections.Generic;

namespace LogicClient
{
    public static class OTDMappings
    {
        public static CustomerOTD MapCustomer(CustomerDTO customer)
        {
            CustomerOTD customerOTD = new CustomerOTD
            {
                name = customer.name,
                address = customer.address,
                email = customer.email,
                phone = customer.phone,
            };

            return customerOTD;
        }


        public static BurgerOTD MapBurger(BurgerDTO Burger)
        {
            BurgerOTD BurgerOTD = new BurgerOTD
            {
                name = Burger.name,
                price = Burger.price,
                description = Burger.description,
                discount = Burger.discount,
                image = Burger.image
            };
            return BurgerOTD;
        }

        public static List<BurgerOTD> MapBurgerList(List<BurgerDTO> BurgerList)
        {
            List<BurgerOTD> BurgersOTD = new List<BurgerOTD>();
            foreach (BurgerDTO BurgerDTO in BurgerList)
            {
                BurgerOTD newBurgerOTD = MapBurger(BurgerDTO);
                BurgersOTD.Add(newBurgerOTD);
            }

            return BurgersOTD;
        }
    }
}
