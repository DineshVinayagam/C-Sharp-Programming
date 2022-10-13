using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Cat:Puppy
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Puppy Sound");
        }
    }
}