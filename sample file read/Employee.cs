using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_file_read
{
    class Employee
    {
        private string name;
        private static int count;

        public Employee()
        {

        }

        public Employee(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public static void SetCount(int temp)
        {
            count = temp;
        }

        public static int GetCount()
        {
            return count;
        }


    }
}
