using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Create_File
{
    public class FileManager
    {
        public void CreateFile()
        {
            string path = "Sample.txt";

            if (!File.Exists(path))
            {
                File.Create(path).Close();
                Console.WriteLine("File Created Successfully.");
            }
            else
            {
                Console.WriteLine("File Already Exists.");
            }
        }

        public static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.CreateFile();
        }
    }
}