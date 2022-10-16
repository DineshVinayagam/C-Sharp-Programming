using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalApplication
{
    public class Operations
    {
        //static int walletBalance=0;
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<MedicineDetails> medicineList=new List<MedicineDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static UserDetails currentUser=null;




        public static void DefaultMedicine()
        {
            MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,new DateTime(2022,06,30));
            medicineList.Add(medicine1);
            MedicineDetails medicine2=new MedicineDetails("Calpol",10,5,new DateTime(2022,06,30));
            medicineList.Add(medicine2);
            MedicineDetails medicine3=new MedicineDetails("Gelucil",3,40,new DateTime(2022,04,30));
            medicineList.Add(medicine3);
            MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,new DateTime(2022,10,30));
            medicineList.Add(medicine4);
            MedicineDetails medicine5=new MedicineDetails("Poviding Iodin",10,50,new DateTime(2022,10,30));
            medicineList.Add(medicine5);
    
        }
        public static void DefaultOrder()
        {
            OrderDetails order1=new OrderDetails("UID1001","MD105",5,250,new DateTime(2022,05,13),OrderStatus.Purchased);
            orderList.Add(order1);
        }
        public static void DefaultUser()
        {
            UserDetails user1=new UserDetails("Ravi",30,"Chennai",3094038509,5000);
            userList.Add(user1);
            UserDetails user2=new UserDetails("Baskaran",30,"Chennai",984935700,5000);
            userList.Add(user2);
            UserDetails user3=new UserDetails("Dinesh",21,"KPM",4938493940,6000);
            userList.Add(user3);
        }
        public static void MainMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: 1.Registration 2.UserLogin 3.OrderHistory 4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Welcome to Registration....");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Welcome to Login.....");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("*****Order History*****");
                        OrderHistory();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit...");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }


        static void Registration()
        {
            System.Console.WriteLine("Enter the Name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Your Age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your City:");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter Your Phone Number:");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Balance to Add to Your wallet:");
            int balance=int.Parse(Console.ReadLine());
            //walletBalance=walletBalance+balance;
            System.Console.WriteLine("Your Registration is Successfull:");
            UserDetails user=new UserDetails(name,age,city,mobile,balance);
            System.Console.WriteLine($"Your Registration Id is:{user.UserID}");
            userList.Add(user);
        }


        static void Login()
        {
            System.Console.WriteLine("Enter Your Registration Id to Login:");
            string userid=Console.ReadLine();
            int flag=0;
            foreach(UserDetails user in userList)
            {
                if(user.UserID==userid)
                {
                    flag=1;
                    System.Console.WriteLine("Your Login Sucessfull.......");
                    currentUser=user;
                    SubMenu();

                }
        
                
            }
            if(flag==1)
            {
                System.Console.WriteLine( "Sorry You Entered Wrong UserId Please Enter valid Id.......");
            }

        }

        static void SubMenu()
        {
            string choice="yes";
            
        do{
            System.Console.WriteLine("Enter your option: 1.Show Medicine List 2.Purchase Medicine 3.Cancel Purchase 4.Show Purchase History 5.Recharge 6.Exit SubMenu");
            int option=int.Parse(Console.ReadLine());
              switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Medicine List");
                    foreach(MedicineDetails medicine in medicineList)
                    {
                        medicine.ShowMedicineList();
                    }
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Purchase Medicine....");
                    PurchaseMedicine();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Cancel Purchase....");
                    CancelPurchase();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Show Purchase History....");
                    OrderHistory();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Recharge....");
                    WalletRecharge();
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("Exiting the Submenu......");
                    choice="no";
                    break;
                }
            }
          }while(choice=="yes");
        
        }

        
        public static void PurchaseMedicine()
        {
            foreach(MedicineDetails medicine1 in medicineList)
            {
              medicine1.ShowMedicineList();
            }
          System.Console.WriteLine("Enter the Medicine ID you want to Buy:");
          string medicineid=Console.ReadLine();
          foreach(MedicineDetails medicine in medicineList)
          {
                if(medicineid==medicine.MedicineID)
                {
                    if(medicine.DateOfExpiry>=DateTime.Now)
                    {
                    System.Console.WriteLine("Enter the count you want to buy:");
                    int count=int.Parse(Console.ReadLine());
                    if(medicine.MedicineCount>=count)
                    {
                        double totalprice=(double) medicine.Price*count;
                        foreach(UserDetails user in userList)
                        {
                            if(user.Balance>totalprice)
                            {
                              medicine.MedicineCount=medicine.MedicineCount-count;
                              currentUser.Balance=currentUser.Balance-totalprice;
                              System.Console.WriteLine("Your Purchase is Successfull....");
                              OrderDetails order1=new OrderDetails(currentUser.UserID,medicine.MedicineID,count,totalprice,DateTime.Now,OrderStatus.Purchased);
                              orderList.Add(order1);
                              System.Console.WriteLine($"Your Order Id is :{order1.OrderID}");
                              break;
                            }
                            else
                            {
                               System.Console.WriteLine("Insufficient Balance Please Recharge Wallet:");
                               WalletRecharge();
                            }
                        
                        }
                    
                    }
                    else
                    {
                        System.Console.WriteLine("Insuffient Count Enter the Valid Count.....");
                    }
                }
                }
                
            }  
        }
        


        static void CancelPurchase()
        {
           foreach(OrderDetails order in orderList)
           {
            if(order.UserID==currentUser.UserID)
            {
                if(order.OrderStatus==OrderStatus.Purchased)
                {
                System.Console.WriteLine("Enter Your Order Id:");
                string orderid=Console.ReadLine();
                if(orderid==order.OrderID)
                {
                   order.OrderStatus=OrderStatus.Cancelled;
                   System.Console.WriteLine("Your Order cancelled Successfully....");
                   foreach(MedicineDetails medicine in medicineList)
                   {
                     if(medicine.MedicineID==order.MedicineID)
                     {
                        medicine.MedicineCount=medicine.MedicineCount+order.MedicineCount;
                        currentUser.Balance=currentUser.Balance+order.TotalPrice;
                     }
                   }
                }
                }
            }
           }

        }
    
        static void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to add to your wallet:");
            int money=int.Parse(Console.ReadLine());
            currentUser.Balance=currentUser.Balance+money;
        }

        static void OrderHistory()
        {
            System.Console.WriteLine("Enter the Order Id:");
            string orderid=Console.ReadLine();
            foreach(OrderDetails order in orderList)
            {
               if(orderid==order.OrderID)
               {
                System.Console.WriteLine($"User Id of the User:   {order.UserID}");
                System.Console.WriteLine($"Medicine ID:           {order.MedicineID}");
                System.Console.WriteLine($"MedicineCount:         {order.MedicineCount}");
                System.Console.WriteLine($"TotalPrice:            {order.TotalPrice}");
                System.Console.WriteLine($"OrderDate:             {order.OrderDate}");
                System.Console.WriteLine($"Order Status:          {order.OrderStatus}");
               }
            }
        }
        
    } 
}