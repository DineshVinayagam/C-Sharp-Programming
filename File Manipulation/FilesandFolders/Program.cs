using System;
using System.IO;

 namespace FilesandFolders;
  class Program{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\DineshVinayagam\OneDrive - Syncfusion\Desktop\MyFolder2";
        string folderPath=path+"/Dinesh";
        string filePath=path+"/newFile.txt";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found. So, creating folder");
            Directory.CreateDirectory(folderPath);
        }
        else{
            System.Console.WriteLine("Directory found");
        }
        if(!Directory.Exists(filePath))
        {
            System.Console.WriteLine("Folder not found. So, created file");
            File.Create(filePath);
        }
        else{
            System.Console.WriteLine("Directory found");
        }



        System.Console.WriteLine("Select option 1.CreateFolder 2.Create File 3.Delete Folder 4.Delete");
        int num=int.Parse(Console.ReadLine());
        switch(num)
        {
            case 1:
            {
                System.Console.WriteLine("Enter folder name you want to create");
                string folderName=Console.ReadLine();
                folderPath=path+"\\"+folderName;
                if(!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    System.Console.WriteLine("Folder created");
                }
                else{
                    System.Console.WriteLine("File Name already Exists");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter file name you want to create");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter file extention you want to create");
                string extention=Console.ReadLine();
                string newPath=path+"\\"+fileName+"."+extention;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                    System.Console.WriteLine("The File is created");
                }
                else{
                    System.Console.WriteLine("File Name already Exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path)) //It is like File manager
                {System.Console.WriteLine(name);}
                System.Console.WriteLine("Select folder you want to delete:");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)  //check folder matches
                    {
                        Directory.Delete(newPath);
                        Console.WriteLine("Folder Deleted");
                    } 
                }
                break;
            }
            case 4:
            {
               foreach(string name in Directory.GetFiles(path))
               {Console.WriteLine(name);}
               System.Console.WriteLine("Select file you want to delete:");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Select the extention you want to delete ");
                string name2=Console.ReadLine();
                
                string newPath=path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)  //check folder matches
                    {
                       File.Delete(newPath);
                       Console.WriteLine("File Deleted");
                    } 
                }

                break;
            }
        }
    }
  }