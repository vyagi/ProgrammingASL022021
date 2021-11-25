using System;
using CoolClasses;

namespace Basics
{
    class Hero
    {
        private int age;

        private string name;

        public Hero(int age, string name)
        {
            if (age < 0)
                throw new ArgumentException("Age cannot be negative");

            if (name == null)
                throw new ArgumentNullException("Name cannot be null");

            this.age = age;
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return name;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero(36, "Batman");
            // hero1.age = -36;
            // hero1.name = "Batman";
            Console.WriteLine($"{hero1.GetName()} is {hero1.GetAge()} years old");
        }
    }
}
