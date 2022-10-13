using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBbill
{
    public  class UserDetails
    {
        private static int s_meterId=1000;
        public string MeterId{ get;}
        
        public string UserName{ get; set; }
        public long Phone { get; set; }
        public string MailId { get; set; }
        public  int UnitUsed { get; set; }

        public  UserDetails(string username,long phone,string mail,int unitused)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=username;
            Phone=phone;
            MailId=mail;
            UnitUsed=unitused;
        }
        public  void UnitCost()
        {
            if(UnitUsed<100)
            {
                System.Console.WriteLine($"Cost=Free");
            }
            else if((UnitUsed>100)&&(UnitUsed<200))
            {
                int unitcost=UnitUsed*3;
                System.Console.WriteLine($"Cost={unitcost}");
            }
            else if((UnitUsed>200)&&(UnitUsed<400))
            {
                int unitcost=UnitUsed*5;
                System.Console.WriteLine($"Cost={unitcost}");
            }
            else{
                int unitcost=UnitUsed*6;
                System.Console.WriteLine($"Cost={unitcost}");
            }
        }
    
        public void Userdetails()
        {
          System.Console.WriteLine($"ID:{MeterId} Name:{UserName} Phone:{Phone} Mailid:{MailId} UnitUsed:{UnitUsed}");
        }
    }
}