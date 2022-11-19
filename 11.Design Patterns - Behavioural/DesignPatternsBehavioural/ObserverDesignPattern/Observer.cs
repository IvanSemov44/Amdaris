namespace ObserverDesignPattern
{
    public class Observer : IObserver
    {
        public Observer(string userName,ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public string UserName { get; set; }
        public void Update(string availability)
        {
            Console.WriteLine($"Hello {UserName}, Product is now {availability} on Amazon");
        }
    }
}