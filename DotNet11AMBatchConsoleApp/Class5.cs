using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Memory Occupied by Byte is :{sizeof(byte)} Byte ");
            Console.WriteLine($"Memory Occupied by SByte is :{sizeof(sbyte)} Byte ");
            Console.WriteLine($"Memory Occupied by short is :{sizeof(short)} Bytes ");
            Console.WriteLine($"Memory Occupied by ushort is :{sizeof(ushort)} Bytes ");
        }
    }
}
