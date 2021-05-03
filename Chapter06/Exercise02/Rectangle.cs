namespace Exercise02
{
    public class Rectangle : Shape
    {
        public Rectangle(double h, double w){
            Height = h;
            Width = w;
            Area = CalculateArea();
        }
        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}