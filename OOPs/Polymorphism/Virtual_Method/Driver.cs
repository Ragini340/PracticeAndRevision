using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Virtual_Method
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.DisplayRole();
        }
    }
}