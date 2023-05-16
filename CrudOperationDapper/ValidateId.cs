using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace CrudOperationDapper
{
    static class Validate
    {
        public static string GetsConnectionString()
        {
              return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        }
        
    }
}
