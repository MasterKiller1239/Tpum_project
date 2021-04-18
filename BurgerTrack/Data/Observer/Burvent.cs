using Data.Model;
using System;

namespace Data.Observer
{
    public class Burvent
    {
        public DateTime time { get; set; }
        public string description { get; set; }
        public Burger burger { get; set; }

        public Burvent(string description, Burger burger)
        {
            time = DateTime.Now;
            this.description = description;
            this.burger = burger;
        }

    }
}
