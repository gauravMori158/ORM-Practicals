
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationDapper
{
    internal static class UpdateEmployee
    {

        public static void UpdateEmployees(int id1)
        {
            try {
                using (var connection = new SqlConnection(Validate.GetsConnectionString()))
                {
                    string query = "Update Employee Set  FirstName = @firstName, MiddleName = @middleName , " +
                                    "LastName = @lastName, Salary = @salary Where EmployeeId = @id";

                    var param = new {firstName= "Gaurav",middleName = "K", lastName = "Mori" , salary = 90000 ,id =id1 };

                    int UpdatedRow = connection.Execute(query, param);

                     if(UpdatedRow > 0)
                    {
                        Console.WriteLine("\n\n Use Updated !!\n\n");
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


 