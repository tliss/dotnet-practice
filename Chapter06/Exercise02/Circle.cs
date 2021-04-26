namespace Exercise
{
    public class Circle : Shape
    {
        public override double Area()
        {
            // Area of circle = PI * radius^2
            return Height * Width;
        }
    }
}