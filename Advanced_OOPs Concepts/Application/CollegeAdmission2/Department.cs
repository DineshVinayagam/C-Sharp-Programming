using System;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission2
{
    public class Department

    {

        
        private  static int s_departmentid=100;
        public string DepartmentId {get;}
        public string  DpmtName { get; set; }
        public int Seats  { get; set; }

        public Department(string dpmtname,int seats)
        {
            s_departmentid++;
            DepartmentId="DID"+s_departmentid;

           DpmtName=dpmtname;
           Seats=seats;

        }
        public Department(string data)
        {
            string[] values=data.Split(',');
            s_departmentid=int.Parse(values[0].Remove(0,3));
            DepartmentId=values[0];
            DpmtName=values[1];
            Seats=int.Parse(values[2]);
        }
      
        
       
    }
}