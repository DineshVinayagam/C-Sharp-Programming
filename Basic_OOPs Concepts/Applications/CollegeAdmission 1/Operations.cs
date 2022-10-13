using System;
using System.Collections.Generic;

namespace CollegeAdmission1 
{
    public static class Operations
    { 
        static StudentsDetails currentStudent=null;
        static List<StudentsDetails>studentList=new List<StudentsDetails>();
        public static void MainMenu()
        {
            string choice="yes";

            do{

            
            System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit");
            int option=int.Parse(Console.ReadLine());
            
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registeration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
                default :
                {
                    System.Console.WriteLine("Enter the correct option...");
                    break;
                }
             }
            }while(choice=="yes");

            
        }
        public static void Registeration()
        {
            System.Console.WriteLine("Enter the data to read...");
        
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
        //System.Console.WriteLine("Are you want to Admit a student again:");
       
        
        StudentsDetails student1=new StudentsDetails(name,fathersname,dob,gender,mail,phone,physics,chemistry,maths);
        studentList.Add(student1);
        
        System.Console.WriteLine($"Your registered number is:{student1.RegisterNumber}");
       
        //System.Console.WriteLine("");
        
        }
        public static void Login()
        {
           System.Console.WriteLine("Enter your Register Number");
           string registernumber=Console.ReadLine().ToUpper();
           foreach(StudentsDetails student in studentList)
           {
            if(student.RegisterNumber==registernumber)
            {
                System.Console.WriteLine("Login Successful");
                currentStudent=student;
                SubMenu();
            }
           }
           
        }
        public static void SubMenu()
        {
            string choice="yes";
            do{
               System.Console.WriteLine("Select SubMenu Details..");
               System.Console.WriteLine("1.ShowDetails 2.CheckEligiblity 3.ExitSubmenu");
               int option=int.Parse(Console.ReadLine());
               
               switch(option)
               {
                case 1:
                {
                    System.Console.WriteLine("ShowDetails");
                    currentStudent.ShowDetails();
                    break;
                }
                case 2:
                {   System.Console.WriteLine("CheckEligibility");
                     bool eligible=currentStudent.CheckEligibility(75.0);
                     if(eligible)
                        {
                           System.Console.WriteLine("You are eligible for admission");
                         }
                    else{
                              System.Console.WriteLine("You are not eligible for admission");
                         }
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit submenu");
                    choice="no";
                    break;
                }
               }
            }while(choice=="yes");
        }
    }

}
