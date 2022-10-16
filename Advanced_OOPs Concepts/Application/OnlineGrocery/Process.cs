using System;

 namespace OnlineGrocery;
  public delegate void EventManager();
  class Process
  {
        //private static string s_eventName;
        public static event EventManager eventlink=null;
        
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();
        public  static List<ProductDetails> productList=new List<ProductDetails>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static CustomerDetails currentCustomer=null;


        public static void Subscribe()
        {
           eventlink+=new EventManager(Files.Create);
           eventlink+=new EventManager(Files.ReadFile);
           eventlink+=new EventManager(MainMenu);
           eventlink+=new EventManager(Files.WriteFile);
         
        }

        public static void StartEvent()
        {
          Subscribe();
          eventlink();
        }
        public static void MainMenu()
        {



          


          //AddDefaultData();
           string choice="yes";
           do{
               System.Console.WriteLine("Select Option 1.Customer Registration 2.Customer Login 3.Exit");
               int option=int.Parse(Console.ReadLine());
            
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("**********WelCome To Registration************");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("**********WelCome To Login**********");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("xxxxx You Selected Exit xxxxx");
                    System.Console.WriteLine("You Exiting Main Menu....");
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


    static void Registration()
    {
            System.Console.WriteLine("Enter the name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the fathers Name:");
            string fathersName=Console.ReadLine();
            System.Console.WriteLine("Enter Your Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Mobile Number:");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Date Of Birth");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your Mail ID:");
            string mail=Console.ReadLine();
            CustomerDetails customer=new CustomerDetails(name,fathersName,gender,mobile,dob,mail);
            customerList.Add(customer);
            System.Console.WriteLine($"Your Customer ID is:  {customer.CustomerID}");
            customer.ShowCustomerDetails();
      
    }
    static void Login()
    {
      System.Console.WriteLine("Enter Your Customer ID:");
      string customerid=Console.ReadLine().ToUpper();
      int flag=0;
      foreach(CustomerDetails customer in customerList)
      {
        if(customerid==customer.CustomerID)
        {
          System.Console.WriteLine("Login Sucessfull......");
          currentCustomer=customer;
          SubMenu();
          flag=0;
        }
        else
        {
          flag=1;
        }
      }
      if(flag==1)
      {
          System.Console.WriteLine("Invalid Customer ID Enter the valid id:");
      }
      
    }
    static void SubMenu()
    {
      string choice="yes";
      do{
        System.Console.WriteLine("Enter the Option:\n 1.ShowCustomerDetails\n 2.Show Product Details\n 3.Wallet Recharge\n 4.Take Order\n  5.CancelOrder\n 6.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
          case 1:
          {
            System.Console.WriteLine("*******Show Customer Details*********");
            currentCustomer.ShowCustomerDetails();
            break;
          }
          case 2:
          {
            ShowProductDetails();
            System.Console.WriteLine("*******Show Product Details**********");
            break;
          }
          case 3:
          {
            System.Console.WriteLine("*******Wallet Recharge*********");
            currentCustomer.WalletRecharge();
            break;
          }
          case 4:
          {
            TakeOrder();
            System.Console.WriteLine("********Take Order*******");
            break;
          }
         
          case 5:
          {
            CancelOrder();
            System.Console.WriteLine("********Cancel Order*********");
            break;
          }
          case 6:
          {
            System.Console.WriteLine("******You are Exiting the Sub Menu*******");
            choice="no";
            break;
          }
        }
      
      }while(choice=="yes");
    }
  
    public static void AddDefaultData()
    {
      //Default Customer Details
        CustomerDetails customer=new CustomerDetails("dinesh","vinayagam",Gender.Male,8348928489,new DateTime (2000,11,07),"dinesh@gmail.com");
        CustomerDetails customer1=new CustomerDetails("ravi","chandran",Gender.Male,8348928489,new DateTime (1999,11,11),"ravi@gmail.com");
        CustomerDetails customer2=new CustomerDetails("baskaran","sethurajan",Gender.Male,8348928489,new DateTime (1999,11,11),"Baskaran@gmail.com");
        customerList.Add(customer);
        customerList.Add(customer1);
        customerList.Add(customer2);
        


       // Default Product Details
         ProductDetails product=new ProductDetails("sugar",20,40);
        ProductDetails product1=new ProductDetails("Rice",100,50);
        ProductDetails product2=new ProductDetails("Milk",10,40);
        ProductDetails product3=new ProductDetails("Coffee",10,10);
        ProductDetails product4=new ProductDetails("Tea",10,10);
        ProductDetails product5=new ProductDetails("Masala Powder",10,20);
        ProductDetails product6=new ProductDetails("salt",10,20);
        ProductDetails product7=new ProductDetails("Turmeric Powder",10,25);
        ProductDetails product8=new ProductDetails("Chilli Powder",10,20);
        ProductDetails product9=new ProductDetails("Groundnut Oil",10,140);
        productList.Add(product);
        productList.Add(product1);
        productList.Add(product2);
        productList.Add(product3);
        productList.Add(product4);
        productList.Add(product5);
        productList.Add(product6);
        productList.Add(product7);
        productList.Add(product8);
        productList.Add(product9);
        



        //Default Booking Details
        BookingDetails booking=new BookingDetails("CID3001",220,new DateTime(2022,07,20),BookingStatus.Booked);
        BookingDetails booking1=new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
        BookingDetails booking2=new BookingDetails("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
        BookingDetails booking3=new BookingDetails("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initialised);
        bookingList.Add(booking);
        bookingList.Add(booking1);
        bookingList.Add(booking2);
        bookingList.Add(booking3);
        

        //Default Order Details
         OrderDetails order=new OrderDetails("BID3001","PID101",2,80);
         OrderDetails order1=new OrderDetails("BID3001","PID102",2,100);
         OrderDetails order2=new OrderDetails("BID3001","PID103",1,40);
         OrderDetails order3=new OrderDetails("BID3002","PID101",1,40);
         OrderDetails order4=new OrderDetails("BID3002","PID102",4,200);
         OrderDetails order5=new OrderDetails("BID3002","PID110",1,140);
         orderList.Add(order);
         orderList.Add(order1);
         orderList.Add(order2);
         orderList.Add(order3);
         orderList.Add(order4);
         orderList.Add(order5);
        
    }
  
  
    static void ShowProductDetails()
    {
       foreach(ProductDetails product in productList)
       {
        product.ShowProductDetails();
       }
    }
    static void TakeOrder()
    {
       //Create Booking object
       
       BookingDetails booking=new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initialised);
       List<OrderDetails>tempOrderList=new List<OrderDetails>();
       string choice="";
       //Show Product Details List
       do{
       foreach(ProductDetails product in productList)
       {
        product.ShowProductDetails();
       }
       
        //Select Product and check for the product
       System.Console.WriteLine("Give the product id from the above list:");
       string productid=Console.ReadLine();
       int flag=0;

       foreach(ProductDetails product in productList)
       {
        if(product.ProductID==productid)
        {  flag=0;
          //Get the Quantity & compare with availablity
          System.Console.WriteLine("Enter the Quantity you want:");
          int quantity=int.Parse(Console.ReadLine());
          if(product.Quantity>quantity)
          {
             double amount=product.PricePerQuantity*quantity;
             OrderDetails order=new OrderDetails(booking.BookingID,product.ProductID,quantity,amount);
             tempOrderList.Add(order);
             product.Quantity=product.Quantity-quantity;
             System.Console.WriteLine("Your Order Is Added successfully");
             System.Console.WriteLine("Do you want to Add Product Again");
             choice=Console.ReadLine();
          }
        }
        else
        {
          flag=1;
        }
       }
       if(flag==1)
       {
        System.Console.WriteLine("Enter the valid Product ID...."); 
       }
       }while(choice=="yes");
       double totalamount=0;
       foreach(OrderDetails order in tempOrderList)
       {
         totalamount=totalamount+order.PriceOfOrder;
         
       }
        System.Console.WriteLine("Do you want to Place the order");
        string decision=Console.ReadLine();
          while(decision=="yes")
          {
            if(totalamount<=currentCustomer.WalletBalance)
            {
             currentCustomer.WalletBalance=currentCustomer.WalletBalance-totalamount;
             BookingDetails orderbooking=new BookingDetails(currentCustomer.CustomerID,totalamount,DateTime.Now,BookingStatus.Booked);
             bookingList.Add(orderbooking);
             System.Console.WriteLine("Booking Sucessfull....");
             break;
            }
            else
            {
              currentCustomer.WalletRecharge();
            }
          }
        
        

       
       
       
    }
   
    static void CancelOrder()
    {
      int flag=0;
       System.Console.WriteLine("Entered CancelOrder");
       foreach(BookingDetails booking in bookingList)
       {
        if(booking.CustomerID==currentCustomer.CustomerID)
       {
        if(booking.BookingStatus==BookingStatus.Booked)
        { flag=1;
          booking.BookingStatus=BookingStatus.Cancelled;
          currentCustomer.WalletBalance=currentCustomer.WalletBalance+booking.TotalPrice;
          System.Console.WriteLine("Ordered Cancelled Sucessfully....");
          foreach(ProductDetails product in productList)
          {
            product.Quantity=product.Quantity+orderList.Count;
          }

        }
       }
      }
      if(flag==0)
      {
        System.Console.WriteLine("You did not ordered anything....");
      }

    }

    
  }