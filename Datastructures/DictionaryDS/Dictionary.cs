using System;


namespace DictionaryDS
{
    public partial class Dictionary <TKey,TValue>
    {
        public TKey Key{get; set;}
        public TValue Value{get;set;}
        private int _count;
        private int _capacity;
        public int  Count { get{return _count;}}
        public int Capacity { get{return _capacity; }}
        public Dictionary<TKey,TValue>[] Array{get; set;}


        public Dictionary()
        {
          
              _capacity=4;
              _count=0;
              Array=new Dictionary<TKey,TValue>[_capacity];
           
        }

        public Dictionary(int size)
        {
           if(size==0)
           {
              _capacity=4;
              _count=0;
              Array=new Dictionary<TKey,TValue>[_capacity];
           }
           else{
            _capacity=size*2;
            _count=0;
            Array=new Dictionary<TKey,TValue>[_capacity];
           }
        }

        public void AddElement(TKey key,TValue value)
        {
            if(_count==_capacity)
            {
               GrowSize();
            }

            bool temp=false;
            bool temp1=LinearSearch(key,out int index);
            if(temp1)
            {
                temp=true;
                System.Console.WriteLine("Duplicate Key");
            }
            if(!temp)
            {
            Dictionary<TKey,TValue> entry=new Dictionary<TKey,TValue>();
            entry.Key=key;
            entry.Value=value;
            Array[_count]=entry;
            _count++;
            }
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Dictionary<TKey,TValue>[] temp=new  Dictionary<TKey,TValue>[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
                System.Console.WriteLine(temp[i]);
            }
            Array=temp;
            

        }

        public bool LinearSearch(TKey key,out int index)
        {
           bool temp=false;
           index=0;
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Key.Equals(key))
                {
                   index=i;
                   temp=true;
                   break;
                }
                else{
                    temp=false;
                }
            }return temp;
            
        }
        public void Display()
        {
            foreach(Dictionary<TKey,TValue>element in Array)
            {
                if(element!=null)
                {
                    System.Console.WriteLine("Key:"+element.Key+"\t"+"Value:"+element.Value);
                }
            }
        }
        public TValue this[TKey key]
        {
            get{
                TValue output=default(TValue);
                int index=0;
                bool temp=LinearSearch(key,out index);
                if(temp)
                {
                    output=Array[index].Value;

                }
                else{
                    System.Console.WriteLine("Invalid Key");
                }
                return output;
            } 
            set{
                int position=0;
                bool temp=LinearSearch(key,out position);
                if(temp)
                {
                    Array[position].Value=value;

                }
                else{
                    System.Console.WriteLine("Invalid Key...");
                }

            }
        }

    }
}