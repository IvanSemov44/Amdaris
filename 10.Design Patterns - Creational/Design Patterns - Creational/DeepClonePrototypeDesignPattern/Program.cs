using DeepClonePrototypeDesignPattern;

Employee emp1 = new Employee();
emp1.Name = "Gosho";
emp1.Department = "IT";
emp1.EmpAddress = new Address() { GetAddress = "Sofia" };

Employee emp2 = emp1.GetClone();
emp2.Name = "Pesho";
emp2.EmpAddress.GetAddress = "Varna";


Console.WriteLine("Employee 1");
Console.WriteLine("Name:" + emp1.Name + ", Department:" + emp1.Department + " Address:" + emp1.EmpAddress.GetAddress);

Console.WriteLine("Employee 2");
Console.WriteLine("Name:" + emp2.Name + ", Department:" + emp2.Department + " Address:" + emp2.EmpAddress.GetAddress);