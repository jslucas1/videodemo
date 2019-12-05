using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_file_read
{
    class EmployeeFile
    {
        public static Employee[] GetAllEmployees()
        {
            Employee[] myEmps = new Employee[50];

            StreamReader inFile = new StreamReader("input.txt");

            string line = inFile.ReadLine();
            while (line != null)
            {
                myEmps[Employee.GetCount()] = new Employee(line);
                Employee.SetCount(Employee.GetCount() + 1);

                line = inFile.ReadLine();
            }

            inFile.Close();

            return myEmps;

        }

        public static void SaveAllEmployees(Employee[] myEmps)
        {
            StreamWriter outFile = new StreamWriter("input.txt");

            for(int i =0; i< Employee.GetCount(); i++)
            {
                outFile.WriteLine(myEmps[i].GetName());
            }

            outFile.Close();
        }
    }
}
