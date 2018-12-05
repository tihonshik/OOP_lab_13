using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace OOP_lab_13
{
    class TFADiskInfo
    {
        public static long GetFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.TotalFreeSpace;
                }
            }
            return -1;
        }

        public static long GetTotalFreeSpace()
        {
            long freeSpace = 0;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    freeSpace += drive.TotalFreeSpace;
                }
            }
            return freeSpace;
        }

        public static void GetAllInfo()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    Console.WriteLine("Name: " + drive.Name);
                    Console.WriteLine("Free space: " + drive.TotalFreeSpace);
                    Console.WriteLine("Space: " + drive.TotalSize);
                    Console.WriteLine("Label: " + drive.VolumeLabel);
                }
            }
        }
    }
}
