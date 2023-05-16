using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace CrudOperationADO.NET
{
    static class EmployeeInfo
    {
        public static void GetEmployee()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Validate.GetsConnectionString()))
                {
                    string query = "Select * from Employee";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    connection.Open();

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();


                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine($"Name : {sqlDataReader["FirstName"]}  {sqlDataReader["MiddleName"]} {sqlDataReader["LastName"]} " +
                            $"\nId : {sqlDataReader["EmployeeId"]} Employee Code : {sqlDataReader["EmpCode"]} " +
                            $"\nGender : {sqlDataReader["Gender"]}  DoB : {sqlDataReader["DoB"]}\n" +
                            $"Salary : {sqlDataReader["Salary"]}  \nJoining Date : {sqlDataReader["Joiningdate"]} \n" +
                            $"Resign Date : {sqlDataReader["ResignDate"]}");
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
                using (SqlConnection connection = new SqlConnection(Validate.GetsConnectionString()))
                {
                    if (Validate.ValidateIds(id))
                    {
                        string query = "Select * from Employee Where EmployeeId= @id";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@id", id);
                        connection.Open();

                        SqlDataReader sqlDataReader = cmd.ExecuteReader();


                        while (sqlDataReader.Read())
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine($"Name : {sqlDataReader["FirstName"]}  {sqlDataReader["MiddleName"]} {sqlDataReader["LastName"]} " +
                                $"\nId : {sqlDataReader["EmployeeId"]} Employee Code : {sqlDataReader["EmpCode"]} " +
                                $"\nGender : {sqlDataReader["Gender"]}  DoB : {sqlDataReader["DoB"]}\n" +
                                $"Salary : {sqlDataReader["Salary"]}  \nJoining Date : {sqlDataReader["Joiningdate"]} \n" +
                                $"Resign Date : {sqlDataReader["ResignDate"]}");
                            Console.WriteLine("\n\n");
                        }
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
