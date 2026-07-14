using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeAndRevision.Serialization.Serialize_List_of_Objects
{
    public class SerializationDemo
    {
        public void Execute()
        {
            List<Employee> employees =
                new List<Employee>
                {
                    new Employee{ Id = 101, Name = "Ragini" },
                    new Employee{ Id = 102, Name = "Test" }
                };

            string json = JsonSerializer.Serialize(employees);

            Console.WriteLine(json);
        }

        public static void Main(string[] args)
        {
            SerializationDemo demo = new SerializationDemo();
            demo.Execute();
        }
    }
}