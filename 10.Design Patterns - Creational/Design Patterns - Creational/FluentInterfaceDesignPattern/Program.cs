
using FluentInterfaceDesignPattern;

FluentEmployee employee = new FluentEmployee();

employee
    .Name("Ivan")
    .Born("11/11/21")
    .WorkingOn("It")
    .StayAt("Varna");