using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.Application_Exception.Custom_Exception
{
    public class AgeValidator
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age Must Be 18 Or Above");
            }

            Console.WriteLine("Eligible");
        }
    }
}