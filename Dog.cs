using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Inheritance
{
    public class Dog : Animal
    {
        private readonly bool IsGoodBoi = true;
        public string Sound = "Woof";

        public Dog() : base()
        {

        }

        //Constructor for dog with 4 legs by default 
        public Dog(string _name, string _gender, string _colour, int _age, int _weight, string _sound): base(_name,_gender,_colour,_age,_weight,_sound)
        {
            this.Sound = _sound;
        }

        public Dog(string _name, string _gender, int _legs, string _colour, int _age, int _weight, string _sound) : base (_name, _gender, _legs, _colour, _age, _weight, _sound)
        {
            this.Sound = _sound;
        }
        public void GoodBoi()
        {
            if (IsGoodBoi)
            {
                Console.WriteLine("The dog is good");
            }
            else
            {
                Console.WriteLine("This can't happen, dog is always good boi");
            }
        }
        
    }
}
