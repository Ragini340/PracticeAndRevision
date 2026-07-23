using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Transient_Lifetime
{
    class LifetimeDemo
    {
        public void Execute()
        {
            Service service1 = new Service();
            Service service2 = new Service();

            Console.WriteLine(service1.Id);
            Console.WriteLine(service2.Id);
        }
    }
}