using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalApplication
{
    public class MedicineDetails
    {
        private static int s_medicineId=100;
        public string MedicineID { get; }
        public string MedicineName { get; set; }
        public int MedicineCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpiry { get; set; }



        public MedicineDetails(string medicinename,int medicinecount,double price,DateTime dateofexpiry)
        {
            s_medicineId++;
            MedicineID="MD"+s_medicineId;
            MedicineName=medicinename;
            MedicineCount=medicinecount;
            Price=price;
            DateOfExpiry=dateofexpiry;

        }
        public MedicineDetails(string data)
        {
           string[] values=data.Split(',');
           s_medicineId=int.Parse(values[0].Remove(0,2));
           MedicineID=values[0];
           MedicineName=values[1];
           MedicineCount=int.Parse(values[2]);
           Price=double.Parse(values[3]);
           DateOfExpiry=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);

        }

        public void ShowMedicineList()
        {
                System.Console.WriteLine("***************************");
                System.Console.WriteLine($"Medicine ID:     {MedicineID}");
                System.Console.WriteLine($"Medicine Name:   {MedicineName} ");
                System.Console.WriteLine($"Medicine Count:  {MedicineCount}");
                System.Console.WriteLine($"Medicine Price:  {Price}");
                System.Console.WriteLine($"Expiry Date:     {DateOfExpiry}");
                System.Console.WriteLine("***************************");
        }

    }
}