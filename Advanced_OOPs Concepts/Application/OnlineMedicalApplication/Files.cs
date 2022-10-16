using System;
using System.IO;

namespace OnlineMedicalApplication
{
    public static class Files
    {
        public static void Create()
        {
              if(!Directory.Exists("Medicine"))
              {
                 Directory.CreateDirectory("Medicine");
              }
              if(!File.Exists("Medicine/UserDetails.csv"))
              {
                File.Create("Medicine/UserDetails.csv");
              }
              if(!File.Exists("Medicine/MedicineDetails.csv"))
              {
                File.Create("Medicine/MedicineDetails.csv");
              }
              if(!File.Exists("Medicine/OrderDetails.csv"))
              {
                File.Create("Medicine/OrderDetails.csv");
              }
        }
        public static void ReadFile()
        {
            string[] users=File.ReadAllLines("Medicine/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user=new UserDetails(data);
                Operations.userList.Add(user);
            }
            string[] medicines=File.ReadAllLines("Medicine/MedicineDetails.csv");
            foreach(string data in medicines)
            {
                MedicineDetails medicine=new MedicineDetails(data);
                Operations.medicineList.Add(medicine);
            }
            string[] orders=File.ReadAllLines("Medicine/OrderDetails.csv");
            foreach(string data in  orders)
            {
               OrderDetails order=new OrderDetails(data);
               Operations.orderList.Add(order);
            }
        }
        public static void WriteFile()
        {
            string[] users=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                users[i]=Operations.userList[i].UserID+','+Operations.userList[i].Name+','+Operations.userList[i].Age+','+Operations.userList[i].City+','+Operations.userList[i].Mobile+','+Operations.userList[i].Balance;
            }File.WriteAllLines("Medicine/UserDetails.csv",users);

            string[] medicines=new string[Operations.medicineList.Count];
            for(int i=0;i<Operations.medicineList.Count;i++)
            {
                medicines[i]=Operations.medicineList[i].MedicineID+','+Operations.medicineList[i].MedicineName+','+Operations.medicineList[i].MedicineCount+','+Operations.medicineList[i].Price+','+Operations.medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy");

            }File.WriteAllLines("Medicine/MedicineDetails.csv",medicines);

            string[] orders=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orders[i]=Operations.orderList[i].OrderID+','+Operations.orderList[i].UserID+','+Operations.orderList[i].MedicineID+','+Operations.orderList[i].MedicineCount+','+Operations.orderList[i].TotalPrice+','+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+','+Operations.orderList[i].OrderStatus;
            }File.WriteAllLines("Medicine/OrderDetails.csv",orders);


        }
    }
}