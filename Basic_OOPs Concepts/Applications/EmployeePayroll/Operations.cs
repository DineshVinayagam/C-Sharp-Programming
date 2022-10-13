using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class Operations
    {
        static List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
        static EmployeeDetails currentUser=null;
        public static void MainMenu()
        {
            

             string condition="yes";
            do{
            System.Console.WriteLine("Enter The Option: 1.Registration, 2.Login, 3.Exit");
            int option=int.Parse (Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Welcome to Registration");
                    Registration();
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
                    condition="no";
                    break;
                }
            }
            }while(condition=="yes");
        }


        static void Registration()
        {
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
        
        EmployeeDetails details=new EmployeeDetails(name,role,worklocation,teamname,doj,workingdays,leave,gender);
        employeeList.Add(details);
        System.Console.WriteLine($"YourEmployee Id:{details.EmployeeID}");

        }


        public static void Login()
        {
            
            System.Console.WriteLine("Enter the Employee Id:");
            string employeeid=Console.ReadLine();
            foreach (EmployeeDetails employee in employeeList)
            {
               if(employee.EmployeeID==employeeid)
               {
                System.Console.WriteLine("Login Sucessful");
                currentUser=employee;
                SubMenu();
                
               }
            
            }
        }

        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: 1.SalaryDetails 2.EmployeeDetails 3.ExitSubmenu");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        currentUser.SalaryDetails();
                        break;
                    }
                    case 2:
                    {
                        currentUser.Employeedetails();
                        break;
                    }
                    case 3:
                    {
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yes");
        }
        }
    }
