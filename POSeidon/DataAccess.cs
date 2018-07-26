using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace POSeidon
{
    class DataAccess
    {
        public Employee tempEmp = new Employee();
        public Customer tempCust = new Customer();
        public List<Employee> empList = new List<Employee>();
        public List<Customer> cusList = new List<Customer>();
    }
}
