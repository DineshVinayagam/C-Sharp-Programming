using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBbill
{
    public static class Operations
    {
        static UserDetails currentUser=null;
        static List<UserDetails> list=new List<UserDetails>();
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
        public static void Registration()
        {
           System.Console.WriteLine("Enter the UserName:");
        string username=Console.ReadLine();
        System.Console.WriteLine("Enter the Phone Number:");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Mail Id:");
        string mail=Console.ReadLine();
        System.Console.WriteLine("Enter the units used:");
        int unitused=int.Parse(Console.ReadLine());
        UserDetails details=new UserDetails(username,phone,mail,unitused);
        list.Add(details);
        System.Console.WriteLine("Meter Id Of the User:"+details.MeterId);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter the Meter Id:");
            string meterid=Console.ReadLine();
            foreach (UserDetails detail in list)
            {
               if(detail.MeterId==meterid)
               {
                System.Console.WriteLine("Login Sucessful");
                currentUser=detail;
                SubMenu();
                
               }
            
            }
        }

        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: 1.UnitCost 2.UserDetails 3.ExitSubmenu");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        currentUser.UnitCost();
                        break;
                    }
                    case 2:
                    {
                        currentUser.Userdetails();
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