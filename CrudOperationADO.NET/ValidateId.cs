using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationADO.NET
{
    static class Validate
    {
        public static string GetsConnectionString()
        {
              return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        }
        public static bool ValidateIds(int id)
        {
            using( SqlConnection connection = new SqlConnection(GetsConnectionString()))
            {

                connection.Open();

                string query = "Select EmployeeId from Employee Where EmployeeId =@id";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);

                var Result = cmd.ExecuteScalar();

                if (Result == null)
                {
                    
                    return false;

                }
            }

            return true;
        }
    }
}
