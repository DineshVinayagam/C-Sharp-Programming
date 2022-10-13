using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employeeregisterid=1000;
        public string EmployeeregisterId { get; }
        public DateTime RegistrationDate {get; set;}



        public EmploymentDetails(string studentID,string aadharnumber,string name,string fathersname, Gender gender, long phone, Department department):base ( studentID,aadharnumber,name,fathersname,gender,phone,department)
        {
          s_employeeregisterid++;
          EmployeeregisterId="EID"+s_employeeregisterid;
          RegistrationDate=DateTime.Now;
        }

        public void ShowEmployementDetails()
        {
          System.Console.WriteLine($"EmployementID:{EmployeeregisterId}");
          ShowStudent();
          System.Console.WriteLine($"RegistrationDate:{RegistrationDate.ToString("dd/MM/yyyy")}");
        }
    }

}