using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace AdoCode
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Menu:
            Console.Write("1.Add\n2.Delete\n3.Update\n4.Find All Enter Your choice : ");
            int choice = int.Parse(Console.ReadLine());
            BusinessAccessLayer bl = new BusinessAccessLayer();
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter ID : ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name : ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Salary :");
                    int sal = int.Parse(Console.ReadLine());


                    if (bl.AddEmployee(id, name, sal))
                    {
                        Console.WriteLine("Employee added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Failed to Register the employee...");
                    }
                    goto Menu;
                case 2:
                    if (bl.GetEmployees().HasRows)
                    {
                        Console.Write("Enter ID : ");
                        id = int.Parse(Console.ReadLine());
                        if (bl.CheckEmployee(id))
                        {
                            if (bl.DeleteEmployeeById(id))
                            {
                                Console.WriteLine("Employee Deleted Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Failed to Delete the employee...");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Employee Not Available with given {id}");
                        }



                    }
                    else
                    {
                        Console.WriteLine("Emloyess Inforamtion is not Available");
                    }
                    goto Menu;
                case 3:
                    if (bl.GetEmployees().HasRows)
                    {
                        Console.Write("Enter ID : ");
                        id = int.Parse(Console.ReadLine());
                        if (bl.CheckEmployee(id))
                        {
                            Console.Write("Enter Name : ");
                            name = Console.ReadLine();

                            Console.Write("Enter Salary :");
                            sal = int.Parse(Console.ReadLine());


                            if (bl.UpdateEmployee(id, name, sal))
                            {
                                Console.WriteLine("Employee Updated Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Failed to Update the employee...");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No Employee Found With the Id : {id}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Emloyess Inforamtion is not Available");
                    }
                    goto Menu;
                case 4:
                    SqlDataReader dr = bl.GetEmployees();
                    if (dr.HasRows)
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Id\tName\tSal");
                        Console.WriteLine("===============================");
                        while (dr.Read())
                        {
                            Console.WriteLine($"{dr.GetInt32(0)}\t{dr.GetString(1)}\t{dr.GetInt32(2)}");
                        }
                        Console.WriteLine("===============================");

                    }
                    else
                    {
                        Console.WriteLine("Employee Details Not Exists");
                    }
                    goto Menu;

            }
        }
    }
}
