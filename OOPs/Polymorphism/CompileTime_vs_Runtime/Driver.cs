using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.CompileTime_vs_Runtime
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Compile-Time Polymorphism");
            Console.WriteLine(calculator.Add(10, 20));
            Console.WriteLine(calculator.Add(10, 20, 30));

            Console.WriteLine();

            Console.WriteLine("Runtime Polymorphism");

            Animal animal = new Cat();
            animal.Sound();
        }
    }
}