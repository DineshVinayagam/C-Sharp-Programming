using System;


namespace ECommerseApplication
{
    public class ProductDetails
    {
        private static int s_productId=100;
        public string  ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int ShippingDuration { get; set; }



        public ProductDetails(string productName,double price,int stock,int shippingDuration)
        {
            s_productId++;
            ProductID="PID"+s_productId;
            ProductName=productName;
            Price=price;
            Stock=stock;
            ShippingDuration=shippingDuration;
        }
        public ProductDetails(string data)
        {
            string[] values=data.Split(',');
            s_productId=int.Parse(values[0].Remove(0,3));
            ProductID=values[0];
            ProductName=values[1];
            Price=double.Parse(values[2]);
            Stock=int.Parse(values[3]);
            ShippingDuration=int.Parse(values[4]);
        }

        public void ShowProductDetails()
        {
            System.Console.WriteLine($"ProductId: {ProductID}");
            System.Console.WriteLine($"ProductName:{ProductName}");
            System.Console.WriteLine($"Price:       {Price}");
            System.Console.WriteLine($"Stock:       {Stock}");
            System.Console.WriteLine($"ShippingDuration: {ShippingDuration}");
        }
    }
}