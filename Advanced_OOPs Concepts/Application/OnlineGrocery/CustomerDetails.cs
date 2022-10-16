using System;


namespace OnlineGrocery
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private static int s_customerId=3000;
        public string CustomerID { get; }
        public double  WalletBalance { get; set; }



     

       public CustomerDetails(string name,string fathersName,Gender gender,long mobile,DateTime dob,string mail):base (name,fathersName,gender,mobile,dob,mail)
       {
        s_customerId++;
        CustomerID="CID"+s_customerId;
       


       }
       public CustomerDetails(string data)
       {
        string[] values=data.Split(',');
        s_customerId=int.Parse(values[0].Remove(0,3));
        CustomerID=values[0];
        Name=values[1];
        FathersName=values[2];
        Gender=Enum.Parse<Gender>(values[3]);
        Mobile=long.Parse(values[4]);
        DOB=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
        Mail=values[6];
        
       }

        public void WalletRecharge()
        {
           System.Console.WriteLine("Enter the amount to recharge:");
           double amount=double.Parse(Console.ReadLine());
           WalletBalance=WalletBalance+amount;
           
        }
        public void ShowCustomerDetails()
        {
           System.Console.WriteLine($"CustomerID:     {CustomerID}");
           System.Console.WriteLine($"Name:           {Name}");
           System.Console.WriteLine($"FathersName:    {FathersName}");
           System.Console.WriteLine($"Gender:         {Gender}");
           System.Console.WriteLine($"Mobile Number:  {Mobile}");
           System.Console.WriteLine($"DateOfBirth:    {DOB}");
           System.Console.WriteLine($"Mail:           {Mail}");
        }

    }
}