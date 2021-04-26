namespace Exercise
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public abstract double Area();
    }
}