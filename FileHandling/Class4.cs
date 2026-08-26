using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
namespace FileHandling
{
    internal class Class4
    {
        static void Main(string[] args)
        {
        
            foreach(DriveInfo info in DriveInfo.GetDrives())
            {
                long totalSize = info.TotalSize/(1024*1024*1024);
                long freeSpaceSize = info.TotalFreeSpace/(1024*1024*1024);
                long usedSpaceSize = totalSize - freeSpaceSize;
                Console.WriteLine("=========================================================");
                Console.WriteLine($"{info.Name}\tTotalSpace : {totalSize}GB\tUsed Space : {usedSpaceSize}GB\tFree Sapce : {freeSpaceSize}GB");
                 string[] direcories =   Directory.GetDirectories(info.Name);
                string[] files = Directory.GetFiles(info.Name);
                
                Console.WriteLine($"===========Folders Present In The {info.Name.Substring(0,info.Name.Length-1)} =============");
                foreach(string s in direcories)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine($"===========Files Present In The {info.Name.Substring(0, info.Name.Length - 1)} =============");

                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
