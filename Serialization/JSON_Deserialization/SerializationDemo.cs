using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeAndRevision.Serialization.JSON_Deserialization
{
    public class SerializationDemo
    {
        public void Execute()
        {
            string json = "{\"Id\":101,\"Name\":\"Ragini\"}";

            Employee employee = JsonSerializer.Deserialize<Employee>(json);

            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
        }

        public static void Main(string[] args)
        {
            SerializationDemo demo = new SerializationDemo();
            demo.Execute();
        }
    }
}