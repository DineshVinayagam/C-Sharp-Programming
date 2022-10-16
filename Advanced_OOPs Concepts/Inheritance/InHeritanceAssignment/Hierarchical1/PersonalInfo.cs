using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical1
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FathersName { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public Gender Gender { get; set; }
        public string Mail { get; set; }



        public PersonalInfo(string name,string fathersname, DateTime dob,long phone,Gender gender, string mail )
        {
            Name=name;
            FathersName=fathersname;
            DOB=dob;
            Phone=phone;
            Gender=gender;
            Mail=mail;

        }
        public void ShowDetails()
        {
            System.Console.WriteLine($"Name:{Name}\n FathersName:{FathersName}\n Dob:{DOB}\n Phone:{Phone}\n Gender:{Gender} Mail:{Mail}");
        }
    }
}