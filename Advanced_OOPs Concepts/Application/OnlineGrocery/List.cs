using System;

namespace OnlineGrocery
{
    public partial class List<Type>
    {
        private Type[] Array{get;set;}
        private int _count;
        private int _capacity;
        public int  Count { get{return _count;}}
        public int Capacity { get{return _capacity; }}

        public Type this[int i] { get{return Array[i];}set{Array[i]=value;}} //Indexer

        public List()

           {
              _count=0;
              _capacity=4;
              Array=new Type[_capacity];
            }
        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }

        public void Add(Type data)
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
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
            

        }
        public void AddRange(List<Type> list){
            int j=0;
            if(_count+list.Count>=_capacity)
            {
             _capacity=_capacity+list.Count;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
                System.Console.WriteLine(temp[i]);
            }
            Array=temp;
            }
            for(int i=_count;i<_count+list.Count;i++)
            {
                Array[i]=list[j];
                j++;
            }_count +=list.Count;
        }

    }
}