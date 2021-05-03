namespace Exercise02
{
    public class Square : Shape
    {
        public Square(double s){
            Height = s;
            Width = s;
            Area = CalculateArea();
        }
        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}