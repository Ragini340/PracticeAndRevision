using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Singleton_Lifetime
{
    class SingletonService
    {
        private static readonly SingletonService instance = new SingletonService();

        public Guid Id { get; } = Guid.NewGuid();

        private SingletonService()
        {
        }

        public static SingletonService Instance
        {
            get { return instance; }
        }
    }
}