using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentsDetails
    {
         public StudentsDetails()
         {
            Name="Your Name";
            FatherName="Father Name";

         }
         //Paramaterized constructor
         public StudentsDetails(string name,string fathersname,DateTime dob,string gender,string mail,long phone,int physics,int chemistry,int maths)
         {
           s_registernumber++;
           Registernumber="SF"+s_registernumber;
           Name=name;
           FatherName=fathersname;
           DOB=dob;
           Gender=gender;
           Mail=mail;
           Phone=phone;
           Physics=physics;
           Chemistry=chemistry;
           Maths=maths;
         }
    }
}