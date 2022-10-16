using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical1
{
    public enum Department{Default,ECE,EEE,CSE,MECH}
    public class TeacherInfo:PersonalInfo
    {
        private static int s_teacherId=1000;
        public string TeacherId { get; }
        public Department Department { get; set; }
        public string  Subject { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }


        public TeacherInfo (string name,string fathersname, DateTime dob,long phone,Gender gender, string mail,Department department,string subject,string qualification,int yearofexperience,DateTime dateofjoining):base ( name, fathersname,  dob,phone, gender,  mail)
        {
            s_teacherId++;
            TeacherId="SF"+s_teacherId;
            Department=department;
            Subject=subject;
            Qualification=qualification;
            YearOfExperience=yearofexperience;
            DateOfJoining=dateofjoining;


        }
        public void ShowTeacher()
        {
           System.Console.WriteLine($"Teacher Id:{TeacherId}\n Department:{Department}\n");
           System.Console.WriteLine($"Subject:{Subject}\n Qualification:{Qualification}\n Year Of Experience: {YearOfExperience}\n Date Of Joining:{DateOfJoining}");
           ShowDetails();
        }
    }
}