using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private static int s_registrationid=3000;
        public string RegistrationID { get; }
        public  double WalletBalance{get; set;}

        public CustomerRegistration(string name,string fathersname,Gender gender,long mobile,DateTime dob,string mail,string location,double walletbalance): base (name,fathersname,gender,mobile, dob,mail,location)
        {
            s_registrationid++;
            RegistrationID="CID"+s_registrationid;
            WalletBalance=walletbalance;
        }
        public CustomerRegistration (string data)
        {
            string[] values=data.Split(',');
            s_registrationid=int.Parse(values[0].Remove(0,3));
            RegistrationID=values[0];
            Name=values[1];
            FathersName=values[2];
            Gender=Enum.Parse<Gender>(values[3],true);
            Mobile=long.Parse(values[4]);
            DOB=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            Mail=values[6];
            Location=values[7];
            WalletBalance=double.Parse(values[8]);
        }

       
        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to recharge:");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance=WalletBalance+amount;
            
        }

        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("******Customer Details******");
            System.Console.WriteLine($"Customer ID:         {RegistrationID}");
            System.Console.WriteLine($"Wallet Balance:      {WalletBalance}");
            System.Console.WriteLine($"Customer Name:       {Name}");
            System.Console.WriteLine($"Customer FatherName: {FathersName}");
            System.Console.WriteLine($"Gender:              {Gender}");
            System.Console.WriteLine($"Mobile Number:       {Mobile}");
            System.Console.WriteLine($"DateOfBirth:         {DOB}");
            System.Console.WriteLine($"Mail ID:             {Mail}");
            System.Console.WriteLine($"Loction:             {Location}");
            
        }


    }
}