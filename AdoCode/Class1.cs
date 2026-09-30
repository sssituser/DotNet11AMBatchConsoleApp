using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoCode
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            BusinessLogicLayer bl = new BusinessLogicLayer();
            Menu:
            Console.Write("1.Add\n2.Delete\n3.Update\n4.FindAll\nEnter Your choce :");
            int choice = int.Parse(Console.ReadLine());
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


                    if (bl.RegisterEmployee(id, name, sal))
                    {
                        Console.WriteLine("Employee added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Failed to Register the employee...");
                    }
                    goto Menu;
                case 2:
                    if (bl.GetEmployees().Tables["employee"].Rows.Count>0)
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
                    if (bl.GetEmployees().Tables["employee"].Rows.Count>0)
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
                   
                    if (bl.GetEmployees().Tables["employee"].Rows.Count>0)
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Id\tName\tSal");
                        Console.WriteLine("===============================");
                        foreach(DataRow row in bl.GetEmployees().Tables["employee"].Rows)
                        {
                            Console.WriteLine($"{row["eid"]}\t{row["ename"]}\t{row["esal"]}");
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
