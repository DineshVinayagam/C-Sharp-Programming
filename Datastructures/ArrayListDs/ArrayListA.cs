using System;


namespace ArrayListDS
{
    public partial class ArrayList<Object>
    {
        public void Insert(int index,Object data)
        {
           _capacity=_capacity+1;
           Object[]temp=new Object[_capacity];
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
            
           for(int i=0;i<_capacity-1;i++)
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

        public void Remove(Object value)
        {
            int j=0;
            for(int i=0;i<_capacity-1;i++)
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