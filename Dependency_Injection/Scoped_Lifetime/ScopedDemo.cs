using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Scoped_Lifetime
{
    class ScopedDemo
    {
        public void Execute()
        {
            Scope scope1 = new Scope();
            Scope scope2 = new Scope();

            Console.WriteLine(scope1.Service.Id);
            Console.WriteLine(scope2.Service.Id);
        }
    }
}