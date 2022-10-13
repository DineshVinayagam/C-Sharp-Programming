using BankLibrary;
 namespace BankApplication{
    public class Operation{
        public static void MainMenu()
        {   
            string condition="";
            List<BankAccount>bankAccounts=new List<BankAccount>();
            do{
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
            System.Console.WriteLine("Do you want to enter again");
            condition=Console.ReadLine();
            BankAccount details=new BankAccount(name,fathersname,gender,dob,accountType,phone);
            
            bankAccounts.Add(details);
            System.Console.WriteLine($"Your Account Number is:{details.AccountNumber}");

            }while(condition=="yes");

            foreach(BankAccount customer in bankAccounts)
            {
                System.Console.WriteLine("Account details...");
                System.Console.WriteLine($"Name:{customer.Name}\n Fathersname:{customer.FatherName}\n Gender:{customer.Gender}\n DOB:{customer.DOB}\n Account type:{customer.AccountType}\n Phone:{customer.Phone} ");
                customer.Deposit();
                customer.Withdraw();
                customer.ShowBalance();

                
            }
            
            
            
        }
    }
 }