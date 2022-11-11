// See https://aka.ms/new-console-template for more information
using LINQ;

var estates = new List<Estate>
{
    new Estate{Type="Apartment",Location="Varna",Price=100000 },
    new Estate{Type="House",Location="Sofia",Price=200000 },
    new Estate{Type="Apartment",Location="Burgas",Price=150000 },
    new Estate{Type="Apartment",Location="Plovdiv",Price=90000 },
    new Estate{Type="House",Location="Kavarna",Price=250000 },
    new Estate{Type="House",Location="Varna",Price=120000 },
    new Estate{Type="House",Location="Varna",Price=120000 },
};

var where = estates.Where(p => p.Price > 100000);

var skip = estates.Skip(3);

var skipWhile = estates.SkipWhile(p => p.Price >= 100000);

var skipLast = estates.SkipLast(4);

var take = estates.Take(4);

var takeWhile = estates.TakeWhile(p => p.Price == 100000);

var takeLast = estates.TakeLast(2);

var select = estates.Select(p => p.Location);


foreach (var item in takeLast)
{
    
    //Console.WriteLine(item);
    Console.WriteLine($"{item.Loca} - {item.Location} - {item.Price}");
}