
using System;

namespace ObserverDesignPattern
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string Availability { get; set; }

        public string GetAvailability()
        {
            return Availability;
        }

        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
        }

        public void NotifyObserver()
        {
            Console.WriteLine(
                $"Product Name: {ProductName}, Product Price: {ProductPrice} is now available. " +
                $"So notifing all Register users.");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.Update(Availability);

            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added: "+((Observer)observer).UserName);
            observers.Add(observer);
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
