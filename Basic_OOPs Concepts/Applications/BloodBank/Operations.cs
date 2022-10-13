using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public static class Operations
    {
        static  List<DonorDetails> donorlist=new List<DonorDetails>();
        static List<Donation> donationlist=new List<Donation>();

        static DonorDetails currentDonor=null;
        public static void  MainMenu()
        {
            string choice="yes";

            do{

            
            System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit");
            int option=int.Parse(Console.ReadLine());
            
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registeration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
                default :
                {
                    System.Console.WriteLine("Enter the correct option...");
                    break;
                }
             }
            }while(choice=="yes");
        }


        static void Registeration()
        {
            System.Console.WriteLine("Enter the Name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the mobile Number:");
            long number=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the blood group:");
            BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the date of lastdonation: ");
            DateTime lastdonation=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            DonorDetails donor=new DonorDetails(name,number,bloodGroup,age,lastdonation);
            System.Console.WriteLine("Registration Successful....");
             donorlist.Add(donor);
            System.Console.WriteLine($"Your donor Id:{donor.DonorId}");
           
        }


        static void Login()
        { 
            System.Console.WriteLine("Enter your Donor Id:");
           string donorid=Console.ReadLine().ToUpper();
           foreach(DonorDetails donor in donorlist)
           {
            if(donor.DonorId==donorid)
            {
                System.Console.WriteLine("Login Successful");
                currentDonor=donor;
                SubMenu();
            }
           }

        }


        static void SubMenu()
        {
            string choice="yes";
            do{
               System.Console.WriteLine("Select SubMenu Details..");
               System.Console.WriteLine("1.Donate Blood 2.Donation History 3.Next Eligible Date 4.ExitSubmenu");
               int option=int.Parse(Console.ReadLine());
               
               switch(option)
               {
                case 1:
                {
                    System.Console.WriteLine("Donate Blood");
                    DonateBlood();
                    break;
                }

                case 2:
                {
                    System.Console.WriteLine("Donation History");
                    DonationHistory();
                    break;
                }
                case 3:
                {   System.Console.WriteLine("Check Next Eligible Date:");
                    currentDonor.ShowNextEligibilityDate();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit submenu");
                    choice="no";
                    break;
                }
               }
            }while(choice=="yes");
        }



        static void DonateBlood()
        {   int flag=0;
            int temp=0;
            foreach(DonorDetails donor1 in donorlist)
          {
             if(donor1.LastDonation.AddDays(60)<DateTime.Now)
            {
                flag=1;
            System.Console.WriteLine("Enter your weight:");
            double weight=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Blood Pressure:");
            double bloodpressure=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Hemoglobin Count:");
            double hemoglobincount=double.Parse(Console.ReadLine());
            //TimeSpan time=donor1.LastDonation-DateTime.Now;
            
           
            if((weight>50)&&(bloodpressure<130)&&(hemoglobincount>13))
            {
                temp=1;
                System.Console.WriteLine("Donation Successful....");
                Donation donor=new Donation(donor1.DonorId,donor1.LastDonation,weight,bloodpressure,hemoglobincount);
                System.Console.WriteLine($"Your Donation ID is:{donor.DonationId}");
                donor.DonationDate=DateTime.Now;
                donor1.LastDonation=DateTime.Now;
                DateTime nextdate=DateTime.Now.AddDays(60);
                donationlist.Add(donor);
                System.Console.WriteLine($"Your next eligible date is:{nextdate}");
                
                
            }
            }
            
        
        }
        if(temp==0)
        {
            System.Console.WriteLine("You are not eligible because your body health is too bad...");
        }
        if(flag==0)
        {
            System.Console.WriteLine($"You are not eligible your next eligible date is:{currentDonor.LastDonation.AddDays(60)}");
        }
        }

        static void DonationHistory()
        {
            foreach(Donation donor in donationlist)
            {
                if(currentDonor.DonorId==donor.DonorId)
                {
                    System.Console.WriteLine("The Donation History of the Donor:");
                    System.Console.WriteLine($"DonorId:{donor.DonorId}");
                    System.Console.WriteLine($"DonationID:{donor.DonationId}");
                    System.Console.WriteLine($"Weight of the Donor:{donor.Weight}");
                    System.Console.WriteLine($"Blood Pressure of the Donor:{donor.BloodPressure}");
                    System.Console.WriteLine($"Hemoglobin level of the Donor is:{donor.HemoglobinCount}");
                    currentDonor.ShowNextEligibilityDate();
                }
            }
        }
        
        }
    }
