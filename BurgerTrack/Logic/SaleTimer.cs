using Data.Model;
using Data.Observer;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Logic
{
    class SaleTimer
    {
        private int m_nStart = 0;
        private List<Burger> Burgers;
        private Timer oTimer;
        private SalesCreator provider;

        public void StartTimer(List<Burger> Burgers, SalesCreator salesCreator)
        {
            this.Burgers = Burgers;
            this.provider = salesCreator;
            m_nStart = Environment.TickCount;
            oTimer = new Timer(new TimerCallback(CallbackMethod), null, 0, 10000);
        }

        private void CallbackMethod(object oStateObject)
        {
            Random random = new Random();
            float discount = random.Next(5, 25);
            random = new Random();
            int whichBurger = (int)random.Next(0, Burgers.Count - 1);
            Burger Burger = Burgers[whichBurger];
            Burger.discount = discount;

            random = new Random();
            int whichEvent = (int)random.Next(0, events.Count - 1);
            string eventDescription = events[whichEvent];
            provider.Sale(new Burvent(eventDescription, Burger));
        }

        private IList<string> events = new List<string>
        {
            ((new DateTime(2021, 05,  28 )- DateTime.Now).Days + " dni do Światowego Dzień Hamburgera").ToString(),
            ((new DateTime(2021, 06, 1) - DateTime.Now).Days + " dni do Dnia Dziecka!").ToString(),
           
        };                                                       
    }
}
