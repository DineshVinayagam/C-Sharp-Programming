using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public enum Department{Default,ECE,EEE,MECH}
    public class StudentDetails:PersonalDetails,IMarkDetails
    {
        private static int s_studentID=1000;
        public string StudentID{ get; }
        public Department Department { get; set; }
        public string Year { get; set; }
        public int Physics {get; set;}
        public int Chemistry {get ; set;}
       public int Maths {get; set;}
       public int Total {get;set;}
       public double Average {get; set;}

       public void GetMark(int physics,int chemistry,int maths)
       {
        Physics=physics;
        Chemistry=chemistry;
        Maths=maths;
       }
       public void Calculate()
       {
         Total=Physics+Chemistry+Maths;
         Average=(double)Total/3.0;
       }

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
    public void ShowMark()
    {
        System.Console.WriteLine($"Physics:{Physics} Chemistry:{Chemistry} Maths:{Maths} Total:{Total} Average:{Average}");
    }
    }
}