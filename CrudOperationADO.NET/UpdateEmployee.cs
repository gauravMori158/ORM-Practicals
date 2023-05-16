using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationADO.NET
{
    internal static class UpdateEmployee
    {

        public static void UpdateEmployees(int id)
        {
            try {
                using (SqlConnection connection = new SqlConnection(Validate.GetsConnectionString()))
                {

                    if (Validate.ValidateIds(id))
                    {
                        connection.Open();

                        SqlCommand UpdateCommand = new SqlCommand("sp_UpdateUser", connection);

                        UpdateCommand.Parameters.AddWithValue("@id", id);

                        UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;

                        UpdateCommand.Parameters.AddWithValue("@firstName", "Jay1");
                        UpdateCommand.Parameters.AddWithValue("@middleName", "A1");
                        UpdateCommand.Parameters.AddWithValue("@lastName", "Prajapati1");
                        UpdateCommand.Parameters.AddWithValue("@empCode", 211);
                        UpdateCommand.Parameters.AddWithValue("@salary", 80000);
                        UpdateCommand.Parameters.AddWithValue("@resignDate", "2029-02-12");

                        int NumberOfRow = UpdateCommand.ExecuteNonQuery();

                        Console.WriteLine($"Number Of Row Affected : {NumberOfRow}");
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


//Alter Procedure sp_UpdateUser (
//@id int,
//@firstName Varchar(50),
//@middleName Varchar(50),
//@lastName Varchar(50)  ,
//@empCode INT,
//@salary int ,
//@resignDate Date
//)
//as
//Begin
// Update Employee Set
// FirstName =@firstName, MiddleName = @middleName, LastName = @lastName, EmpCode = @empCode, Salary = @salary, ResignDate = @resignDate
// Where EmployeeId =@id
// end
