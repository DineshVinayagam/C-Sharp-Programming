using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Department{Default,ECE,EEE,MECH}
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID{ get; }
        public Department Department { get; set; }
        public string Year { get; set; }
       public StudentDetails(string aadharnumber,string name,string fathersname, Gender gender, long phone, Department department,string year):base( aadharnumber,name,fathersname,gender,phone)
    {
      s_studentID++;
      StudentID="SF"+s_studentID;
      Department=department;
      Year=year;

    }
    public void ShowStudent()
    {
        System.Console.WriteLine($"{StudentID} {Department} {Year}");
        ShowDetails();
        
    }
    }
}