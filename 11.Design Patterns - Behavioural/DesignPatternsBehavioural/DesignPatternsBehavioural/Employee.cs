
namespace DesignPatternsBehavioural
{
    public class Employee
    {
        public Employee( string? name,int id)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string? Name { get; set; }

      
    }
}
