using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeAndRevision.Serialization.RealTime_Serialization_Example
{
    public class EmployeeService
    {
        public void SaveEmployee()
        {
            Employee employee = new Employee
            {
                Id = 101,
                Name = "Ragini",
                Department = "IT"
            };

            string json = JsonSerializer.Serialize(employee,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText("Employee.json", json);

            Console.WriteLine("Employee information saved successfully.");
        }

        public static void Main(string[] args)
        {
            EmployeeService service = new EmployeeService();

            service.SaveEmployee();
        }
    }
}