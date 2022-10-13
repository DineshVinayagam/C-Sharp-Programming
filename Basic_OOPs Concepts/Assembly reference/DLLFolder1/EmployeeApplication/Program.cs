using System;
 using System.Collections.Generic;
 using EmployeeLibrary;
  namespace EmployeeApplication;
   class Program
   {
     public static void Main(string[] args)
     {  
        string condition=" ";
        List<EmployeeDetails>employeeList=new List<EmployeeDetails>();
        do{
        System.Console.WriteLine("Enter the Employee name:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter the Employee role:");
        string role=Console.ReadLine();
        
        System.Console.WriteLine("Enter the work location:");
        Location worklocation=Enum.Parse<Location>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter the Team Name:");
        string teamname=Console.ReadLine();
        System.Console.WriteLine("Enter the Date of Joining");
        DateTime doj=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter the working days:");
        int workingdays=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Leave taken");
        int leave=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("The details are entered:");
        System.Console.WriteLine("Do you want to continue again?");
        condition=Console.ReadLine();
        EmployeeDetails details=new EmployeeDetails(name,role,worklocation,teamname,doj,workingdays,leave,gender);
        employeeList.Add(details);
        }while (condition=="yes");

        
        foreach(EmployeeDetails detail in employeeList)
        {
          System.Console.WriteLine("The employee details....");
          System.Console.WriteLine($"The details are: Employee Id:{detail.EmployeeID} Name:{detail.Name}\n Employeerole:{detail.Role}\n Work Location: {detail.WorkLocation}\n Team Name:{detail.TeamName}\n Date Of Joining:{detail.DOJ}\n WorkingDays:{detail.WorkingDays}\n Leave Taken:{detail.Leave}\n Gender:{detail.Gender}");
          detail.SalaryDetails();
        }
     }
   }