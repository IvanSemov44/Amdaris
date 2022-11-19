
namespace VisitorDesignPattern
{
    public class School
    {
        private static List<IElement> elements;

        public School()
        {
            elements = new List<IElement>
            {
                new Kid("Pesho"),
                new Kid("Gosho"),
                new Kid("Sasho")
            };
        }
        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }
}

