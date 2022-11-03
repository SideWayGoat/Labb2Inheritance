using System;

namespace Labb2Inheritance
{
    public class Animal
    {
        public readonly string Name = "Nameless";
        private readonly string Gender = "Undefined";
        private readonly int Legs = 4;
        private readonly string Colour = "Invisible";
        private readonly int Age = 0;
        private readonly int Weight = 0;
        private readonly string Sound = "Noiseless";

        public Animal()
        {

        }
        public Animal(string _name, string _gender, string _colour, int _age, int _weight, string _sound)
        {
            this.Name = _name;
            this.Gender = _gender;
            this.Colour = _colour;
            this.Age = _age;
            this.Weight = _weight;
            this.Sound = _sound;
        }

        public Animal(string _name, string _gender, int _legs, string _colour, int _age, int _weight, string _sound)
        {
            this.Name = _name;
            this.Gender = _gender;
            this.Legs = _legs;
            this.Colour = _colour;
            this.Age = _age;
            this.Weight = _weight;
            this.Sound = _sound;
        }

        public void TheAnimal()
        {
            Console.WriteLine($"The name is: {Name}\nGender: {Gender}\nNumber of legs: {Legs}\nColour: {Colour}\nAge: {Age} years\nWeight: {Weight} kg");
        }

        public void TimeToEat()
        {
            Console.WriteLine($"{Name} goes NomNomNomNomNom");
        }

        public void SleepingAnimal()
        {
            Console.WriteLine($"{Name} is sleeping ~~~ zZzZzZzZzZzZzZzZzZzZzZzZzZzZ");
        }

        public void DrinkWater()
        {
            Console.WriteLine("SchlupSchlurp glugglugg");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} goes {Sound}"); 
        }
    }
}
