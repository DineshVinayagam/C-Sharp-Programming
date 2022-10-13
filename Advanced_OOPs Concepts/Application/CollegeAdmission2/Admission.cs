using System;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission2
{
    public enum Status{Admitted,Cancelled}
    public class Admission
    {
        private static int s_admissionid=1000;
        public string AdmissionId {get; }
        public string StudentId{get;}
        public string DepartmentId {get;}
        public Status Status { get; set; }
        public DateTime AdmissionDate { get; set; }

        public Admission(string studentid,string departmentid,DateTime admissiondate,Status status)
        {
            s_admissionid++;
            AdmissionId="AID"+s_admissionid;
            StudentId=studentid;
            DepartmentId=departmentid;
            AdmissionDate=admissiondate;
            Status=status;


        }
        public Admission(string data)
        {
            string[] values=data.Split(',');
            s_admissionid=int.Parse(values[0].Remove(0,3));
            AdmissionId=values[0];
            StudentId=values[1];
            DepartmentId=values[2];
            AdmissionDate=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Status=Enum.Parse<Status>(values[4]);
            
        }
        
       
        
    }
}