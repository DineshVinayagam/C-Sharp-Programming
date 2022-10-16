using System;


namespace OnlineGrocery
{
    public enum BookingStatus{Default,Initialised,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3000;
        public string BookingID { get;  }
        public string  CustomerID { get; set; }
        public double  TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }


        public BookingDetails(string customerId,double totalPrice,DateTime dateofbooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingID="BID"+s_bookingId;
            CustomerID=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateofbooking;
            BookingStatus=bookingStatus;
        }
        public BookingDetails(string data)
        {
            string[] values=data.Split(',');
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            CustomerID=values[1];
            TotalPrice=double.Parse(values[2]);
            DateOfBooking=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(values[4]);
        }


        public void ShowBookingDetails()
        {
            System.Console.WriteLine($"CustomerId:      {CustomerID}");
            System.Console.WriteLine($"TotalBalance:    {TotalPrice}");
            System.Console.WriteLine($"DateOfBooking:   {DateOfBooking}");
            System.Console.WriteLine($"BookingStatus:   {BookingStatus}");
        }
    }
}