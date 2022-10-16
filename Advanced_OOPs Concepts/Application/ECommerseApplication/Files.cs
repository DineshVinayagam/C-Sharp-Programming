using System;

using System.IO;


namespace ECommerseApplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineShop"))
            {
                Directory.CreateDirectory("OnlineShop");
            }
            if(!File.Exists("OnlineShop/CustomerDetails.csv"))
            {
                File.Create("OnlineShop/CustomerDetails.csv");
            }
            if(!File.Exists("OnlineShop/ProductDetails.csv"))
            {
                File.Create("OnlineShop/ProductDetails.csv");
            }
            if(!File.Exists("OnlineShop/OrderDetails.csv"))
            {
                File.Create("OnlineShop/OrderDetails.csv");
            }
        }
        public static void ReadFile()
        {
            String[] customers=File.ReadAllLines("OnlineShop/CustomerDetails.csv");
            foreach(string data in customers)
            {
               CustomerDetails customer=new CustomerDetails(data);
               Operations.customerList.Add(customer);
            }

            String[] products=File.ReadAllLines("OnlineShop/ProductDetails.csv");
            foreach(string data in products)
            {
               ProductDetails product=new ProductDetails(data);
               Operations.productList.Add(product);
            }

            String[] orders=File.ReadAllLines("OnlineShop/OrderDetails.csv");
            foreach(string data in orders)
            {
               OrderDetails order=new OrderDetails(data);
               Operations.orderList.Add(order);
            }
            
        }
        public static void WriteFile()
        {
            string[] customers=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customers[i]=Operations.customerList[i].CustomerID+','+Operations.customerList[i].Name+','+Operations.customerList[i].City+','+Operations.customerList[i].MobileNumber+','+Operations.customerList[i].WalletBalance+','+Operations.customerList[i].EmailId;
            }
            File.WriteAllLines("OnlineShop/CustomerDetails.csv",customers);

            string[] products=new string[Operations.productList.Count];
            for(int i=0;i<Operations.productList.Count;i++)
            {
                products[i]=Operations.productList[i].ProductID+','+Operations.productList[i].ProductName+','+Operations.productList[i].Price+','+Operations.productList[i].Stock+','+Operations.productList[i].ShippingDuration;
            }
            File.WriteAllLines("OnlineShop/ProductDetails.csv",products);

            string[] orders=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orders[i]=Operations.orderList[i].OrderID+','+Operations.orderList[i].CustomerID+','+Operations.orderList[i].ProductID+','+Operations.orderList[i].TotalPrice+','+Operations.orderList[i].PurchaseDate.ToString("dd/MM/yyyy")+','+Operations.orderList[i].Quantity+','+Operations.orderList[i].OrderStatus;
            }File.WriteAllLines("OnlineShop/OrderDetails.csv",orders);
        }
    }
}