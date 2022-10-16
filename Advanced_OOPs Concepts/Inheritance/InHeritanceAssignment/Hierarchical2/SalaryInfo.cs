using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical2
{
    public class SalaryInfo
    {
        public double BasicSalary { get; set; }
        public string Month { get; set; }



        public SalaryInfo(double basicsalary,string month)
        {
            BasicSalary=basicsalary;
            Month=month;

        }
        public void Salary()
        {
           System.Console.WriteLine($"Basic Salary is:{BasicSalary}\n Month:{Month}");
        }
    }

}