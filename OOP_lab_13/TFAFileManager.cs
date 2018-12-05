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
    class TFAFileManager
    {
        public static void GetAllFileDir(string path, string filePath, string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, fileName)))
            {
                Directory.GetFiles(Path.GetDirectoryName(Path.GetFullPath(path)), "*", SearchOption.AllDirectories)
                    .ToList()
                    .ForEach(f => outputFile.WriteLine(Path.GetFileName(f)));
            }

            File.Copy(Path.Combine(filePath, fileName), "2.txt", true);
            File.Delete(Path.Combine(filePath, fileName));
        }

        public static void MoveFile(string path, string pathNew, string extension)
        {
            Directory
                .GetFiles(Path.GetDirectoryName(Path.GetFullPath(path)), extension, SearchOption.AllDirectories)
                .ToList()
                .Where(f => Path.GetFileName(f).Contains("."))
                .ToList()
                .ForEach(f => File.Copy(Path.GetFileName(f), pathNew + Path.GetFileName(f), true));
        }

        public static void Archive()
        {
            System.IO.File.Delete(@"D:\example\result.zip");
            string startPath = @"D:\example\start";
            string zipPath = @"D:\example\result.zip";
            string extractPath = @"D:\example\extracts";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
