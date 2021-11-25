using System;
using CoolClasses;

namespace Basics
{
    class Hero
    {
        private int _age;

        private string _name;

        public Hero(int age, string name)
        {
            if (age < 0)
                throw new ArgumentException("Age cannot be negative");

            if (name == null)
                throw new ArgumentNullException("Name cannot be null");

            _age = age;
            _name = name;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative");
                _age = value;
            }
        }

        public string Name => _name;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero(36, "Batman");
            // hero1.age = -36;
            // hero1.name = "Batman";
            Console.WriteLine($"{hero1.Name} is {hero1.Age} years old");
            hero1.Age = -50;
            hero1.Name = "Batwoman";
            Console.WriteLine($"{hero1.Name} is {hero1.Age} years old");
        }
    }
}
