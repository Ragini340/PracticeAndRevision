using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Copy_File
{
    public class FileManager
    {
        public void CopyFile()
        {
            string source = "Sample.txt";
            string destination = "Sample_Copy.txt";

            File.Copy(source, destination, true);

            Console.WriteLine("File Copied Successfully.");
        }

        public static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.CopyFile();
        }
    }
}