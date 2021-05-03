namespace Exercise02
{
    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }
        public abstract double CalculateArea();
    }
}