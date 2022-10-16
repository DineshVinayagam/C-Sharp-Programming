using System;
using System.Collections.Generic;
using System.IO;
namespace FoodApp
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Food"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Food");
            }
             if(!File.Exists("Food/CustomerRegistration.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/CustomerRegistration.csv");
            }
            
            if(!File.Exists("Food/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/FoodDetails.csv");
            }
             
             if(!File.Exists("Food/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/BookingDetails.csv");
            }
             
             if(!File.Exists("Food/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/OrderDetails.csv");
            }
        }

        public static void ReadFile()
        {
            string[] customers=File.ReadAllLines("Food/CustomerRegistration.csv");
            foreach(string data in customers)
            {
                 CustomerRegistration customer=new CustomerRegistration(data);
                 Operations.customerList.Add(customer);
            }

            string[] foods=File.ReadAllLines("Food/FoodDetails.csv");
            foreach(string data in foods)
            {
                FoodDetails food=new FoodDetails(data);
                Operations.foodsList.Add(food);
            }
            string[] booking=File.ReadAllLines("Food/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails book=new BookingDetails(data);
                Operations.bookingList.Add(book);
            }

            string[] orders=File.ReadAllLines("Food/OrderDetails.csv");
            foreach(string data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operations.orderList.Add(order);
            }

        }
        public static void WriteFiles()
        {
            string[] customers=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customers[i]=Operations.customerList[i].RegistrationID+','+Operations.customerList[i].Name+','+Operations.customerList[i].FathersName+','+Operations.customerList[i].Gender+','+Operations.customerList[i].Mobile+','+Operations.customerList[i].DOB.ToString("dd/MM/yyyy")+','+Operations.customerList[i].Mail+','+Operations.customerList[i].Location+','+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("Food/CustomerRegistration.csv",customers);

            string[] foods=new string[Operations.foodsList.Count];
            for(int i=0;i<Operations.foodsList.Count;i++)
            {
                foods[i]=Operations.foodsList[i].FoodID+','+Operations.foodsList[i].FoodName+','+Operations.foodsList[i].FoodCount+','+Operations.foodsList[i].FoodPrice;
            }
            File.WriteAllLines("Food/FoodDetails.csv",foods);

            string[] bookings=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookings[i]=Operations.bookingList[i].BookingID+','+Operations.bookingList[i].RegistrationID+','+Operations.bookingList[i].TotalPrice+','+Operations.bookingList[i].DateOfPurchase.ToString("dd/MM/yyyy")+','+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("Food/BookingDetails.csv",bookings);

            string[] orders=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orders[i]=Operations.orderList[i].OrderID+','+Operations.orderList[i].BookingID+','+Operations.orderList[i].FoodID+','+Operations.orderList[i].PurchaseCount+','+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("Food/OrderDetails.csv",orders);
        }
    }
}