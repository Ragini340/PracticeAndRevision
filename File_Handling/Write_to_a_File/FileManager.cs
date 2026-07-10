using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Write_to_a_File
{
    public class FileManager
    {
        public void WriteToFile()
        {
            string path = "Sample.txt";

            File.WriteAllText(path, "Welcome to C# File Handling.");

            Console.WriteLine("Content Written Successfully.");
        }

        public static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.WriteToFile();
        }
    }
}