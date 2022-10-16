using System;


namespace OnlineGrocery
{
    public class ProductDetails
    {
        private static int s_productId=100;
        public string ProductID { get;  }
        public string ProductName { get; set; }
        public int  Quantity { get; set; }
        public double PricePerQuantity { get; set; }



        public ProductDetails(string productName,int quantity,double priceperQuantity)
        {
            s_productId++;
            ProductID="PID"+s_productId;
            ProductName=productName;
            Quantity=quantity;
            PricePerQuantity=priceperQuantity;
        }
        public ProductDetails(string data)
        {
            string[] values=data.Split(',');
            s_productId=int.Parse(values[0].Remove(0,3));
            ProductID=values[0];
            ProductName=values[1];
            Quantity=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);
        }
        
        public void ShowProductDetails()
        {
            System.Console.WriteLine($"ProductID:         {ProductID}");
            System.Console.WriteLine($"ProductName:       {ProductName}");
            System.Console.WriteLine($"Quantity:          {Quantity}");
            System.Console.WriteLine($"PricePerQuantity:  {PricePerQuantity}");
        }
    }

    
}