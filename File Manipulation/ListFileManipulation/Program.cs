using System;
using System.Collections.Generic;
using System.IO;
 namespace ListFileManipulation;
  class Program{
    public static void Main(string[] args)
    {
        List<StudentDetails>list=new List<StudentDetails>();
        list.Add(new StudentDetails(){Name="dinesh",FathersName="Vinayagam",Gender=Gender.Male,DOB=new DateTime(2000,11,07)});
        list.Add(new StudentDetails(){Name="Ravi",FathersName="Ettaparajan",Gender=Gender.Male,DOB=new DateTime(1994,10,02)});
        list.Add(new StudentDetails(){Name="Baskaran",FathersName="Sethurajan",Gender=Gender.Male,DOB=new DateTime(1991,08,03)});
        Insert(list);
        Display();
    }
    static void Insert(List<StudentDetails> list)
    {
        StreamWriter write=null;
        if(!File.Exists("Data.csv"))
        {
            System.Console.WriteLine("File doesn't exist. Creating a new CSV file");
            File.Create("Data.csv");
        }
        else
        {
          System.Console.WriteLine("File Found");
        }
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var v in list)
        {
            write.WriteLine(v.Name+","+v.FathersName+","+v.Gender+","+v.DOB.ToString("dd/MM/yyyy"));
        }
        write.Close();

    }
    static void Display()
    {
        StreamReader reader=null;
        List<StudentDetails>list1=new List<StudentDetails>();
        if(File.Exists("Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("Data.csv"));
            while(!reader.EndOfStream)
            {
                var line=reader.ReadLine();
                var values=line.Split(',');
                if(values[0]!="")
                {
                    list1.Add(new StudentDetails(){Name=values[0],FathersName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                }
                
            }
        }
        else{
           
                    System.Console.WriteLine("File doesn't exist");
            }
            reader.Close();
            foreach(var coloumn1 in list1)
            {
                System.Console.WriteLine("Your Name:\t"+coloumn1.Name+"\t Father Name:\t"+coloumn1.FathersName+"\t Gender is:\t"+coloumn1.Gender +"\t Date of Birth is:\t"+coloumn1.DOB);
            }
    }
  }