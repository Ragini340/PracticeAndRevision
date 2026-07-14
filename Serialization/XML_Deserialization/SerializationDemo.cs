using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PracticeAndRevision.Serialization.XML_Deserialization
{
    public class SerializationDemo
    {
        public void Execute()
        {
            string xml = @"<?xml version=""1.0""?>
                         <Employee>
                         <Id>101</Id>
                         <Name>Ragini</Name>
                         </Employee>";

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));

            using (StringReader reader = new StringReader(xml))
            {
                Employee employee = (Employee)serializer.Deserialize(reader);

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