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
    internal static class InsertEmployee
    {

        public static void InsertEmployees()
        {
            try
            {
                using (TestDb1Entities1 connection = new TestDb1Entities1())
                {
                     var employee = new Employee()
                     {
                      FirstName = "Jayesh",
                      MiddleName="K",
                      LastName = "Bellani",
                      EmpCode = 999,
                      Gender =1,
                      DoB = new DateTime(2023, 01, 03),
                      Salary = 60000,
                      JoiningDate = new DateTime(2023, 01, 03)
                     };
                    connection.Employees.Add(employee);
                    connection.SaveChanges();
                    Console.WriteLine("\nUser Added !!\n");

                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine($"Error  :  {Ex.Message}");
            }
        }
    }
}


 