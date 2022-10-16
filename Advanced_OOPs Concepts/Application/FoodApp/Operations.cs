using System;

using System.Linq;
using System.Threading.Tasks;

namespace FoodApp
{
    public delegate void EventManager();
    public static class Operations
    {
        //private static string s_eventName;
        public static event EventManager eventLink=null;
        public static List<CustomerRegistration>customerList=new List<CustomerRegistration>();
        public static List<FoodDetails>foodsList=new List<FoodDetails>();
        public static List<BookingDetails>bookingList=new List<BookingDetails>();
        public static List<OrderDetails>orderList=new List<OrderDetails>();
        public static CustomerRegistration currentUser=null;

        public static void Subscribe()
        {
            eventLink+=new EventManager(Files.Create);
            eventLink+=new EventManager(Files.ReadFile);
            //eventLink+=new EventManager()
        }
        public static void StartEvent()
        {
            Subscribe();
            eventLink();
        }

        public static void MainMenu()
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


        public static void Registeration()
        {
            System.Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your father name:");
            string fathersName=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Mobile:");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Date Of Birth:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your Mail:");
            string mail=Console.ReadLine();
            System.Console.WriteLine("Enter Your Location:");
            string location=Console.ReadLine();
            double walletBalance=0;
            CustomerRegistration customer=new CustomerRegistration(name,fathersName,gender,mobile,dob,mail,location,walletBalance);
            customerList.Add(customer);
            System.Console.WriteLine($"Your Customer ID:{customer.RegistrationID}");
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter Your Customer ID:");
            string customerid=Console.ReadLine();
            foreach(CustomerRegistration customer1 in customerList)
            {
                if(customer1.RegistrationID==customerid)
                {
                    System.Console.WriteLine("Login Sucessfull....");
                    currentUser=customer1;
                    Submenu();
                }
            }

        }
        public static void Submenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Enter your choice: 1.Show Food Details. 2.Order Food 3.Cancel Food 4.Order History. 5.Recharge Wallet 6.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Food Details.....");
                        ShowFoodDetails();
                        break;

                    }
                    case 2:
                    {
                        System.Console.WriteLine("Order Food:");
                        OrderFood();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Food...");
                        CancelFood();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Order History....");
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Recharge Wallet...");
                        currentUser.WalletRecharge();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit....");
                        choice="no";
                        break;
                    }
                    
                }
                
            }while(choice=="yes");
        }

        public static void ShowFoodDetails()
        {
            foreach(FoodDetails foods in foodsList)
            {
                System.Console.WriteLine("******FOOD DETAILS******");
                System.Console.WriteLine($"Food ID: {foods.FoodID}");
                System.Console.WriteLine($"Food Name:{foods.FoodName}");
                System.Console.WriteLine($"Food Count:{foods.FoodCount}");
                System.Console.WriteLine($"Food Price:{foods.FoodPrice}");
            }
        }
        public static void OrderFood()
        {     List<OrderDetails>tempOrderList=new List<OrderDetails>();
              //a.	Ask user that whether he want to purchase / not. 
              //If “Yes” means Create booking details object with Customer id, Total price =0, Booking status = Initiated.
               BookingDetails booking=new BookingDetails(currentUser.RegistrationID,0,DateTime.Now,BookingStatus.Initiated);
               string condition="";
               do{ShowFoodDetails();
               System.Console.WriteLine("Enter the Food ID:......");
               string foodId=Console.ReadLine();
               foreach(FoodDetails food in foodsList)
               {
                if(food.FoodID==foodId)
                {
                    System.Console.WriteLine("Enter the count you want");
                    int count=int.Parse(Console.ReadLine());
                    if(food.FoodCount>=count)
                    {
                        int price=food.FoodPrice*count;
                        System.Console.WriteLine("Your Order is Booked");
                        OrderDetails order=new OrderDetails(booking.BookingID,food.FoodID,count,price);
                        tempOrderList.Add(order);
                        System.Console.WriteLine("Do you want to continue....");
                        condition=Console.ReadLine();
                        
                    }
                    
                }
               }
               }while(condition=="yes");
                double totalamount=0;
               foreach(OrderDetails order in tempOrderList)
               {
                totalamount=totalamount+order.PriceOfOrder;
               }
               System.Console.WriteLine("Do you want to Conform the order.....");
               string choice=Console.ReadLine();
               while(choice=="yes")
               {
                if(currentUser.WalletBalance>=totalamount)
                {
                    currentUser.WalletBalance=currentUser.WalletBalance-totalamount;
                    System.Console.WriteLine("Booking Sucessfull....");
                    BookingDetails finalbooking=new BookingDetails(currentUser.RegistrationID,totalamount,DateTime.Now,BookingStatus.Booked);
                    bookingList.Add(finalbooking);
                    System.Console.WriteLine($"Your Booking ID Is: {finalbooking.BookingID}");
                    //orderList.AddRange(tempOrderList);
                    foreach(OrderDetails item in tempOrderList)
                    {
                        orderList.Add(item);
                    }
                    break;
                }
                else
                {
                    currentUser.WalletRecharge();
                }
               }
        }
                
                
              
        
        public static void CancelFood()
        {
            int flag=0;
           foreach(BookingDetails booking in bookingList)
           {
            if(booking.RegistrationID==currentUser.RegistrationID)
            {
            booking.ShowBookingDetails();
            System.Console.WriteLine("Enter the Booking ID:  ");
            string bookingid=Console.ReadLine();
            if(booking.BookingID==bookingid)
            {
                flag=1;
            if(booking.BookingStatus==BookingStatus.Booked)
            {
                booking.BookingStatus=BookingStatus.Cancelled;
                double price=booking.TotalPrice;
                currentUser.WalletBalance=currentUser.WalletBalance-price;
            }
            }
            }

           }
           if(flag==0)
           {
            System.Console.WriteLine("Enter the valid booking id....");
           }
        }
        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                order.ShowOrderDetails();
            }
        }
        public static void DefaultCustomer()
        {
            CustomerRegistration customer=new CustomerRegistration("ravi","ettaparajan",Gender.Male,3949903859,new DateTime(1999,11,11),"ravi@gmail.com","Chennai",10000);
            customerList.Add(customer);
            CustomerRegistration customer1=new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,394983480,new DateTime(1999,11,11),"baskaran@gmail.com","Chennai",15000);
            customerList.Add(customer1);
        }
        
        

    }
}