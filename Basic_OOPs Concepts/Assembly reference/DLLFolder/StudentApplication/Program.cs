using System;
using System.Collections.Generic;
using AdmissionLibrary;
 namespace CollegeAdmission
 {
  
  class Program
  {
    
    public static void Main(string[] args)
    {
        string condition="";
        List<StudentsDetails> studentList=new List<StudentsDetails>();

        do{
        System.Console.WriteLine("Enter the data to read:");
        
        System.Console.WriteLine("Enter the student name:");
        string name=Console.ReadLine();
       
        System.Console.WriteLine("Enter the fathers name:");
        string fathersname=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Date of Birth:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter the Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Enter the phone number:");
        long phone=long.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the mail:");
        string mail=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Physics mark:");
        int physics=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the Chemistry mark:");
        int chemistry=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the maths mark:");
        int maths=int.Parse(Console.ReadLine());
        
       
        System.Console.WriteLine("Admitted");
        System.Console.WriteLine("Are you want to Admit a student again:");
        condition=(Console.ReadLine());
        StudentsDetails student1=new StudentsDetails(name,fathersname,dob,gender,mail,phone,physics,chemistry,maths);
        studentList.Add(student1);
        
        
        }while(condition=="yes");

        

        
        

        foreach(StudentsDetails student in studentList)
        {

        System.Console.WriteLine("Students details:");
        System.Console.WriteLine("Your registered number is:{student1.RegisterNumber}");
        System.Console.WriteLine($"Name:{student.Name}\n Fathers Name:{student.FatherName}\n Date Of Birth:{student.DOB}\n Gender:{student.Gender}\n Mail Id:{student.Mail}\n Phone:{student.Phone}\n Physics marks:{student.Physics}\n Chemistry Marks:{student.Chemistry}/n Maths Marks:{student.Maths}");
        bool eligible=student.CheckEligibility(75.0);
        if(eligible)
        {
          System.Console.WriteLine("You are eligible for admission");
        }
        else{
          System.Console.WriteLine("You are not eligible for admission");
        }
    
        
        }
        
        
    }
  }
 }