using Logic;
using Logic.DTO;
using System.Collections.Generic;
using System.Threading;

namespace ClientPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderSystem os = new OrderSystem();
            os.StartWorkDay();

            CustomerDTO customer1 = os.GetCustomerDTO("Tosia");
            CustomerDTO customer2 = os.GetCustomerDTO("Kuba");
            CustomerDTO customer3 = os.GetCustomerDTO("Basia");

            os.SubscribeToPromotion(customer1);
            os.SubscribeToPromotion(customer3);
            while (true)
            {

                List<BurgerDTO> Burgers1 = new List<BurgerDTO>();
                BurgerDTO Burger1 = os.GetBurgerDTO("Angry Diablo Bacon King");
                Burgers1.Add(Burger1);
                os.OrderBurger(Burgers1, customer1);

                Thread.Sleep(2000);

                List<BurgerDTO> Burgers2 = new List<BurgerDTO>();
                BurgerDTO Burger2 = os.GetBurgerDTO("Angry Diablo Bacon King");
                Burgers2.Add(Burger2);
                os.OrderBurger(Burgers2, customer2);

                Thread.Sleep(2000);

                List<BurgerDTO> Burgers3 = new List<BurgerDTO>();
                BurgerDTO Burger3 = os.GetBurgerDTO("Angry Diablo Bacon King");
                Burgers3.Add(Burger3);
                os.OrderBurger(Burgers3, customer3);
             }
        }
    }
}

