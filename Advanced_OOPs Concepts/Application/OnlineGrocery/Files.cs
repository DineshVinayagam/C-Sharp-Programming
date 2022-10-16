using System;

using System.IO;
namespace OnlineGrocery
{
    public static class Files
    {
       public static void Create()
       {
          if(!Directory.Exists("Grocery"))
          {
            System.Console.WriteLine("Creating Folder");
            Directory.CreateDirectory("Grocery");
          }
          if(!File.Exists("Grocery/CustomerDetails.csv"))
          {
            System.Console.WriteLine("Creating File");
            File.Create("Grocery/CustomerDetails.csv");
          }
          if(!File.Exists ("Grocery/BookingDetails.csv"))
          {
            System.Console.WriteLine("Creating File");
            File.Create("Grocery/BookingDetails.csv");
          }
          if(!File.Exists("Grocery/ProductDetails.csv"))
          {
            System.Console.WriteLine("Creating File");
            File.Create("Grocery/ProductDetails.csv");
          }
          if(!File.Exists("Grocery/OrderDetails.csv"))
          {
            System.Console.WriteLine("Creating File");
            File.Create("Grocery/OrderDetails.csv");
          }
       }

       public static void ReadFile()
       {
        string[] customers=File.ReadAllLines("Grocery/CustomerDetails.csv");
        foreach(string data in customers)
        {
          CustomerDetails customer=new CustomerDetails(data);
          Process.customerList.Add(customer);
        }
        string[]products=File.ReadAllLines("Grocery/ProductDetails.csv");
        foreach(string data in products)
        {
          ProductDetails product=new ProductDetails(data);
          Process.productList.Add(product);
        }
        string[]bookings=File.ReadAllLines("Grocery/BookingDetails.csv");
        foreach(string data in bookings)
        {
          BookingDetails booking=new BookingDetails(data);
        }
        string[]orders=File.ReadAllLines("Grocery/OrderDetails.csv");
        foreach(string data in orders)
        {
          OrderDetails order=new OrderDetails(data);
        }
       }


       public static void WriteFile()
       {
        string[] customers=new string [Process.customerList.Count];
        for(int i=0;i<Process.customerList.Count;i++)
        {
          customers[i]=Process.customerList[i].CustomerID+','+Process.customerList[i].Name+','+Process.customerList[i].FathersName+','+Process.customerList[i].Gender+','+Process.customerList[i].Mobile+','+Process.customerList[i].DOB.ToString("dd/MM/yyyy")+','+Process.customerList[i].Mail;
        }
        File.WriteAllLines("Grocery/CustomerDetails.csv",customers);

        string[] bookings=new string[Process.bookingList.Count];
        for(int i=0;i<Process.bookingList.Count;i++)
        {
          bookings[i]=Process.bookingList[i].BookingID+','+Process.bookingList[i].CustomerID+','+Process.bookingList[i].TotalPrice+','+Process.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+','+Process.bookingList[i].BookingStatus;
        }
        File.WriteAllLines("Grocery/BookingDetails.csv",bookings);

        string[] products=new string[Process.productList.Count];
        for(int i=0;i<Process.productList.Count;i++)
        {
          products[i]=Process.productList[i].ProductID+','+Process.productList[i].ProductName+','+Process.productList[i].Quantity+','+Process.productList[i].PricePerQuantity;
        }
        File.WriteAllLines("Grocery/ProductDetails.csv",products);

        string[] orders=new string[Process.orderList.Count];
        for(int i=0;i<Process.orderList.Count;i++)
        {
          orders[i]=Process.orderList[i].OrderID+','+Process.orderList[i].BookingID+','+Process.orderList[i].ProductID+','+Process.orderList[i].PurchaseCount+','+Process.orderList[i].PriceOfOrder;
        }
        File.WriteAllLines("Grocery/OrderDetails.csv",orders);
       }
    }
}