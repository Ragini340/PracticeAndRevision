using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Anonymous_Types.Introduction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employee = new
            {
                Id = 101,
                Name = "John"
            };

            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
        }
    }
}