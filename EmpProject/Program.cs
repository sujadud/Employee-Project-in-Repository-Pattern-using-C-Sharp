using EmpProject.BL;
using EmpProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpBusiness empBusiness = new EmpBusiness(new EmpRepo());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update, 'D' for Delete, 'S' for Search, 'C' for Clear, 'E' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Emp> _EmpList = empBusiness.Get();
                        Console.WriteLine("List of Employess: ");
                        Console.WriteLine("ID\t|\tName\t|\tAddress");
                        foreach(Emp _emp in _EmpList)
                        {
                            Console.WriteLine(_emp.ID + "    |    " +_emp.Name + "    |    " +_emp.Address);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a employee: ");
                        string id = Console.ReadLine();
                        Emp aEmp = empBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aEmp.ID + ". " + aEmp.Name + " -- " + aEmp.Address);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Emp aEmp = new Emp();
                        aEmp.ID = Convert.ToInt32(id);
                        aEmp.Name = name;
                        aEmp.Address = address;
                        bool isExecuted = empBusiness.Create(aEmp);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Emp aEmp = new Emp();
                        aEmp.ID = Convert.ToInt32(id);
                        aEmp.Name = name;
                        aEmp.Address = address;
                        bool isExecuted = empBusiness.Update(aEmp);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = empBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "E")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            
        }
    }
}
