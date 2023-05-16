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
    internal static class InsertEmployee
    {

        public static void InsertEmployees()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Validate.GetsConnectionString()))
                {
                    connection.Open();
                    SqlCommand InsertCommand = new SqlCommand("sp_InsertUser", connection);
                    InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    InsertCommand.Parameters.AddWithValue("@firstName", "Jay");
                    InsertCommand.Parameters.AddWithValue("@middleName", "A");
                    InsertCommand.Parameters.AddWithValue("@lastName", "Prajapati");
                    InsertCommand.Parameters.AddWithValue("@empCode", 2);
                    InsertCommand.Parameters.AddWithValue("@gender", 1);
                    InsertCommand.Parameters.AddWithValue("@doB", "2002-01-15");
                    InsertCommand.Parameters.AddWithValue("@salary", 80000);
                    InsertCommand.Parameters.AddWithValue("@joiningDate", "2023-01-03");
                    InsertCommand.Parameters.AddWithValue("@resignDate", "");

                    int NumberOfRow = InsertCommand.ExecuteNonQuery();

                    Console.WriteLine($"Number Of Row Affected : {NumberOfRow}");
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine($"Error  :  {Ex.Message}");
            }
        }
    }
}


//Create Procedure sp_InsertUser (
//@firstName Varchar(50),
//@middleName Varchar(50),
//@lastName Varchar(50)  ,
//@empCode INT,
//@gender INT    ,
//@doB Date  ,
//@salary int ,
//@joiningDate Date  ,
//@resignDate Date
//)
//as
//Begin
//Insert Into Employee (FirstName, MiddleName, LastName, EmpCode, Gender, DoB, Salary, JoiningDate, ResignDate) Values
//(@firstName, @middleName, @lastName, @empCode, @gender, @dob, @salary, @joiningDate, @resignDate);

//end