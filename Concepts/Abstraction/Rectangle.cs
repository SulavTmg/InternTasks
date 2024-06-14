
namespace Abstraction
{
    public class Rectangle : Shape
    {
         double _width {  get; set; }
         double _height { get; set; }

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        public override double CalculateArea()
        {
            return _width * _height;
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle with Width: {_width}, Height: {_height}");
        }
    }
}
