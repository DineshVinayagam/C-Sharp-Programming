using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CollegeAdmission2
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");

            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/Admission.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/Admission.csv");
            }
            if(!File.Exists("College/Department.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/Department.csv");
            }
            
        }

        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in students)
            {
                StudentsDetails student= new StudentsDetails (data);
                Operations.studentList.Add(student);

            }
            string[] admission=File.ReadAllLines("College/Admission.csv");
            foreach(string data in admission)
            {
                Admission admit= new Admission(data);
                Operations.admissionList.Add(admit);

            }
            string[] department=File.ReadAllLines("College/Department.csv");
            foreach(string data in department)
            {
                Department dpmt= new Department (data);
                Operations.departmentList.Add(dpmt);

            }
        }

        public static void WriteToFiles()
        {
            string[] studentDetails=new string[Operations.studentList.Count];
            for(int i=0; i<Operations.studentList.Count;i++)
            {
                studentDetails[i]=Operations.studentList[i].StudentId+","+Operations.studentList[i].Name+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.studentList[i].Gender+","+Operations.studentList[i].Mail+","+Operations.studentList[i].Phone+","+Operations.studentList[i].Physics+","+Operations.studentList[i].Chemistry+","+Operations.studentList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);


            string[] admission=new string[Operations.admissionList.Count];
            for(int j=0;j<Operations.admissionList.Count;j++)
            {
                admission[j]=Operations.admissionList[j].AdmissionId+","+Operations.admissionList[j].StudentId+","+Operations.admissionList[j].DepartmentId+","+Operations.admissionList[j].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.admissionList[j].Status;
            }
            File.WriteAllLines("College/Admission.csv",admission);

             string[] department=new string[Operations.departmentList.Count];
            for(int k=0;k<Operations.departmentList.Count;k++)
            {
                department[k]=Operations.departmentList[k].DepartmentId+","+Operations.departmentList[k].DpmtName+","+Operations.departmentList[k].Seats;
            }
            File.WriteAllLines("College/Department.csv",department);
        }
    }
}