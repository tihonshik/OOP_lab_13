using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Reflection;


namespace OOP_lab_13
{
    class Program
    {

        static void Main(string[] args)
        {
            System.IO.File.Delete("TFAlogfile.txt");
            System.IO.File.Delete("1TFAlogfile.txt");
            System.IO.File.Delete("2.txt");
            System.IO.File.Delete("12.txt");
            //System.IO.File.Create("1.txt");


            TFALog.Log(typeof(Program), "logo");
            Console.WriteLine("Disk Info");
            Console.WriteLine(TFADiskInfo.GetFreeSpace("D:\\"));
            Console.WriteLine(TFADiskInfo.GetTotalFreeSpace());
            TFADiskInfo.GetAllInfo();

            Console.WriteLine("File info");
            Console.WriteLine(TFAFileInfo.GetFullPath("Program.cs"));
            TFAFileInfo.GetFullInfo("1.txt");
            Console.WriteLine(TFAFileInfo.GetFullTime("1.txt"));

            Console.WriteLine("Dir info");
            TFADirInfo.GetAllFile("Program.cs");
            TFADirInfo.GetAllTime("Program.cs");
            TFADirInfo.GetAllSubdir("Program.cs");
            TFADirInfo.GetAllDir("Program.cs");

            Console.WriteLine("File manager");
            TFAFileManager.GetAllFileDir("1.txt", "", "1.txt");
            TFAFileManager.MoveFile("1.txt", "1", "*");
            TFAFileManager.Archive();
           
            Console.WriteLine("+");
        }
    }
}
