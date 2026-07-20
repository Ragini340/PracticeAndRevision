using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.SOLID_Refactored_Example
{
    class RefactoredDemo
    {
        public void Execute()
        {
            EmployeeRepository repository = new EmployeeRepository();
            EmployeePrinter printer = new EmployeePrinter();
            EmailService email = new EmailService();

            repository.Save();
            printer.Print();
            email.Send();
        }
    }
}