using System;

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
}