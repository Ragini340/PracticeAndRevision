using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Prototype_Pattern
{
    class PrototypeDemo
    {
        public void Execute()
        {
            Employee employee1 = new Employee();
            employee1.Name = "Ragini";

            Employee employee2 = (Employee)employee1.Clone();

            Console.WriteLine(employee2.Name);
        }

        public static void Main(string[] args)
        {
            PrototypeDemo demo = new PrototypeDemo();
            demo.Execute();
        }
    }
}