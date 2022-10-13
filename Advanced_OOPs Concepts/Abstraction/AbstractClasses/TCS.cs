using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class TCS:AbstractBase
    {
         
    // Abstract porperty definition
    public override string Name {get{return name;} set{name=value;}}
    //Abstract metthod definition
    public override void Salary(int dates)
    {
        Display();
        Amount =(double)dates*300;
        System.Console.WriteLine(Amount);
    }
    }
}