using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Interface_Inheritance
{
    public class Dog : IDog
    {
        public void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }

        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
}