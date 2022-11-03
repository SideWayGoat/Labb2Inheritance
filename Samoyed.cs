using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Inheritance
{
    public class Samoyed : Dog
    {
        //Constructor for Samoyed with 4 legs by default 
        public Samoyed(string _name, string _gender, string _colour, int _age, int _weight, string _sound): base(_name,_gender,_colour,_age,_weight,_sound)
        {

        }
        public void SamoyedSpecial()
        {
            Console.WriteLine("Samoyed dogs are most often white, and can have a brown tint to their double-layer coat which is naturally dirt repellent");
        }
    }
}
