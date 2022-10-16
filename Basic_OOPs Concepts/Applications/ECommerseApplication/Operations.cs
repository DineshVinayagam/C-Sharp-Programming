using System;


namespace ECommerseApplication
{
    public static class Operations
    {
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        static CustomerDetails currentCustomer=null;
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
            System.Console.WriteLine("Enter your city");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter your phone Number:");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Mail ID:");
            string emailId=Console.ReadLine();
            double walletBalance=0;
            CustomerDetails customer=new CustomerDetails(name,city,mobileNumber,walletBalance,emailId);
            System.Console.WriteLine($"Customer ID:{customer.CustomerID}");
            customerList.Add(customer);
            
            
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Customer Id:");
           string customerId=Console.ReadLine().ToUpper();
           foreach(CustomerDetails customer in customerList)
           {
            if(customer.CustomerID==customerId)
            {
                System.Console.WriteLine("Login Successful");
                currentCustomer=customer;
                SubMenu();
            }
           }

        }
    
       public static void SubMenu()
       {
        string choice="yes";
            do{
               System.Console.WriteLine("Select SubMenu Details..");
               System.Console.WriteLine("a.Purchase b.OrderHistory c.CancelOrder d.WalletBalance e.Exit");
               char option=char.Parse(Console.ReadLine().ToLower());
               
               switch(option)
               {
                case 'a':
                {
                    System.Console.WriteLine("Purchase");
                    Purchase();
                    break;
                }

                case 'b':
                {
                    System.Console.WriteLine("OrderHistory");
                    foreach(OrderDetails order in orderList)
                    {
                        if(currentCustomer.CustomerID==order.CustomerID)
                        {
                        order.ShowOrderDetails();
                        }
                    }
                    break;
                }
                case 'c':
                {   System.Console.WriteLine("Cancel Order");
                    CancelOrder();
                    break;
                }
                case 'd':
                {
                    System.Console.WriteLine("Wallet Balance:");
                    System.Console.WriteLine($"Wallet Balance is:{currentCustomer.WalletBalance}");
                    break;
                }
                case 'e':
                {
                    System.Console.WriteLine("Exit submenu");
                    choice="no";
                    break;
                }
               }
            }while(choice=="yes");
       }
       public static void AddDefaultData()
       {//Default Customer
        CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",938593849,50000,"ravi@gmail.com");
        customerList.Add(customer1);
        CustomerDetails customer2=new CustomerDetails("Baskaran","Channai",3489384749,60000,"baskaran@gmail.com");
        customerList.Add(customer2);
        //Purchase Details
        OrderDetails order1=new OrderDetails("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Ordered);
        orderList.Add(order1);
        OrderDetails order2=new OrderDetails("CID1002","PID103",40000,DateTime.Now,2,OrderStatus.Ordered);
        orderList.Add(order2);

        //ProductDetails
        
        ProductDetails product1=new ProductDetails("Mobile",10,10000,3);
        productList.Add(product1);
        ProductDetails product2=new ProductDetails("Tablet",5,15000,2);
        productList.Add(product2);
        ProductDetails product3=new ProductDetails("Camara",3,20000,4);
        productList.Add(product3);
        ProductDetails product4=new ProductDetails("iPhone",5,50000,6);
        productList.Add(product4);
        ProductDetails product5=new ProductDetails("Laptop",3,40000,3);
        productList.Add(product5);

       }
    

       public static void Purchase()
       {
        foreach(ProductDetails product in productList)
        {
            product.ShowProductDetails();
        }
        System.Console.WriteLine("Enter the the Product ID you want to buy:");
        string productId=Console.ReadLine();
        int temp=0;
        int falg=0;
        foreach(ProductDetails product in productList)
        {
            if(product.ProductID==productId)
            {
                falg=1;
                System.Console.WriteLine("Enter the count you want to buy:");
                int count=int.Parse(Console.ReadLine());
                if(product.Stock>=count)
                {
                  temp=1;
                  double totalAmount=(count*product.Price)+500;
                  if(totalAmount<=currentCustomer.WalletBalance)
                  {
                    currentCustomer.WalletBalance=currentCustomer.WalletBalance-totalAmount;
                    product.Stock=product.Stock-count;
                    System.Console.WriteLine("Purchase Sucessfull...");
                    OrderDetails order=new OrderDetails(currentCustomer.CustomerID,product.ProductID,totalAmount,DateTime.Now,count,OrderStatus.Ordered);
                    orderList.Add(order);
                    System.Console.WriteLine($"Delivery Date Of Your Product is:{DateTime.Now.AddDays(product.ShippingDuration)} ");
                  }
                  else
                  {
                    while(totalAmount>currentCustomer.WalletBalance)
                    {
                    System.Console.WriteLine("Insuffient Wallet Balance....");
                    currentCustomer.WalletRecharge();
                    }
                  }
                }
            }
        }
        if(falg==0)
        {
            System.Console.WriteLine("Enter the valid ProductID...");
        }
        if(temp==0)
        {
            System.Console.WriteLine("Product Out Of Stock....");
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine($"Current Available Count is:{product.Stock}");
            }
        }
           
       }
       public static void CancelOrder()
       {
           foreach(OrderDetails order in orderList)
            {
                if(currentCustomer.CustomerID==order.CustomerID)
                {
                order.ShowOrderDetails();
                }
            }
            System.Console.WriteLine("Enter the Order ID:");
            string orderId=Console.ReadLine();
            int flag=0;
            foreach(OrderDetails order in orderList)
            {
                if(order.OrderID==orderId)
                {
                  flag=1;
                  order.OrderStatus=OrderStatus.Cancelled;
                  currentCustomer.WalletBalance=currentCustomer.WalletBalance+order.TotalPrice;
                  System.Console.WriteLine("Order Cancelled Sucessfully...");
                  foreach(ProductDetails product in productList)
                  {
                    if(product.ProductID==order.ProductID)
                    {
                        product.Stock=product.Stock+order.Quantity;
                    }
                  }
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Enter the valid Product ID....");
            }
       }
    }
}