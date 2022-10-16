using System;


namespace StackDS
{
    public partial class Stack<Type>
    {
        private Type[] Array{get; set;}
        private int _count;
        private int _capacity;
        public int Count { get{return _count;}}



        public Stack()
        {
           _count=0;
           _capacity=4;
           Array=new Type[_capacity];
        }

        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }

        public void Push(Type data)
        {
            if(_count==_capacity)
            {
                Growsize();
            }
            Array[_count]=data;
            _count++;
        }

        public void Growsize()
        {
           _capacity=_capacity*2;
           Type[] temp=new Type[_capacity];
           for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
                System.Console.WriteLine(temp[i]);
            }
            Array=temp;
        }
        public Type Pop()
        { 
          Type data=default(Type);
          if(_count<0)
          {
            System.Console.WriteLine("Empty Stack...");
            
          }
          else if(_count>=0)
          {
              data=Array[_count];
              _count--;
          }
          return data;
        }

        public bool Contains( Type data)
        {
          bool contain=true;
          for(int i=0;i<_count;i++)
          {
            if(Array[i].Equals(data))
            {
               contain=true;
            }
            else{
                contain=false;
            }
            
          }return contain;
        }
        public Type Peak()
        {
          Type data=default(Type);
          if(_count<0)
          {
            System.Console.WriteLine("Empty Stack...");
            
          }
          else if(_count>=0)
          {
              data=Array[_count];
          }
          return data;
        }
    }
}