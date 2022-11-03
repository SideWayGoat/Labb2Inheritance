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
            

            Horse horse = new Horse("Keth-Selhan", "Male","Black", 3,100,"Neigh");
            horse.TheAnimal();
            horse.MakeSound();
            horse.CavalryCharge();

            Samoyed Maya = new Samoyed("Maya", "Female", "White", 7, 17, "Woof");
            Maya.TheAnimal();
            Maya.MakeSound();
            Maya.DrinkWater();
            Maya.TimeToEat();
            Maya.SamoyedSpecial();
            Chihuahua demon = new Chihuahua("Demon", "Demon", "white", 2, 2, "grrrrrrr");
            demon.TheAnimal();
            demon.CheckRabies();
            demon.MakeSound();
        }
    }
}
