using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CrudOperationADO.NET
{
    internal static class DeleteEmployee
    {

        public static void DeleteEmployees(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Validate.GetsConnectionString()))
                {
                    if (Validate.ValidateIds(id))
                    {
                        connection.Open();
                        SqlCommand DeleteCommand = new SqlCommand("sp_DeleteUser", connection);
                        DeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;

                        DeleteCommand.Parameters.AddWithValue("@id", id);

                        int NumberOfRow = DeleteCommand.ExecuteNonQuery();

                        Console.WriteLine($"Number Of Row Affected : {NumberOfRow}");
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


//Create Procedure sp_DeleteUser (
// @id int
//)
//as
//Begin
// Delete from Employee where  EmployeeId =@id
// end
