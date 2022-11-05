using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Inheritance
{
    public class Cat : Animal
    {
        public string Sound = "Meow";


        //Constructor for Cat that have 4 legs by default 
        public Cat(string _name, string _gender, string _colour, int _age, int _weight, string _sound) : base(_name, _gender, _colour, _age, _weight, _sound)
        {
            this.Sound = _sound;
        }



        public void Purr()
        {
            Console.WriteLine("PrrrPRrrrPrrrr");
        }
    }
}
