using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Inheritance.Hierarchical_Inheritance
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.DisplayPerson();
            employee.DisplayEmployee();

            Console.WriteLine();

            Student student = new Student();
            student.DisplayPerson();
            student.DisplayStudent();
        }
    }
}