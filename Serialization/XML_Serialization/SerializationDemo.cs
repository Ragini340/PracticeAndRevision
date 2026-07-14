using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PracticeAndRevision.Serialization.XML_Serialization
{
    public class SerializationDemo
    {
        public void Execute()
        {
            Employee employee = new Employee
            {
                Id = 101,
                Name = "Ragini"
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, employee);

                Console.WriteLine(writer.ToString());
            }
        }

        public static void Main(string[] args)
        {
            SerializationDemo demo = new SerializationDemo();
            demo.Execute();
        }
    }
}