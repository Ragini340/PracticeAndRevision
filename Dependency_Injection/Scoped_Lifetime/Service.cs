using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Scoped_Lifetime
{
    class Service
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}