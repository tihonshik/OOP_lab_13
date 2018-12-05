using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace OOP_lab_13
{
    class TFAFileInfo
    {
        public static string GetFullPath(string path)
        {
            return Path.GetFullPath(path);
        }

        public static void GetFullInfo(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Путь : {0}", path);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length);
            }
            else
            {
                Console.WriteLine("ssssss");
            }
        }

        public static DateTime GetFullTime(string path)
        {
            return File.GetCreationTime(path);
        }
    }
}
