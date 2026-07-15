using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Serialization.Serialize_Object_to_File
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

            string json = System.Text.Json.JsonSerializer.Serialize(employee);

            File.WriteAllText("Employee.json", json);

            Console.WriteLine("Employee.json Created");
        }

        public static void Main(string[] args)
        {
            SerializationDemo demo = new SerializationDemo();
            demo.Execute();
        }
    }
}