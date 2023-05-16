using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
 

namespace CrudOperationDapper
{
    static class EmployeeInfo
    {
        public static void GetEmployee()
        {
            try
            {
                using ( var connection = new SqlConnection(Validate.GetsConnectionString()))
                {
                    string query = "select * from Employee";
                    var Employees = connection.Query<Employee>(query ).ToList();
                   
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



        public static void GetEmployee(int id1)
        {

            try
            {
                using (var connection = new SqlConnection(Validate.GetsConnectionString()))
                {

                    string query = "select * from Employee Where EmployeeId =@id";
                    var employee = connection.QueryFirstOrDefault<Employee>(query , new { id=id1}) ;

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
