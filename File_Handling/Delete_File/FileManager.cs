using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Delete_File
{
    public class FileManager
    {
        public void DeleteFile()
        {
            string path = "Moved_Sample.txt";

            if (File.Exists(path))
            {
                File.Delete(path);

                Console.WriteLine("File Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("File Not Found.");
            }
        }

        public static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.DeleteFile();
        }
    }
}