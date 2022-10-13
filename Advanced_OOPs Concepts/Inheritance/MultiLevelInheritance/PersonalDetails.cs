using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public enum Gender{Default, Male , Female, Transgender}
    public class PersonalDetails
    {
        
        private static int s_aadharnumber=1000;
        public string AadharNumber { get; }
        public string  Name  { get; set; }
        public string FathersName{ get; set; }
        public Gender Gender{get; set;}
        public long Phone { get; set; }


        public PersonalDetails(string name,string fathersname, Gender gender, long phone)
        {
            s_aadharnumber++;
            AadharNumber="AID"+s_aadharnumber;
            Name=name;
            FathersName=fathersname;
            Gender=gender;
            Phone=phone;
        }

        public PersonalDetails(string aadharnumber,string name,string fathersname, Gender gender, long phone)
        {
            AadharNumber=aadharnumber;
            Name=name;
            FathersName=fathersname;
            Gender=gender;
            Phone=phone;
        }
        public void ShowDetails()
        {  
            System.Console.WriteLine($"{AadharNumber} {Name} {FathersName} {Gender} {Phone}");
        }

    }
}