

namespace QueueDS
{
    public partial class Queue<Type>
    {
        private Type[] Array{get; set;}
        
        private int _head;
        private int _capacity;
        private int _tail;
        private int _count;
        
        public int Count{get{return _count;}}
        public int  Capacity{ get{return _capacity;} }

        

        public Queue()
        {
          _count=0;
          _capacity=4;
          _head=0;
          _tail=0;
           Array=new Type[_capacity];
        }
        public void Enqueue(Type data)
        {
            if(_capacity==_tail)
            {
             GrowSize();
            }
            else
            {
            Array[_tail]=data;
            _tail++;
            _count++;
            }
        }

        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_tail;i++)
            {
                temp[i]=Array[i];
                System.Console.WriteLine(temp[i]);
            }
            Array=temp;
            

        }
        public Type Dequeue()
        { 
          Type data=default(Type);
          if(_head>_tail)
          {
            System.Console.WriteLine("Empty Queue...");
            
          }
          else 
          {
              data=Array[_head];
              _head++;
              _count--;
          }
          return data;
        }
        public Type Peak()
        {
           Type data=default(Type);
          if(_head>_tail)
          {
            System.Console.WriteLine("Empty Queue...");
            
          }
          else 
          {
              data=Array[_head];
             
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


    }
}