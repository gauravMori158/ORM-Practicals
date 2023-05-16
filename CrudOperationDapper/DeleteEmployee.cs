using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace CrudOperationDapper
{
    internal static class DeleteEmployee
    {

        public static void DeleteEmployees(int id1)
        {
            try
            {
                using (var connection = new SqlConnection(Validate.GetsConnectionString()))
                {
                    string query = "Delete from Employee Where EmployeeId = @id";
                    int DeletedRows = connection.Execute(query, new { id = id1 });
                    if(DeletedRows >0)
                        Console.WriteLine("\n User Deleted !!\n");
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

 
