using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical1
{
    public enum Department1{Default,ECE,EEE,CSE,MECH}
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentid=1000;
        public string StudentID { get;  }
        public string Degree{ get; set; }
        public Department1 Department { get; set; }
        public int Semester { get; set; }





        public StudentInfo(string name,string fathersname, DateTime dob,long phone,Gender gender, string mail,string degree,Department1 department,int semester):base( name,fathersname, dob,phone,gender,  mail)
        {
            s_studentid++;
            StudentID="SID"+s_studentid;
            Degree=degree;
            Department=department;
            Semester=semester;
        }

        public void ShowStudent()
        {
            System.Console.WriteLine($"Student ID:{StudentID}\n Degree:{Degree}\n Department:{Department}");
            System.Console.WriteLine($"Semester:{Semester}");
            ShowDetails();
        }
    }
}