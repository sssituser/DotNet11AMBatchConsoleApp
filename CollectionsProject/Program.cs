using System;
using System.Collections.Generic;
using System.Collections;
using System.Security.AccessControl;
using System.Xml.Schema;


namespace CollectionsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val = string.Empty;
            Stack s = new Stack();
        Menu:
            Console.Write("1.Push\n2.Pop\n3.Count\n4.Display\n5.Find\n6.Clear\n7.Top Elemnt\nEnter Your choice  : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
           
            switch (choice)
            {
                case 1:
                    Console.Write("Enter a Value : ");
                    val = Console.ReadLine();
                    s.Push(val);
                    Console.WriteLine($"{val} Added Successfully.....");
                    goto Menu;
                case 2:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("No Elements To Remove");
                    }
                    else
                    {
                        Console.WriteLine($"Deleted Element is : {s.Pop()}");
                    }
                    goto Menu;
                case 3:
                    Console.WriteLine($"Stack has :{s.Count} elements");
                    goto Menu;
                case 4:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("No Elements To Display");
                    }
                    else
                    {
                        Console.WriteLine("=============Elelments Present In The Stack Are =======");
                        foreach (var item in s)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    goto Menu;
                case 5:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("No Elements In The Stack");
                    }
                    else
                    {
                        Console.Write("Enter Element to Check : ");
                        val = Console.ReadLine();
                        if (s.Contains(val))
                        {
                            Console.WriteLine($"{val} Exists in the Stack");

                        }
                        else
                        {
                            Console.WriteLine($"{val} Not Exists in the Stack");
                        }
                        
                    }
                    goto Menu;
                case 6:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("Stack Has No Elements to Clear");
                    }
                    else
                    {
                        s.Clear();
                        Console.WriteLine("All the elements cleared from the stack..");
                    }
                    goto Menu;
                case 7:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("No Elements present in the Stack");
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
