
namespace VisitorDesignPattern
{
    public class Doctor : IVisitor
    {
        public Doctor(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Visit(IElement Element)
        {
            Kid kid=(Kid)Element;
            Console.WriteLine("Doctor: " + this.Name + " did the health checkup of the child: " + kid.KidName);
        }
    }
}
