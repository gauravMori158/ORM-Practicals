using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CrudOperationEntityFramework;

namespace CrudOperationEntityFramework
{
    internal static class DeleteEmployee
    {

        public static void DeleteEmployees(int id)
        {
            try
            {
                using (TestDb1Entities1 connection = new TestDb1Entities1())
                {
                    var employee = connection.Employees.Find(id);
                    if (employee != null)
                    {
                        connection.Employees.Remove(employee);
                        connection.SaveChanges();
                        Console.WriteLine("\nUser Deleted !!\n");

                    }
                    else
                    {
                        Console.WriteLine("\n\n Invalid Id \n\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
        
    }
}

 
