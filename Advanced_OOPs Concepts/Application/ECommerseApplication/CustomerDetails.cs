using System;


namespace ECommerseApplication
{
    public class CustomerDetails
    {
        private static int s_customerId=1000;
        public string CustomerID { get; }
        public string  Name { get; set; }
        public string  City { get; set; }
        public long  MobileNumber { get; set; }
        public double WalletBalance { get; set; }
        public string EmailId { get; set; }



        public CustomerDetails(string name,string city, long mobileNumber,double walletBalance,string emailId)
        {
            s_customerId++;
            CustomerID="CID"+s_customerId;
            Name=name;
            City=city;
            MobileNumber=mobileNumber;
            WalletBalance=walletBalance;
            EmailId=emailId;

        }
        public CustomerDetails(string data)
        {
            string[] values=data.Split(',');
            s_customerId=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            Name=values[1];
            City=values[2];
            MobileNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);
            EmailId=values[5];
        }

        public void WalletRecharge()
        {
           
                System.Console.WriteLine("Enter the amount to add:");
                long amount=long.Parse(Console.ReadLine());
                WalletBalance=WalletBalance+amount;
                System.Console.WriteLine($"The wallet Balance is:{WalletBalance}");
            
        }
        public void ShowCustomerDetails()
        {
            System.Console.WriteLine($"CustomerID: {CustomerID}");
            System.Console.WriteLine($"Name:   {Name}");
            System.Console.WriteLine($"City: {City}");
            System.Console.WriteLine($"MobileNumber: {MobileNumber}");
            System.Console.WriteLine($"WalletBalance:{WalletBalance}");
            System.Console.WriteLine($"EmailID:{EmailId}");
        }
       
    }
}