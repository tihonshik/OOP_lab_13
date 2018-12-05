using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace OOP_lab_13
{
    class TFALog
    {

        private static string filePath = "TFAlogfile.txt";

        public static void Log(Type t, string info)
        {
            string line = DateTime.Now + " : " + t.FullName + " : " + info;

            using (StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine(line);
            }
        }

        public static List<string> Read()
        {
            return new List<string>(File.ReadAllLines(filePath));
        }

        public static int LogLength()
        {
            return new List<string>(File.ReadAllLines(filePath)).Count;
        }

        public static void PrintByKeyword(string keyword)
        {
            new List<string>(File.ReadAllLines(filePath))
                .Where(l => l.Contains(keyword)).ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
