using System;

class Circle
{
    public int Radius { get; set; }
}

class Rectangle
{
    public int Length { get; set; }
    public int Height { get; set; }
}

class PatternMatchingWithSwitch
{
    static void Main(string[] args)
    {
        PrintShape(new Circle { Radius = 10});
        PrintShape(new Rectangle { Length = 20, Height = 10 });
        PrintShape(new Rectangle { Length = 10, Height = 10 });
    }

    static void PrintShape(object shape)
    {
        switch (shape)
        {
            case Rectangle s when (s.Length == s.Height):
                Console.WriteLine($"정사각형: {s.Length} x {s.Height}");
                break;
            case Rectangle r:
                Console.WriteLine($"정사각형: {r.Length} x {r.Height}");
                break;
            case Circle c:
                Console.WriteLine($"원: 반지름({c.Radius})");
                break;
            case null:
                throw new ArgumentNullException(nameof(shape));
            default:
                Console.WriteLine("<기타도형>");
                break;
        }
    }
}

