using System;
 namespace Hierarchical1;
  class Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("dinesh","vinayagam",new DateTime(2000,11,07),39490394085,Gender.Male,"dinesh@gmail.com","B.E",Department1.ECE,03);
        student.ShowStudent();
        TeacherInfo teacher=new TeacherInfo("kavitha","balaji",new DateTime(1998,09,02),834093975,Gender.Female,"kavitha@gmail.com",Department.ECE,"maths","M.sc.Maths",03,new DateTime(2019,09,08));
        teacher.ShowTeacher();
        PrincipalInfo principal=new PrincipalInfo("gayathri","mani",new DateTime(1979,09,03),3984849340,Gender.Female,"gayathri@gmail.com","M.sc maths,Phd",09,new DateTime(1991,09,11));
        principal.ShowPrincipal();
    }
  }