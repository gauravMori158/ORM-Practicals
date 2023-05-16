 
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CrudOperationDapper
{
    internal static class InsertEmployee
    {

        public static void InsertEmployees()
        {
            try
            {
                using (var connection = new SqlConnection(Validate.GetsConnectionString()))
                {


                    string query = "Insert Into Employee (FirstName,MiddleName,LastName,EmpCode,Gender,DoB,Salary,JoiningDate ) Values" +
                        "(@firstName,@middleName,@lastName,@empCode,@gender,@dob,@salary,@joiningDate )";
                   
                    var param = new { firstName = "Jenish", middleName= "K", lastName="Raiyani",
                                      empCode=99, gender=1, dob="2023-02-01", salary=80008, joiningDate= "2023-02-01"
                                    };

                    int InsertedRow = connection.Execute(query, param);

                    if(InsertedRow> 0 ) 
                    Console.WriteLine("\nUser Added !!\n");

                    else
                        Console.WriteLine("\n Invalid id \n");

                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine($"Error  :  {Ex.Message}");
            }
        }
    }
}


 