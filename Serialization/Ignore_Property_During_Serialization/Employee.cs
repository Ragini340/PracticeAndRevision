using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticeAndRevision.Serialization.Ignore_Property_During_Serialization
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}