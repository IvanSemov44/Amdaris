
using PrototypeDesignPattern;

Employee emp1 = new Employee();
emp1.Name = "Gosho";
emp1.Department = "IT";

Employee emp2 = emp1.GetClone();
emp2.Name = "Pesho";

Console.WriteLine("Employee 1");
Console.WriteLine("Name:" + emp1.Name +", Department:"+emp1.Department);

Console.WriteLine("Employee 2");
Console.WriteLine("Name:" + emp2.Name +", Department:"+emp2.Department);

