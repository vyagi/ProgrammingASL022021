using System;
using CoolClasses;

namespace Basics
{
    class Hero
    {
        public int age;

        public string name;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero();
            Console.WriteLine(hero1.name);
            var a = new Animal();
        }
    }
}
