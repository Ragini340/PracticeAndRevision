using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Examples.Bank_Interest_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Bank bank;

            bank = new SBI();
            Console.WriteLine("SBI Interest : " + bank.GetInterestRate() + "%");

            bank = new HDFC();
            Console.WriteLine("HDFC Interest : " + bank.GetInterestRate() + "%");

            bank = new ICICI();
            Console.WriteLine("ICICI Interest : " + bank.GetInterestRate() + "%");
        }
    }
}