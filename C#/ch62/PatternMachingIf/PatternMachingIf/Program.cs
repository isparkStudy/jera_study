using System;

namespace PatternMachingIf
{
    class Shape { }

    class Rectangle : Shape
    {
        public string Name { get; set; } = "사각형";
    }

    class PatternMachingIf
    {
        static void Main(string[] args)
        {
            ShowShape(new Rectangle());

            static void ShowShape(Shape shape)
            {
                if (shape is Rectangle r)
                {
                    Console.WriteLine(r.Name);
                }
            }
        }
    }
}
