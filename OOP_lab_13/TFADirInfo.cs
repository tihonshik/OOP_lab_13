using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace OOP_lab_13
{
    class TFADirInfo
    {
        public static void GetAllFile(string path)
        {
            int counter = 0;
            Directory
                .GetFiles(Path.GetDirectoryName(Path.GetFullPath(path)), "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => { { if (Path.GetFileName(f).Contains(".")) { Console.WriteLine(Path.GetFileName(f)); counter++; } } });
            Console.WriteLine("Counter file: " + counter);
        }

        public static void GetAllTime(string path)
        {
            Directory
                .GetFiles(Path.GetDirectoryName(Path.GetFullPath(path)), "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => Console.WriteLine(Path.GetFileName(f) + " " + File.GetCreationTime(Path.GetFullPath(f))));
        }

        public static void GetAllSubdir(string path)
        {
            int counter = 0;
            Directory
                .GetDirectories(Path.GetDirectoryName(Path.GetFullPath(path)), "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => { Console.WriteLine(Path.GetFileName(f)); counter++; });
            Console.WriteLine("Counter subdir: " + counter);
        }

        public static void GetAllDir(string path)
        {
            Directory
                .GetDirectories(Path.GetDirectoryName(Path.GetFullPath(path)), "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => Console.WriteLine(f));
        }
    }
}
