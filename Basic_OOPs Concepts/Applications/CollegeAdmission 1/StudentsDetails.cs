using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// used to process the college admission using this platform
/// </summary>

namespace CollegeAdmission1
{
    /// <summary>
    /// It is used to select the students gender details
    /// </summary>
    public enum Gender {Default,Male,Female,Transgender}
    /// <summary>
    /// class<see cref="Studentsdetails"/> used to collect the students details for the admission process
    /// </summary>
    public class StudentsDetails
    {
         //private string _name;//Field declaration
         //public string Name {get{return _name;} set{_name=value;}}
         
         /// <summary>
         /// Static field used to auto increment and it uniquely for each student
         /// </summary>
         private static int s_registernumber=3000;
         /// <summary>
         /// This Register number is used to get the register number from the server to the user
         /// </summary>
        
         public string  RegisterNumber { get;  }
         /// <summary>
         /// This property is used to get the student name
         /// </summary>
        
         public string Name{ get; set; } //Auto property
         /// <summary>
         /// This property is used to get the fathersname
         /// </summary>
         
         public string FatherName{ get; set; }
         /// <summary>
         /// This property is used to get the dob from the user
         /// </summary>
         
         public DateTime DOB { get; set; }
         /// <summary>
         /// This property is used to get the Gender from the user
         /// </summary>
         
         public Gender Gender { get; set; }
         /// <summary>
         /// This property is used to get the phone number from the user
         /// </summary>
         
         public  long Phone { get; set; }
         /// <summary>
         /// This property is used to get the MailId from the user
         /// </summary>
         
         public string  Mail { get; set; }
         /// <summary>
         /// This Property is used to get the Physics mark from the user to calculate the cutoff
         /// </summary>
         
         public int  Physics { get; set; }
         /// <summary>
         /// This Property is used to get the Chemistry mark from the user to calculate the cutoff
         /// </summary>
         
         public int  Chemistry{ get; set; }
         /// <summary>
         /// This Property is used ot get the Maths mark from the user to calculate the cutoff
         /// </summary>
         /// <value></value>
         public int Maths { get; set; }
         

        
         //Paramaterized constructor
         /// <summary>
         /// This field is constructor of< see cref="StudentInfo"/> class used to initialize values to its properties
         /// 
         /// </summary>
         /// <param name="name">Parameter name used to initialize a Student's Name to Name property</param> 
         /// <param name="fathersname">Parameter name used to initialize a Student's fathers name to Name property</param>
         /// <param name="dob">Parameter name used to initialize a Student's DOB to dob </param>
         /// <param name="gender">Parameter name used to initialize a Student's Gender to gender </param>
         /// <param name="mail">Parameter name used to initialize a Student's Mail Id to Mail Id</param>
         /// <param name="phone">Parameter name used to initialize a Student's Phone number to Phone</param>
         /// <param name="physics">Parameter name used to initialize a Student's Physics marks to physics marks</param>
         /// <param name="chemistry">Parameter name used to initialize a Student's Chemistry marks to chemistry marks</param>
         /// <param name="maths">Parameter name used to initialize a Student's Maths marks to maths marks</param>
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
         /// <summary>
         ///This method is used to checking eligibility of the  student for the admission 
         /// </summary>
         /// <param name="cutOff">It is used to provide the cutoff value of the student for the admission</param>
         /// <returns>It returns true false </returns>
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
            System.Console.WriteLine("Registernumber is "+RegisterNumber);
            System.Console.WriteLine($"Name:{Name}\n Fathers Name:{FatherName}\n Date Of Birth:{DOB}\n Gender:{Gender}\n Mail Id:{Mail}\n Phone:{Phone}\n Physics marks:{Physics}\n Chemistry Marks:{Chemistry}/n Maths Marks:{Maths}");
        }
       
         ~StudentsDetails()
         {

         }
    }
        
    } 

    

    
