using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    
    public class Donation
    {
   

        private static int s_donationid=100;
        public string DonationId { get; set; }
        public string DonorId{ get; set; }
        public DateTime DonationDate{ get; set; }
        public double Weight  { get; set; }
        public double BloodPressure { get; set; }
        public double HemoglobinCount { get; set; }


        public Donation(string donorid,DateTime donationdate,double weight,double bloodpressure,double hemoglobincount)
        {
            s_donationid++;
            DonationId="DOID"+s_donationid;
            DonorId=donorid;
            DonationDate=donationdate;
            Weight=weight;
            BloodPressure=bloodpressure;
            HemoglobinCount=hemoglobincount;

        }
      public void ShowNextDate()
        {
            DateTime nextdate=DonationDate.AddDays(60);
            System.Console.WriteLine($"you will Donate blood on: {nextdate}");

        }
    }
}