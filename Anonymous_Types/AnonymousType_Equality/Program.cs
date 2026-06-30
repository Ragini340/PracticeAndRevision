using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Anonymous_Types.AnonymousType_Equality
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employee1 = new
            {
                Id = 101,
                Name = "Ragini"
            };

            var employee2 = new
            {
                Id = 101,
                Name = "John"
            };

            Console.WriteLine(employee1.Equals(employee2));
        }
    }
}