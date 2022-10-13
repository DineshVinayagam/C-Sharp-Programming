using System;
using System.Collections.Generic;
 namespace PartialClass
 {
  class Program
  {
    public static void Main(string[] args)
    {
       
        
        

        foreach(StudentsDetails student in studentList)
        {
        System.Console.WriteLine("Students details:");
        System.Console.WriteLine($"Name:{student.Name}\n Fathers Name:{student.FatherName}\n Date Of Birth:{student.DOB}\n Gender:{student.Gender}\n Mail Id:{student.Mail}\n Phone:{student.Phone}\n Physics marks:{student.Physics}\n Chemistry Marks:{student.Chemistry}/n Maths Marks:{student.Maths}");
        }
        
        
    }
  }
 }