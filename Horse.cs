using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Inheritance
{
    public class Horse : Animal
    {
        public string Sound = "Neigh";


        //Constructor for Horse with 4 legs by default 
        public Horse(string _name, string _gender, string _colour, int _age, int _weight, string _sound) : base(_name, _gender, _colour, _age, _weight, _sound)
        {
            this.Sound = _sound;
        }

        public Horse(string _name, string _gender, int _legs, string _colour, int _age, int _weight, string _sound) : base (_name, _gender, _legs, _colour, _age, _weight, _sound)
        {

        }

        public void CavalryCharge()
        {
            Console.WriteLine($"You ride your trusted steed {Name} into battle!");
        }
    }
}
