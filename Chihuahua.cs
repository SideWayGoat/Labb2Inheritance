using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Inheritance
{
    public class Chihuahua : Dog
    {
        public Chihuahua(string _name, string _gender, string _colour, int _age, int _weight, string _sound) : base(_name, _gender, _colour, _age, _weight, _sound)
        {

        }
        public void CheckRabies()
        {
            Console.WriteLine("There is currently no way to know if a Chihuahua gets rabies since they would act the same way no matter what");
        }
    }
}
