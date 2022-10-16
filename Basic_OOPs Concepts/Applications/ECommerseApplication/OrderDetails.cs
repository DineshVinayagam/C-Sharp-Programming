using System;


namespace ECommerseApplication
{
    public enum OrderStatus{Default,Ordered,Cancelled}
    public class OrderDetails
    {
       private static int s_orderId=1000;
       public string OrderID { get; set; }
       public string CustomerID { get; set; }
       public string ProductID { get; set; }
       public double TotalPrice { get; set; }
       public DateTime PurchaseDate { get; set; }
       public int  Quantity { get; set; }
       public OrderStatus OrderStatus { get; set; }



        public OrderDetails(string customerId,string productId,double totalPrice,DateTime purchaseDate,int quantity,OrderStatus orderStatus)
        {
            s_orderId++;
            OrderID="OID"+s_orderId;
            CustomerID=customerId;
            ProductID=productId;
            TotalPrice=totalPrice;
            PurchaseDate=purchaseDate;
            Quantity=quantity;
            OrderStatus=orderStatus;
        }
        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            CustomerID=values[1];
            ProductID=values[2];
            TotalPrice=double.Parse(values[3]);
            PurchaseDate=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
            Quantity=int.Parse(values[5]);
            OrderStatus=Enum.Parse<OrderStatus>(values[6],true);

        }
        public void ShowOrderDetails()
        {
            System.Console.WriteLine($"OrderID: {OrderID}");
            System.Console.WriteLine($"CustomerID: {CustomerID}");
            System.Console.WriteLine($"ProductID:  {ProductID}");
            System.Console.WriteLine($"TotalPrice:  {TotalPrice}");
            System.Console.WriteLine($"PurchaseDate:{PurchaseDate}");
            System.Console.WriteLine($"Quantity:{Quantity}");
            System.Console.WriteLine($"OrderStatus:{OrderStatus}");
        }
        
    }
}