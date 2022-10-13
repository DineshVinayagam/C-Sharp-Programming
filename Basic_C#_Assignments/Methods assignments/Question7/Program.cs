using System;
 namespace Question7;
 class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string to check:");
        string word=Console.ReadLine();
        Palindrome(word);
        


        void Palindrome(string str)
        {
           string str2="";
           
           for(int i=str.Length-1;i>=0;i--)
           {
             str2=str2+str[i].ToString();
              
              
           }
           
             if(str==str2)
             {
               System.Console.WriteLine("The string is palindrome");
             }
             else
             {
               System.Console.WriteLine("The string is not a plaindrome");
             }
             
           }
           
           
        }
    }
 