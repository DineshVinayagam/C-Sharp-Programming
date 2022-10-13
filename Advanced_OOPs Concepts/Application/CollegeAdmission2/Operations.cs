using System;


namespace CollegeAdmission2
{
    public delegate void EventManager();

   public static class Operations
    { 
        private static string s_eventName;
        public static event EventManager  eventlink=null;


        public static StudentsDetails currentStudent=null;
        public static List<StudentsDetails> studentList=new List<StudentsDetails>();
        public static List<Department>departmentList=new List<Department>();
        public static List<Admission>admissionList=new List<Admission>();

        public static void DefaultDepartment()
        {   
            Department eee=new Department("EEE",29);
            departmentList.Add(eee);
            Department ece=new Department("ECE",30);
            departmentList.Add(ece);
            Department cse=new Department("CSE",29);
            departmentList.Add(cse);
            Department mech=new Department("MECH",30);
            departmentList.Add(mech);
            foreach(Department department in departmentList)
            {
                 System.Console.WriteLine($"{department.DepartmentId} {department.DpmtName} {department.Seats}");
            }

          

        }
         public static void DefaultStudents()
        {   
           StudentsDetails name1=new StudentsDetails("Baskaran","Sethurajan",new DateTime(1999,11,11),Gender.Male,"baskaran@gmail.com",944885594984,98,97,99);
            studentList.Add(name1);
           StudentsDetails name2=new StudentsDetails("RaviChandran","Ettaparajan",new DateTime(1999,11,11),Gender.Male,"ravichandran@gmail.com",457889859478,98,95,95);
            studentList.Add(name2);
            foreach(StudentsDetails student in studentList)
            {
                System.Console.WriteLine($"{student.Name} {student.FatherName}{student.DOB} {student.Gender} {student.Gender} {student.Mail} {student.Phone} {student.Physics} {student.Chemistry} {student.Maths}");
            }
           
           
        }
        public static void DefaultAdmission()
        {
            Admission admit1= new Admission("SF3001","DID101",new DateTime(2022,05,11),Status.Admitted);
            admissionList.Add(admit1);
            Admission admit2=new Admission("SF3002","DID102",new DateTime(2022,05,12),Status.Admitted);
            admissionList.Add(admit2);
            foreach(Admission admits in admissionList)
            {
                System.Console.WriteLine($"{admits.AdmissionId} {admits.DepartmentId} {admits.StudentId} {admits.AdmissionDate} {admits.Status}");
            }

        }


         public static void Subscribe()
        {
            eventlink+=new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(MainMenu);
            eventlink+=new EventManager(Files.WriteToFiles);
        }
        public static void StartEvent()
        {
             Subscribe();
             eventlink();
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
            System.Console.WriteLine("Enter the data to read...");
        
        System.Console.WriteLine("Enter the student name:");
        string name=Console.ReadLine();
       
        System.Console.WriteLine("Enter the fathers name:");
        string fathersname=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Date of Birth:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter the Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Enter the phone number:");
        long phone=long.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the mail:");
        string mail=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Physics mark:");
        int physics=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the Chemistry mark:");
        int chemistry=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the maths mark:");
        int maths=int.Parse(Console.ReadLine());
        
       
        System.Console.WriteLine("Admitted");
        //System.Console.WriteLine("Are you want to Admit a student again:");
       
        
        StudentsDetails student1=new StudentsDetails(name,fathersname,dob,gender,mail,phone,physics,chemistry,maths);
         
        studentList.Add(student1);
        System.Console.WriteLine($"Your registered number is:{student1.StudentId}");
        //System.Console.WriteLine("");
        
        }
        public static void Login()
        {
           System.Console.WriteLine("Enter your Register Number");
           string studentid=Console.ReadLine().ToUpper();
           foreach(StudentsDetails student in studentList)
           {
            if(student.StudentId==studentid)
            {
                System.Console.WriteLine("Login Successful");
                currentStudent=student;
                SubMenu();
            }
           }
           
        }
        public static void SubMenu()
        {
            string choice="yes";
            do{
               System.Console.WriteLine("Select SubMenu Details..");
               System.Console.WriteLine("1.ShowDetails 2.CheckEligiblity 3.TakeAdmission 4.Cancel Admission 5.ExitSubmenu");
               int option=int.Parse(Console.ReadLine());
               
               switch(option)
               {
                case 1:
                {
                    System.Console.WriteLine("ShowDetails");
                    currentStudent.ShowDetails();
                    break;
                }
                case 2:
                {   System.Console.WriteLine("CheckEligibility");
                     bool eligible=currentStudent.CheckEligibility(75.0);
                     if(eligible)
                        {
                           System.Console.WriteLine("You are eligible for admission");
                         }
                    else{
                              System.Console.WriteLine("You are not eligible for admission");
                         }
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Take Admission:");
                    TakeAdmission();
                    break;
                  

                }
                case 4:
                {
                    System.Console.WriteLine("Cancel Admission:");
                    CancelAdmission();
                    break;
                    
                }

                case 5:
                {
                    System.Console.WriteLine("Exit submenu");
                    choice="no";
                    break;
                }
               }
            }while(choice=="yes");
        }
       
       
        
        

        public static void TakeAdmission()
        {
             foreach(Department department in departmentList)
             {
                System.Console.WriteLine($"{department.DepartmentId} {department.DpmtName} {department.Seats}");
             }
             System.Console.WriteLine("Enter the department id:");
             string dpmtid=Console.ReadLine();
             foreach(Department department in departmentList)
            {   
                 
                 if (dpmtid==department.DepartmentId)
                 {
                    if(department.Seats>=1)
                    {
                        bool eligible=currentStudent.CheckEligibility(75.0);
                        if(eligible)
                        {
                            bool canAdmit=true;
                            foreach(Admission admit in admissionList)
                            { 
                                 if(currentStudent.StudentId==admit.StudentId)
                                 {
                                 if(admit.Status==Status.Admitted)
                                 {
                                 canAdmit=false;
                                 }
                                 
                                }
                            }
                            
                            if(canAdmit)
                        
                            {
                                foreach(Department dpmt in departmentList)
                                {
                                    if(dpmt.DepartmentId==dpmtid)
                                    {
                                        dpmt.Seats--;
                                        Admission admit3=new Admission(currentStudent.StudentId,department.DepartmentId,DateTime.Now,Status.Admitted);
                                        admissionList.Add(admit3);
                                        System.Console.WriteLine("You are admitted...");
                                        System.Console.WriteLine($"Your admission ID is:{admit3.AdmissionId}");
                                    }
                                }
                            }
                        }
                        
                    }
                    
                     
                     
                 
                }
            }
           
            
        }

 public static void CancelAdmission()
        {
            foreach(Admission admit in admissionList)
            {
                if(admit.StudentId==currentStudent.StudentId)
                {
                    admit.Status=Status.Cancelled;
                    foreach(Department dpmt in departmentList)
                    {
                        if(dpmt.DepartmentId==admit.DepartmentId)
                        {
                            dpmt.Seats++;
                            System.Console.WriteLine("Admission cancelled");
                        }

                    }
                }
            }
            }
        
    }

}

