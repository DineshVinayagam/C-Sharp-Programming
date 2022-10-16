using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3000;
        public string BookingID { get; set; }
        public string RegistrationID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public BookingStatus BookingStatus { get; set; }



        public BookingDetails(string registrationId,double totalPrice,DateTime dateofPurchase,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingID="BID"+s_bookingId;
            RegistrationID=registrationId;
            TotalPrice=totalPrice;
            DateOfPurchase=dateofPurchase;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string data)
        {
            string[] values=data.Split(',');
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            RegistrationID=values[1];
            TotalPrice=double.Parse(values[2]);
            DateOfPurchase=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(values[4]);
            
            
        }
        public void ShowBookingDetails()
        {
            System.Console.WriteLine($"Booking ID:    {BookingID}");
            System.Console.WriteLine($"RegistrationID:{RegistrationID}");
            System.Console.WriteLine($"Total Price:   {TotalPrice}");
            System.Console.WriteLine($"DateOfPurchase:{DateOfPurchase}");
            System.Console.WriteLine($"BookingStatus: {BookingStatus}");
        }
    }
}