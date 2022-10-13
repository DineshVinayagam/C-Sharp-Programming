using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public enum BloodGroup{Default,A_Positive,B_Positive,O_Positive,AB_Positive}
    public class DonorDetails
    {

        private static int s_donorId=1000;
        public string DonorId { get;  }
        public string Name { get; set; }
        public long Mobile { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public int  Age { get; set; }
        public DateTime LastDonation { get; set; }



        public DonorDetails(string name,long mobile,BloodGroup bloodgroup,int age,DateTime lastdonation)
        {
            s_donorId++;
            DonorId="DID"+s_donorId;
            Name=name;
            Mobile=mobile;
            BloodGroup=bloodgroup;
            LastDonation=lastdonation;
        }

        public void GetDonationDetails()
        {
            System.Console.WriteLine($"DonorId:      {DonorId}");
            System.Console.WriteLine($"Name:         {Name}");
            System.Console.WriteLine($"Mobile:       {Mobile}");
            System.Console.WriteLine($"BloodGroup:   {BloodGroup}");
            System.Console.WriteLine($"LastDonation: {LastDonation}");
        }

        public void ShowNextEligibilityDate()
        {
            DateTime nextdate=LastDonation.AddDays(60);
            System.Console.WriteLine($"you will Donate blood on: {nextdate}");

        }
        

    }
}