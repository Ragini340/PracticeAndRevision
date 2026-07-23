using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.BuiltIn_Dependency_Injection
{
    class EmployeeService
    {
        private readonly ILogger logger;

        public EmployeeService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Save()
        {
            logger.Log("Employee Saved");
        }
    }
}