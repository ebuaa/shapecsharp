using System;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle { Height = 5, Width = 10 },
                new Circle { Radius = 3 },
                new Triangle { Height1 = 3, Height2 = 4, Height3 = 5 },
                new Square { Height = 5},
            };

            foreach (var shape in shapes)
            {
                double area = shape.Area();
                Console.WriteLine($"Area of {shape.GetType().Name} is {area} ");
            }
        }

    }

}
