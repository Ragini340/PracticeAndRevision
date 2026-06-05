using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.DataTypes
{
    public class CharacterDemo
    {
        public void Display()
        {
            char grade = 'A';

            Console.WriteLine("Grade = " + grade);
            Console.WriteLine("Size of Char = " + sizeof(char) + " Bytes");
        }

        public static void Main(string[] args)
        {
            CharacterDemo obj = new CharacterDemo();
            obj.Display();
        }
    }
}