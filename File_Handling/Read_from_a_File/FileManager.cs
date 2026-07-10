using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Read_from_a_File
{
    public class FileManager
    {
        public void ReadFile()
        {
            string path = "Sample.txt";

            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);

                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File Not Found.");
            }
        }

        public static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.ReadFile();
        }
    }
}