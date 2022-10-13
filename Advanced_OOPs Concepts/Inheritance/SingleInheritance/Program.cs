namespace SingleInheritance;
class Program
  {
    public static void Main(string[] args)
    {
      PersonalDetails person1=new PersonalDetails("Dinesh","Vinayagam",Gender.Male,9489384830);
      person1.ShowDetails();
      StudentDetails student=new StudentDetails("656746","Dinesh","vinayagam",Gender.Male,39840349038,Department.ECE,"firstyear");
      student.ShowStudent();

    }
  }