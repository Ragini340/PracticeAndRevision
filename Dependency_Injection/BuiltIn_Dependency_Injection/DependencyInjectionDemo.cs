using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.BuiltIn_Dependency_Injection
{
    class DependencyInjectionDemo
    {
        public void Execute()
        {
            ILogger logger = new ConsoleLogger();

            EmployeeService service = new EmployeeService(logger);

            service.Save();
        }
    }
}