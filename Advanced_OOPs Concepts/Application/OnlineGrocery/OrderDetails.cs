using System;


namespace OnlineGrocery
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderID { get;  }
        public string BookingID{ get; set; }
        public string ProductID { get; set; }
        public int PurchaseCount{ get; set; }
        public double PriceOfOrder { get; set; }


        public OrderDetails(string bookingId,string productId,int purchaseCount,double priceoforder)
        {
            s_orderId++;
            OrderID="OID"+s_orderId;
            BookingID=bookingId;
            ProductID=productId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceoforder;
        }

        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            BookingID=values[1];
            ProductID=values[2];
            PurchaseCount=int.Parse(values[3]);
            PriceOfOrder=double.Parse(values[4]);
        }


        public void ShowOrderDetails()
        {
            System.Console.WriteLine($"Order ID:         {OrderID}");
            System.Console.WriteLine($"Booking Id:       {BookingID}");
            System.Console.WriteLine($"ProductId:        {ProductID}");
            System.Console.WriteLine($"PurchaseCount:    {PurchaseCount}");
            System.Console.WriteLine($"Price:            {PriceOfOrder}");
        }
    }
}