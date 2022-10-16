using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical1
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalId=1000;
        public string PrincipalId{ get; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime YearOfJoining { get; set; }



        public PrincipalInfo (string name,string fathersname, DateTime dob,long phone,Gender gender, string mail,string qualification,int yearofexperience,DateTime dateofjoining):base ( name, fathersname,  dob,phone, gender,  mail)
        {
            s_principalId++;
            PrincipalId="PID"+s_principalId;
            Qualification=qualification;
            YearOfExperience=yearofexperience;
            YearOfJoining=dateofjoining;


        }
        public void ShowPrincipal()
        {
            System.Console.WriteLine($"Principal Id:{PrincipalId}\n Qualification:{Qualification}\n Year Of Experience: {YearOfExperience}\n Date Of Joining:{YearOfJoining}");
            ShowDetails();
        }   
    }
}
