using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Parameterized_Constructor
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary;

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"Id : {id}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Salary : {salary}");
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee(1001, "John", 50000);
            employee.Display();
        }
    }
}