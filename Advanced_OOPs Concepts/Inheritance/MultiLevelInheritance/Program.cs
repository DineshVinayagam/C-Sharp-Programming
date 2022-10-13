namespace MultiLevelInheritance;
class Program
  {
    public static void Main(string[] args)
    {
      PersonalDetails person1=new PersonalDetails("Dinesh","Vinayagam",Gender.Male,9489384830);
      person1.ShowDetails();
      StudentDetails student=new StudentDetails("656746","Dinesh","vinayagam",Gender.Male,39840349038,Department.ECE,"firstyear");
      student.ShowStudent();
      student.GetMark(90,98,99);
      student.Calculate();
      student.ShowMark();
      EmploymentDetails employee=new EmploymentDetails("SF0495","9893834","dinesh","vinayagam",Gender.Male,893973904,Department.ECE);
      employee.ShowEmployementDetails();
      employee.GetMark(90,98,99);
      employee.Calculate();
      employee.ShowMark();

    

    }
  }