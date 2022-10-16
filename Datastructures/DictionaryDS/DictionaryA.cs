using System;


namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        public bool ContainsKey(TKey key)
        {
            bool cmp=false;
            cmp=LinearSearch(key,out int index);
            if(cmp)
            {
                cmp=true;
                
            }
            return cmp;
        }
         public bool ContainsValue(TValue value)
        {
            bool cmp=false;
            Dictionary<TKey,TValue>[] Array=new Dictionary<TKey,TValue>[Count];
            for(int i=0;i<Count;i++)
            {
               if(Array[i].Value.Equals(value))
               {
                cmp=true;
               }
            }
            return cmp;
            

        }
       
       public Dictionary<TKey,TValue>ElementAt(int index)
       {
        Dictionary<TKey,TValue> output=null;
        if(index>-1 && index<Count)
        {
            output=Array[index];
        }
        else
        {
            System.Console.WriteLine("Tried to access Out of Board");
        }
        return output;
       }

       public bool Remove(TKey key)
       {
        bool temp=LinearSearch(key,out int index);
        if(temp)
        {
            for(int i=index;i<_capacity-1;i++)
            {
                Array[i]=Array[i+1];
                temp=true;
            }
            _count--;
        }return temp;
       }
    }
}