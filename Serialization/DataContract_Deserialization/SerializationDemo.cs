using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Serialization.DataContract_Deserialization
{
    public class SerializationDemo
    {
        public void Execute()
        {
            string xml = @"<Employee xmlns:i=""http://www.w3.org/2001/XMLSchema-instance""
                         xmlns=""http://schemas.datacontract.org/2004/07/PracticeAndRevision.Serialization.DataContract_Deserialization"">
                         <Id>101</Id>
                         <Name>John</Name>
                         </Employee>";

            DataContractSerializer serializer = new DataContractSerializer(typeof(Employee));

            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                Employee employee = (Employee)serializer.ReadObject(stream);

                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.Name);
            }
        }

        public static void Main(string[] args)
        {
            SerializationDemo demo = new SerializationDemo();
            demo.Execute();
        }
    }
}