using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CrudOperationEntityFramework;

namespace CrudOperationEntityFramework
{
    static class EmployeeInfo
    {
        public static void GetEmployee()
        {
            try
            {
                using (TestDb1Entities1 connection = new TestDb1Entities1())
                {
                    var Employees = connection.Employees.ToList();

                   
                    foreach (var employee in Employees)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine($"Name : {employee.FirstName} {employee.MiddleName} {employee.LastName}      " +
                            $"\nId : {employee.EmployeeId}  Employee Code : {employee.EmpCode}  " +
                            $"\nGender : {employee.Gender}   DoB : {employee.DoB}  \n" +
                            $"Salary : {employee.Salary}   \nJoining Date : {employee.JoiningDate}  \n" +
                            $"Resign Date : {employee.ResignDate}  ");
                        Console.WriteLine("\n\n");
                    }
                   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }



        public static void GetEmployee(int id)
        {

            try
            {
                using (TestDb1Entities1 connection = new TestDb1Entities1())
                {

                    var employee = connection.Employees.Find(id);
                    if (employee != null)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine($"Name : {employee.FirstName} {employee.MiddleName} {employee.LastName}      " +
                               $"\nId : {employee.EmployeeId}  Employee Code : {employee.EmpCode}  " +
                               $"\nGender : {employee.Gender}   DoB : {employee.DoB}  \n" +
                               $"Salary : {employee.Salary}   \nJoining Date : {employee.JoiningDate}  \n" +
                               $"Resign Date : {employee.ResignDate}  ");
                        Console.WriteLine("\n\n");
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
