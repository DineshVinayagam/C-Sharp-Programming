using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private static int s_accountnumber=12345678;
        public int AccountNumber{ get;}
        public string Name{ get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        public string AccountType{ get; set; }
         public long Phone { get; set; }
         public long Balance{get; set;}

        public BankAccount(string name,string fathersname,string gender, DateTime dob, string accountType,long phone)
        {
            s_accountnumber++;
            AccountNumber=s_accountnumber;
            Name=name;
            FatherName=fathersname;
            Gender=gender;
            DOB=dob;
            AccountType=accountType;
            Phone=phone;
            
            


        }
        public void Deposit()
        {
           System.Console.WriteLine("Enter the amount to deposit:");
           int deposit=int.Parse(Console.ReadLine());
           System.Console.WriteLine($"You deposited amount is:{deposit}");
           Balance=Balance+deposit;
           System.Console.WriteLine($"Your balance is :{Balance}");

        }
        public void Withdraw()
        {
           System.Console.WriteLine("Enter the amount to withdraw");
           int withdraw=int.Parse(Console.ReadLine());
           Balance=Balance-withdraw;
           System.Console.WriteLine($"Your balance is:{Balance}");
        }
        public void ShowBalance()
        {
           System.Console.WriteLine($"Your balance is:{Balance}");
        }
        public void ShowDetails()
        {
             System.Console.WriteLine("Account details...");
             System.Console.WriteLine($"Name:{Name}\n Fathersname:{FatherName}\n Gender:{Gender}\n DOB:{DOB}\n Account type:{AccountType}\n Phone:{Phone} ");
        }
        ~BankAccount()
        {

        }
    }
}