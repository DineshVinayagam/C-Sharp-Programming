using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical2
{
    public class Temporary:SalaryInfo
    {
        private static int s_employeeid=1000;
        public string EmployeeId { get; set; }
        public string EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF{ get; set; }
        




        public Temporary(double basicsalary,string month,string employeetype):base(basicsalary,month)
        {
           s_employeeid++;
           EmployeeId="SF"+s_employeeid;
           EmployeeType=employeetype;
           DA= (0.2*basicsalary)/100;
           HRA = (0.18*basicsalary)/100;
           PF=0;
        }
        public void CalculateSalary()
        {  
            double salary=BasicSalary+DA+HRA-PF;
            System.Console.WriteLine($"The Salary Is:{salary}");
        }
        public void ShowTemporary()
        {
            System.Console.WriteLine($"Employee ID:{EmployeeId}\n EmployeeType:{EmployeeType}\n ");
            Salary();
        }
    }
}