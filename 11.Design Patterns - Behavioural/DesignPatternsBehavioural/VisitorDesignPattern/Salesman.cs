
using System.Xml.Linq;

namespace VisitorDesignPattern
{
    public class Salesman : IVisitor
    {
        public Salesman(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Visit(IElement Element)
        {
            Kid kid = (Kid)Element;
            Console.WriteLine("Salesman: " + this.Name + " gave the school bag to the child:" + kid.KidName);
        }
    }
}
