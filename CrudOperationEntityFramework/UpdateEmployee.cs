using CrudOperationEntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationEntityFramework
{
    internal static class UpdateEmployee
    {

        public static void UpdateEmployees(int id)
        {
            try {
                using (TestDb1Entities1 connection = new TestDb1Entities1())
                {

                    var employee = connection.Employees.Find(id);
                    if (employee != null)
                    {
                        employee.FirstName = "Jenish";
                        employee.MiddleName = "K";
                        employee.LastName = "Raiyani";
                        employee.Salary = 70000;

                        connection.SaveChanges();

                        Console.WriteLine("\nUser Updated !!\n");
                    }
                    else
                    {
                        Console.WriteLine("\n\n Invalid Id \n\n");
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
    }   }
}


 