
using ObserverDesignPattern;

Subject RedMi = new Subject("Red Mi Modile", 1000, "Out Of Stock");

Observer pesho = new Observer("Pesho", RedMi);

Observer gosho = new Observer("Gosho", RedMi);

Observer sasho = new Observer("Sasho", RedMi);

Console.WriteLine("Red Mi Mobile current state: "+ RedMi.GetAvailability());

Console.WriteLine();

RedMi.SetAvailability("Available");

RedMi.NotifyObserver();