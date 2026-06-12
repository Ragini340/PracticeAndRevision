using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.System_Exception.NullReferenceExceptions
{
    public class ExceptionDemo
    {
        public void Execute()
        {
            try
            {
                Student student = null;

                Console.WriteLine(student.Name);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Object Reference Not Set");
                Console.WriteLine(ex.Message);
            }
        }
    }
}