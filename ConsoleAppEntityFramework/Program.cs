using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework
{
    internal class Program
    {
        static void Main (string[] args)
        {
            
            BuinessLogic bl = new BuinessLogic();
            Menu:
            Tbl_Employee emp = new Tbl_Employee();
            Console.Write("1.Add\n2.Find\n3.Update\n4.Show All\n5.Delete\nEnter Your Choice : ");
            int ch =int.Parse(Console.ReadLine());
            Console.Clear();
            switch (ch)
            {
                case 1:
                    Back:
                    Console.Write("Enter Employee ID : ");
                    emp.eid = int.Parse(Console.ReadLine());
                    if (bl.IsEmployee(emp))
                    {
                        Console.WriteLine($"Employee Exists With the Given Id : {emp.eid} Try with Other Id");
                        goto Back;
                    }
                    else
                    {
                        Console.Write("Enter Employee Name : ");
                        emp.ename = Console.ReadLine();
                        Console.Write("Enter Employee Salary : ");
                        emp.esal = int.Parse(Console.ReadLine());
                        if (bl.AddEmployee(emp))
                        {
                            Console.WriteLine("Employee Added Sucessfully");
                        }
                        else
                        {
                            Console.WriteLine("Failed To Add Employee");
                        }
                    }

                    goto Menu;
                case 2:

                    if (bl.CheckEmployees())
                    {
                        Console.Write("Enter Employee ID : ");
                        emp.eid = int.Parse(Console.ReadLine());
                        emp = bl.GetEmployeeById(emp);
                        if (emp is null)
                        {
                            Console.WriteLine($"Employee Not Found with the Above ID");
                        }
                        else
                        {
                            Console.WriteLine($"Name : {emp.ename}\nSalary : {emp.esal}");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Employees Not Found");
                    }

                    goto Menu;
                case 3:

                    if (bl.CheckEmployees())
                    {
                        Console.Write("Enter Employee ID : ");
                        emp.eid = int.Parse(Console.ReadLine());

                        if (bl.IsEmployee(emp))
                        {
                            Console.Write("Enter Employee Name : ");
                            emp.ename = Console.ReadLine();
                            Console.Write("Enter Employee Salary : ");
                            emp.esal = int.Parse(Console.ReadLine());
                            if (bl.UpdateEmployee(emp))
                            {
                                Console.WriteLine("Employee Updated Sucessfully");
                            }
                            else
                            {
                                Console.WriteLine("Failed to Update Employee.");
                            }
                        }
                        else
                        {
                           
                            Console.WriteLine("Employee Does't Exist with Given Id");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Employees Not Found");
                    }

                    goto Menu;
                case 4:
                    if (bl.CheckEmployees())
                    {
                        Console.WriteLine("=========================================");
                        Console.WriteLine("EmpId\t\tEmpName\t\tEmpSal");
                        Console.WriteLine("=========================================");
                        foreach (Tbl_Employee eemp in bl.GetEmployees())
                        {
                            Console.WriteLine($"{eemp.eid}\t\t{eemp.ename}\t\t{eemp.esal}");
                        }
                        Console.WriteLine("=========================================");
                    }
                    else
                    {
                       
                        Console.WriteLine("Employees Not Found");
                    }
                    goto Menu;
                case 5:
                    if (bl.CheckEmployees())
                    {
                        Console.Write("Enter Employee ID : ");
                        emp.eid = int.Parse(Console.ReadLine());
                        if (bl.IsEmployee(emp))
                        {
                            if (bl.DeleteEmployeeById(emp))
                            {
                                Console.WriteLine("Employee Deleted...");
                            }
                            else
                            {
                                Console.WriteLine("Failed To Delete Employee..");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Employee Doesn't Exist with the Given ID");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Employees Not Found");
                    }
                    goto Menu;
            }
        }
    }
}
