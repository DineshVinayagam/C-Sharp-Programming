using System;


namespace OnlineGrocery
{
    public enum Gender{Default,Male,Female,TransGender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string  FathersName { get; set; }
        public Gender Gender{ get; set; }
        public long Mobile { get; set; }
        public DateTime DOB{ get; set; }
        public string  Mail { get; set; }


        public PersonalDetails()
        {

        }

        public PersonalDetails(string name,string fathersName,Gender gender,long mobile,DateTime dob,string mail)
        {
            Name=name;
            FathersName=fathersName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Mail=mail;
        }

        

    }
}