using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string val = string.Empty;
            Queue s = new Queue();
        Menu:
            Console.Write("1.Insert\n2.Delete\n3.Count\n4.Display\n5.Find\n6.Clear\n7.Top Elemnt\nEnter Your choice  : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a Value : ");
                    val = Console.ReadLine();
                    s.Enqueue(val);
                    Console.WriteLine($"{val} Added Successfully.....");
                    goto Menu;
                case 2:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("No Elements To Remove");
                    }
                    else
                    {
                        Console.WriteLine($"Deleted Element is : {s.Dequeue()}");
                    }
                    goto Menu;
                case 3:
                    Console.WriteLine($"Queue has :{s.Count} elements");
                    goto Menu;
                case 4:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("No Elements To Display");
                    }
                    else
                    {
                        Console.WriteLine("=============Elelments Present In The Queue Are =======");
                        foreach (var item in s)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    goto Menu;
                case 5:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("No Elements In The Queue");
                    }
                    else
                    {
                        Console.Write("Enter Element to Check : ");
                        val = Console.ReadLine();
                        if (s.Contains(val))
                        {
                            Console.WriteLine($"{val} Exists in the Queue");

                        }
                        else
                        {
                            Console.WriteLine($"{val} Not Exists in the Queue");
                        }

                    }
                    goto Menu;
                case 6:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("Queue Has No Elements to Clear");
                    }
                    else
                    {
                        s.Clear();
                        Console.WriteLine("All the elements cleared from the Queue..");
                    }
                    goto Menu;
                case 7:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("No Elements present in the Queue");
                    }
                    else
                    {
                        Console.WriteLine($"Top element in the Stack : {s.Peek()}");
                    }
                    goto Menu;
                default:
                    Console.WriteLine("Invali choice ...");
                    goto Menu;


            }


        }
    }
}
