using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppAsnchronousPrograming
{
    internal class Program
    {
        async static  Task Main (string[] args)
        {
            Console.WriteLine("Program Started");
            Task<int> res =ReadData();
            
            Console.WriteLine("Doing Other Task");
            await WriteData();
            int result = await res;
            Console.WriteLine($"Data is : {result}");
        }

        public async static  Task<int> ReadData ()
        {
            Console.WriteLine("Fetching the Data from Data Base");
           await Task.Delay(5000);
            Console.WriteLine("Data Fetched , Iam Returning the Data");
            return 100;
        }
        public async static Task WriteData ()
        {
            Console.WriteLine("Hi Iam Writing the Data");
        }
    }
}
