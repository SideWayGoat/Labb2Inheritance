using System;

namespace Labb2Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Pål","Male","Grey",2,7,"Woof");
            dog.TheAnimal();
            dog.DrinkWater();
            dog.TimeToEat();
            dog.MakeSound();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Horse horse = new Horse("Keth-Selhan", "Male","Black", 3,100,"Neigh");
            horse.TheAnimal();
            horse.DrinkWater();
            horse.TimeToEat();
            horse.MakeSound();
            horse.CavalryCharge();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Samoyed Maya = new Samoyed("Maya", "Female", "White", 7, 17, "Woof");
            Maya.TheAnimal();
            Maya.MakeSound();
            Maya.DrinkWater();
            Maya.TimeToEat();
            Maya.SamoyedSpecial();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Chihuahua DemonDog = new Chihuahua("Demon", "Demon", "white", 2, 2, "grrrrrrr");
            DemonDog.TheAnimal();
            DemonDog.DrinkWater();
            DemonDog.TimeToEat();
            DemonDog.MakeSound();
            DemonDog.CheckRabies();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Cat cat = new Cat("Josefin", "Female", "Red", 4, 2, "breeeow");
            cat.TheAnimal();
            cat.DrinkWater();
            cat.TimeToEat();
            cat.MakeSound();
            cat.Purr();

        }
    }
}
