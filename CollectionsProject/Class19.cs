using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    /*
     * Write a proram to find the frequenccy of the given name;\
     * arun
     * a - 1
     * r - 1
     * u - 1
     * n - 1
     */
    internal class Class19
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a name : ");
            string name = Console.ReadLine();
            SortedList<char,int> frequency = new SortedList<char,int>();
            
                foreach(char ch in name) // name=abac
                {
                    if (frequency.ContainsKey(ch))
                    {
                        int val = frequency[ch];
                        frequency.Remove(ch);
                        frequency.Add(ch, val+1);
                    }
                    else
                    {
                        frequency.Add(ch, 1);
                    }
                }
            

            Console.WriteLine("Frequenct of the given chcaracter is ");
            foreach (KeyValuePair<char,int> item in frequency)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Unique Characters in the given name");
            foreach(char key in frequency.Keys)
            {
                if (frequency[key] == 1)
                {
                    Console.WriteLine($"{key}  {frequency[key]}");
                }
            }

            Console.WriteLine("Duplicate Characters in the given name");
            foreach (char key in frequency.Keys)
            {
                if (frequency[key] != 1)
                {
                    Console.WriteLine($"{key}  {frequency[key]}");
                }
            }

        }
    }
}
