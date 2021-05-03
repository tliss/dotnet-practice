using static System.Math;

namespace Exercise02
{
    public class Circle : Shape
    {
        public Circle(double r)
        {
            Height = r;
            Width = r;
            Area = CalculateArea();
        }
        public override double CalculateArea()
        {
            // Area of circle = PI * radius^2
            return PI * (Height * Height);
        }
    }
}