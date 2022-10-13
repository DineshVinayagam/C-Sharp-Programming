using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface Irectangle
    {
        int  Length { get; set; }
        int Breadth { get; set; }


        void CalculateArea();
        void GetData(int length,int breadth);
       
    }
}