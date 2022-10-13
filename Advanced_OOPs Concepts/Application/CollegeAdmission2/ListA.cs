using System;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission2
{
    public partial class List<Type>
    {
        public void Insert(int index,Type data)
        {
           _capacity=_capacity+1;
           Type[]temp=new Type[_capacity];
           for(int i=0;i<_count+1;i++)
           {
            if(i<index)
            {
                temp[i]=Array[i];
            }
            else if(i==index)
            {
                temp[i]=data;   
            }
           else if(i>index)
           {
            temp[i]=Array[i-1];
           }
             
           }Array=temp;

        }
        public void RemoveAt(int index)
        {
            
           for(int i=0;i<_count;i++)
           {
            if(i<index)
            {

            }
            else if(i>=index)
            {
                Array[i]=Array[i+1]; 
            }
         }
         _count--;
        }

        public void Remove(Type value)
        {
            int j=0;
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(value))
                {
                   Array[i]=Array[i+1];
                   j=i;
                }
                else if(i>j)
                {
                   Array[i]=Array[i+1];
                }
            }
        }
    }
}