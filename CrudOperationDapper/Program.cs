 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nEmployee Management Portal\n\n");


            while (true)
            {


                Console.WriteLine("1.View All User \n2.Get User \n3.Insert User\n4.Update User \n5.Delete User");

                int.TryParse(Console.ReadLine(), out int option);
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        EmployeeInfo.GetEmployee();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter Employee Id ");
                        int.TryParse(Console.ReadLine(), out int id);

                        EmployeeInfo.GetEmployee(id);
                        break;
                    case 3:
                        Console.Clear();
                        InsertEmployee.InsertEmployees();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter Employee Id ");
                        int.TryParse(Console.ReadLine(), out int id1);
                        UpdateEmployee.UpdateEmployees(id1);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Enter Employee Id ");
                        int.TryParse(Console.ReadLine(), out int id2);
                        DeleteEmployee.DeleteEmployees(id2);
                        break;
                }
            }
        }
    }
}
