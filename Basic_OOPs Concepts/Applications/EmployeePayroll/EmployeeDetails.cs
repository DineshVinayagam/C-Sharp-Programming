using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public enum Location{Default,Madura,Eymard}
    public enum Gender{Default,Male,Female,Transgender}
    public class EmployeeDetails
    {
        private static int s_employeeId=1000;
        public string EmployeeID { get; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Location WorkLocation { get; set; }
        public string TeamName  { get; set; }
        public DateTime DOJ { get; set; }
        public int WorkingDays { get; set; }
        public int  Leave { get; set; }
        public Gender Gender { get; set; }
        public EmployeeDetails(string name,string role, Location worklocation,string teamname,DateTime doj,int workingdays,int leave,Gender gender)
    {   
        s_employeeId++;
        EmployeeID="SF"+s_employeeId;
        Name=name;
        Role=role;
        WorkLocation=worklocation;
        TeamName=teamname;
        DOJ=doj;
        WorkingDays=workingdays;
        Leave=leave;
        Gender=gender;
    }
     public void SalaryDetails()
     {
         long salary=(long)(WorkingDays-Leave)*500;
        System.Console.WriteLine($"Salary of the employee is :{salary}");
     }

     public void Employeedetails()
     {
        System.Console.WriteLine($"EmployeeId:{EmployeeID} Name:{Name} Role:{Role} WorkLocation:{WorkLocation} TeamName:{TeamName} Date Of Joining:{DOJ} Working Days:{WorkingDays} Leave:{Leave} Gender:{Gender}");
     }
    }
    
}
    
