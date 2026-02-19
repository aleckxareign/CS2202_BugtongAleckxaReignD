class Pentagon
{
    private double side;

    public Pentagon()
    {
        side = 0;
    }

    public Pentagon(double s)
    {
        side = s;
    }

    public double GetPerimeter()
    {
        return 5 * side;
    }

    public double GetArea()
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
    }

    public void Display(string name)
    {
        Console.WriteLine(name);
        Console.WriteLine("------------------------");
        Console.WriteLine($"Side length: " + side);
        Console.WriteLine($"Perimeter: " + GetPerimeter().ToString("F3"));
        Console.WriteLine($"Area: " + GetArea().ToString("F3"));
        Console.WriteLine();
    }
}

    class PentagonClass
    {
        public static void Main(String[] args)
        {
            Pentagon p1 = new Pentagon();
            p1.Display("Pentagon p1");

            Pentagon p2 = new Pentagon(5);
            p2.Display("Pentagon p2");
        }
    }