using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Singleton_Lifetime
{
    class SingletonDemo
    {
        public void Execute()
        {
            Console.WriteLine(SingletonService.Instance.Id);
            Console.WriteLine(SingletonService.Instance.Id);
        }
    }
}