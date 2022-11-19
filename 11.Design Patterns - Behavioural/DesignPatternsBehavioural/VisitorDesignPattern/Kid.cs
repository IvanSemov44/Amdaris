
namespace VisitorDesignPattern
{
    public class Kid : IElement
    {
        public Kid(string kidName)
        {
            KidName = kidName;
        }

        public string KidName { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
