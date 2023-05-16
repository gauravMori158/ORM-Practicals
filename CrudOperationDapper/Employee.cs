using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationDapper
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int EmpCode { get; set; }
        public int Gender { get; set; }
        public System.DateTime DoB { get; set; }
        public Nullable<int> Salary { get; set; }
        public System.DateTime JoiningDate { get; set; }
        public Nullable<System.DateTime> ResignDate { get; set; }
    }
}
