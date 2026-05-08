using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Examples.Bank_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            SBI bank = new SBI();

            Console.WriteLine("Interest Rate = " + bank.GetInterestRate() + "%");
        }
    }
}