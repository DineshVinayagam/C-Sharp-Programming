using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentsDetails
    {
         //private string _name;//Field declaration
         //public string Name {get{return _name;} set{_name=value;}}
         private static int s_registernumber=3000;
         public  string Registernumber { get; set; }
         public string Name{ get; set; } //Auto property
         public string FatherName{ get; set; }
         public DateTime DOB { get; set; }
         public string Gender { get; set; }
         public  long Phone { get; set; }
         public string  Mail { get; set; }
         public int  Physics { get; set; }
         public int  Chemistry{ get; set; }
         public int Maths { get; set; }

        
        
         }
    }
        
     

    

    
