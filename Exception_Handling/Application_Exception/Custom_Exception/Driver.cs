using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.Application_Exception.Custom_Exception
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            AgeValidator validator = new AgeValidator();

            try
            {
                validator.ValidateAge(15);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}