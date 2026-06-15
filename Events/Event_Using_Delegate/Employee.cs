using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Event_Using_Delegate
{
    public delegate void EmployeeHandler(string name);

    public class Employee
    {
        public event EmployeeHandler EmployeeCreated;

        public void CreateEmployee(string name)
        {
            EmployeeCreated?.Invoke(name);
        }
    }
}