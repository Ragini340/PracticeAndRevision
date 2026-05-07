using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Override_Keyword
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Employee employee = new Manager();

            employee.DisplayRole();
        }
    }
}