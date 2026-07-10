using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Read_Directory_Files
{
    public class DirectoryManager
    {
        public void ReadDirectory()
        {
            string path = ".";

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        public static void Main(string[] args)
        {
            DirectoryManager manager = new DirectoryManager();
            manager.ReadDirectory();
        }
    }
}