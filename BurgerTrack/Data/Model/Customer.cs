using Data.Observer;
using System;
using System.Collections.Generic;

namespace Data.Model
{
    public class Customer : IObserver<Burvent> // Obserwuje
    {
        public string name { get; }
        public string address { get; set; }
        public string email { get; }
        public string phone { get; set; }

        public Customer(string name, string address, string email, string phone)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
        }

        public override string ToString()
        {
            string customerInfo = "\n";
            customerInfo += "\tName       : " + name;
            customerInfo += "\tAddress    : " + address;
            customerInfo += "\tEmail      : " + email;
            customerInfo += "\tPhone      : " + phone;
            return customerInfo;
        }

        public override bool Equals(object value)
        {
            if ((value == null) || !this.GetType().Equals(value.GetType()))
            {
                return false;
            }

            Customer customer = value as Customer;

            return (customer != null)
                && (name == customer.name)
                && (email == customer.email);
        }

        public override int GetHashCode()
        {
            var hashCode = -94746421;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phone);
            return hashCode;
        }

        #region Observer

        private IDisposable unsubscriber;

        public virtual void Subscribe(IObservable<Burvent> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[{0}]Wystąpił błąd subskrybcji.", DateTime.Now.ToString("HH:mm:ss.fff"));
        }

        public void OnNext(Burvent value)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
         


            Console.WriteLine("[{1}] Nowy email na adres: {0}\n" +
                              "Temat: {6}\n" +
                              "Drogi {5}, Burger {2} przeceniony o {3}%. Nowa cena to {4}!",
                              this.email,
                              DateTime.Now.ToString("HH:mm:ss.fff"),
                              value.burger.name,
                              value.burger.discount,
                              Math.Round(value.burger.price, 2),
                              this.name,
                              value.description);
        }

        public void OnCompleted()
        {
            unsubscriber.Dispose();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[{0}] Subskrybcja zakończona. Powiadomienia nie będą wys", DateTime.Now.ToString("HH:mm:ss.fff"));
        }

        #endregion
    }
}
