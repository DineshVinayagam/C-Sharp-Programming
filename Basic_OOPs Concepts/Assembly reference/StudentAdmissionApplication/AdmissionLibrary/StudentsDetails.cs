

namespace AdmissionLibrary
{
    public enum Gender {Default,Male,Female,Transgender}
    public class StudentsDetails
    {
         //private string _name;//Field declaration
         //public string Name {get{return _name;} set{_name=value;}}
         
         private static int s_registernumber=3000;
         public string  RegisterNumber { get;  }
      
         public string Name{ get; set; } //Auto property
         public string FatherName{ get; set; }
         public DateTime DOB { get; set; }
         public Gender Gender { get; set; }
         public  long Phone { get; set; }
         public string  Mail { get; set; }
         public int  Physics { get; set; }
         public int  Chemistry{ get; set; }
         public int Maths { get; set; }
         

        
         //Paramaterized constructor
         public StudentsDetails(string name,string fathersname,DateTime dob,Gender gender,string mail,long phone,int physics,int chemistry,int maths)
         {
           s_registernumber++;
           RegisterNumber="SF"+s_registernumber;

           
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
         ~StudentsDetails()
         {

         }
    }
        
    } 

    

    
