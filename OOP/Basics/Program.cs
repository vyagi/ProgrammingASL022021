using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using CoolClasses;

namespace Basics
{
    abstract class Shape
    {
        public abstract double Area();

        public abstract double Perimeter();
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

    class Circle : Shape
    {
        private double _radius;

        public Circle(double radius) => _radius = radius;

        public override double Area() => 
            Math.PI * _radius * _radius;

        public override double Perimeter() =>
            2 * Math.PI * _radius;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape r1 = new Rectangle(5,6);
            Console.WriteLine($"{r1.Area()} {r1.Perimeter()}");

            List<Shape> list = new List<Shape>();
            list.Add(r1);
            list.Add(new Circle(10));
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
