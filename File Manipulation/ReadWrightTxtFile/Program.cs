using System;
using System.IO;
 namespace ReadWrightTxtFile;
  class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("FolderCreated");
        }
        else{
            System.Console.WriteLine("Folder Exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created");
        }
        else{
            System.Console.WriteLine("File Found");
        }
        System.Console.WriteLine("Select the option: 1.Read File Info 2. Write File Info");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                string line;
                StreamReader sr=null;
                try{
                    //pass the file path and file name to the StreamReader constructor
                    sr=new StreamReader("TestFolder/Test.txt");
                    //Read the first line of text
                    line=sr.ReadLine();
                    while(line!=null)
                    {
                        //write the line to console window
                        System.Console.WriteLine(line);
                        //Read the next line
                        line=sr.ReadLine();
                    }
                }catch(Exception e)
                {
                    System.Console.WriteLine("Exception:"+e.Message);
                }finally
                {
                    if(sr!=null)
                    {
                        Console.WriteLine("Executing finally block.");
                        sr.Close();
                        
                    }
                }
                break;
            }
            case 2:
            {
                string line;
                StreamWriter sw=null;
                try
                {
                  string[] old=File.ReadAllLines("TestFolder/Test.txt");
                  //pass the filepath and file name to the steamwriter constructor to open
                  sw=new StreamWriter("TestFolder/Test.txt");
                  System.Console.WriteLine("Enter new content to be placed in file");
                  string info=Console.ReadLine();
                  string old1="";
                  foreach(string text in old)
                  {
                    old1=old1+"\n"+text;
                  }
                  old1=old1+"\n"+info;
                  sw.Write(old1);
                }catch(Exception e)
                {
                    System.Console.WriteLine("Exception:"+e.Message);
                }finally
                {
                    //close the file
                    if(sw!=null)
                    {
                        Console.WriteLine("Executing finally block.");
                        sw.Close();
                        
                    }
                }

                break;
            }
        }
        
    }
  }