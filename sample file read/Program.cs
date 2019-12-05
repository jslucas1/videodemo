using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_file_read
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] myEmployees = EmployeeFile.GetAllEmployees();

            myEmployees[0].SetName("Jeff");

            EmployeeFile.SaveAllEmployees(myEmployees);
        }
    }
}
