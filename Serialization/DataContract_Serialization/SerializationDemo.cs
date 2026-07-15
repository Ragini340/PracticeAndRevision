using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Serialization.DataContract_Serialization
{
    class SerializationDemo
    {
        public void Execute()
        {
            Employee employee = new Employee
            {
                Id = 101,
                Name = "Ragini"
            };

            DataContractSerializer serializer = new DataContractSerializer(typeof(Employee));

            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, employee);

                stream.Position = 0;

                Console.WriteLine(new StreamReader(stream).ReadToEnd());
            }
        }

        public static void Main(string[] args)
        {
            SerializationDemo demo = new SerializationDemo();
            demo.Execute();
        }
    }
}