using System;
using System.Collections.Generic;
using CoolClasses;

namespace Basics
{
    class Shape
    {
        public virtual double Area() => 0;

        public virtual double Perimeter() => 0;
    }

    class Rectangle : Shape
    {
        private readonly double _a;
        private readonly double _b;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double Area() => _a * _b;

        public override double Perimeter() => 2 * (_a + _b);
    }



    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Console.WriteLine($"{s1.Area()} {s1.Perimeter()}");
            Shape r1 = new Rectangle(5,6);
            Console.WriteLine($"{r1.Area()} {r1.Perimeter()}");

            List<Shape> list = new List<Shape>();
            list.Add(s1);
            list.Add(r1);

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area());
            }

            // Hero hero1 = new Hero(36, "Batman");
            // // hero1.age = -36;
            // // hero1.name = "Batman";
            // Console.WriteLine($"{hero1.Name} is {hero1.Age} years old");
            // hero1.Age = -50;
            // Console.WriteLine($"{hero1.Name} is {hero1.Age} years old");
        }
    }
}
