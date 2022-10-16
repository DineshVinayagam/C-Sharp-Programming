using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterDeligates
{
    public delegate bool FilterDeligate(Person p);
    public class Person
    {
        public string Name {get; set;}
        public int  Age { get; set; }
    }
}