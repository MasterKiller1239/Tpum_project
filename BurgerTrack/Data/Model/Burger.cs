using System;
using System.Collections.Generic;

namespace Data.Model
{
    public class Burger
    {
        public string name { get; }
        public float price { get; set; }
        public string description { get; set; }
        private float _discount; // %
        public string image { get; set; }

        public float discount
        {
            get { return _discount; }
            set
            {
                _discount = value;
                price *= (1 - _discount / 100);
            }
        }

        public Burger(string name, float price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public Burger(string name, float price, string description, string image)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.image = image;
        }

        public override string ToString()
        {
            string employeeInfo = "\n";
            employeeInfo += "\tName       : " + name;
            employeeInfo += "\tPrice      : " + price + " PLN";
            employeeInfo += "\tDescription: " + description;
            return employeeInfo;
        }

        public override bool Equals(object value)
        {
            if ((value == null) || !this.GetType().Equals(value.GetType()))
            {
                return false;
            }

            Burger Burger = value as Burger;

            return (Burger != null)
                && (name == Burger.name);
        }

        public override int GetHashCode()
        {
            var hashCode = 722030697;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + price.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            return hashCode;
        }
    }
}
