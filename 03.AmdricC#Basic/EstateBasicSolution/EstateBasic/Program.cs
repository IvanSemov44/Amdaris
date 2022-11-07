// See https://aka.ms/new-console-template for more information
using EstateBasic;

Console.WriteLine("Hello, World!");

EstateForSell firstEstate = new EstateForSell();

firstEstate.Owner = "Jhon Snow";
firstEstate.CreatePrice(100,1000);

EstateForSell secondEstate = new EstateForSell();

secondEstate.Owner = "Harry Potter";
secondEstate.CreatePrice(200,1500);

EstateForSell[] estates = new EstateForSell[2]
{
    firstEstate,
    secondEstate
};

Estates estatesList = new Estates(estates);

foreach (var item in estatesList)
{
    Console.WriteLine(item.Owner + " sell estate for " + item.TotalPrice + "$");
}