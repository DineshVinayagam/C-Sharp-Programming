using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp
{
    public enum Gender{Default,Male,Female,TransGender};
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FathersName { get; set; }
        public  Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Mail { get; set; }
        public string Location { get; set; }

        public PersonalDetails()
        {
            
        }

        public PersonalDetails(string name,string fathersName,Gender gender,long mobile,DateTime dob,string mail,string location)
        {
            Name=name;
            FathersName=fathersName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Mail=mail;
            Location=location;
        }
    }
}