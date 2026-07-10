using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Move_a_File
{
    public class FileManager
    {
        public void MoveFile()
        {
            string source = "Sample_Copy.txt";
            string destination = "Moved_Sample.txt";

            if (File.Exists(destination))
            {
                File.Delete(destination);
            }

            File.Move(source, destination);

            Console.WriteLine("File Moved Successfully.");
        }

        public static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.MoveFile();
        }
    }
}