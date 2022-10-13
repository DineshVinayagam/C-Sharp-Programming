using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public class Operations
    {
        static List<BankAccount>bankAccounts=new List<BankAccount>();
        static BankAccount currentUser=null;
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
          System.Console.WriteLine("Enter your details...");
            System.Console.WriteLine("Enter Your Name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your father Name:");
            string fathersname=Console.ReadLine();
            System.Console.WriteLine("Enter your gender:");
            string gender=Console.ReadLine();
            System.Console.WriteLine("Enter your date of birth:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your account type:");
            string accountType=Console.ReadLine();
            System.Console.WriteLine("Enter your phone number:");
            long phone=long.Parse(Console.ReadLine());
            //System.Console.WriteLine("Account Balance:");
            //long balance=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Account created.");
            BankAccount details=new BankAccount(name,fathersname,gender,dob,accountType,phone);
            bankAccounts.Add(details);
            System.Console.WriteLine($"Your Account Number is:{details.AccountNumber}");
        }
        public static void Login()
        {
           System.Console.WriteLine("Enter the Accountnumber:");
            int accountnumber=int.Parse(Console.ReadLine());
            foreach (BankAccount user in bankAccounts)
            {
               if(user.AccountNumber==accountnumber)
               {
                System.Console.WriteLine("Login Sucessful");
                currentUser=user;
                SubMenu();
                
               }
            
            }
        }

        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: 1.Deposit 2.Withdraw 3.ShowBalance 4.ShowDetails 5.ExitSubmenu");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        currentUser.Deposit();
                        break;
                    }
                    case 2:
                    {
                        currentUser.Withdraw();
                        break;
                    }
                    case 3:
                    {
                        currentUser.ShowBalance();
                        break;
                    }
                    case 4:
                    {
                        currentUser.ShowDetails();
                        break;
                    }
                    case 5:
                    {
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yes");
        }
    }
}