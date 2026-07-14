using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeAndRevision.Serialization.JSON_Serialization
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

            string json = JsonSerializer.Serialize(employee);

            Console.WriteLine(json);
        }

        public static void Main(string[] args)
        {
            SerializationDemo demo = new SerializationDemo();
            demo.Execute();
        }
    }
}