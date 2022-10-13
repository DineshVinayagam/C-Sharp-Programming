using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Dog:Animal
    {
        //sealed method
        public override void MakeSound()
        {
            System.Console.WriteLine("Dog Sound");
        }
    }
}