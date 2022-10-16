using System;

namespace ArrayListDS
{
    public partial class ArrayList<Object>
    {
        private Object[] Array{get;set;}
        private int _count;
        private int _capacity;
        public int  Count { get{return _count;}}
        public int Capacity { get{return _capacity; }}

        public Object this[int i] { get{return Array[i];}set{Array[i]=value;}} 

        public ArrayList()

           {
              _count=0;
              _capacity=4;
              Array=new Object[_capacity];
            }
        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Object[_capacity];
        }

        public void AddElement(Object data)
        {
            if(_count==_capacity)
            {
               GrowSize();
            }
            Array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Object[] temp=new Object[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
                System.Console.WriteLine(temp[i]);
            }
            Array=temp;
            

        }

    }
}