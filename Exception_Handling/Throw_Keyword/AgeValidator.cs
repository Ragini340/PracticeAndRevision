using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.Throw_Keyword
{
    public class AgeValidator
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Age Must Be 18 Or Above");
            }

            Console.WriteLine("Eligible");
        }

        public static void Main(string[] args)
        {
            AgeValidator validator = new AgeValidator();

            try
            {
                validator.ValidateAge(15);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}