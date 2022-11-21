
namespace FlyweightDesignPattern
{
    public class Circle : IShape
    {

        public string Color { get; set; }
        private int XCor = 10;
        private int YCor = 20;
        private int Radius = 30;

        public void SetColor(string color)
        {
            this.Color = color;
        }
        public void Draw()
        {
            Console.WriteLine($" Circle: Draw() [Color : {Color}, X Cor : {XCor}, YCor : {YCor}, Radius : {Radius}");
        }
    }
}
