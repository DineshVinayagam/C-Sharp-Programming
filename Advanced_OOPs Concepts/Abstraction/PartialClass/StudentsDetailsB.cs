using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentsDetails
    {
         public bool CheckEligibility(double cutOff)
         {
          double average=(double) Physics+Chemistry+Maths/3.0;
          if(average>=cutOff)
          {
            return true;
          }
          else{
            return false;
          }
         }
         /// <summary>
         /// This method is used to show the entire details of the one student including name register number
         /// </summary>
         public void ShowDetails()
        {
            System.Console.WriteLine("Registernumber is "+Registernumber);
            System.Console.WriteLine($"Name:{Name}\n Fathers Name:{FatherName}\n Date Of Birth:{DOB}\n Gender:{Gender}\n Mail Id:{Mail}\n Phone:{Phone}\n Physics marks:{Physics}\n Chemistry Marks:{Chemistry}/n Maths Marks:{Maths}");
        }
       
    }
}