using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalApplication
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    public class OrderDetails
    {
        public static int s_orderId=2000;
        public string OrderID { get; }
        public string UserID { get; set; }
        public string MedicineID { get; }
        public int MedicineCount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }



        public OrderDetails(string userid,string medicineid,int medicinecount,double totalprice,DateTime orderdate,OrderStatus orderstatus)
        {
            s_orderId++;
            OrderID="OID"+s_orderId;
            UserID=userid;
            MedicineID=medicineid;
            MedicineCount=medicinecount;
            TotalPrice=totalprice;
            OrderDate=orderdate;
            OrderStatus=orderstatus;
        }

        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            UserID=values[1];
            MedicineID=values[2];
            MedicineCount=int.Parse(values[3]);
            TotalPrice=double.Parse(values[4]);
            OrderDate=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<OrderStatus>(values[6],true);
        }
        
    }
}