using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Create_Directory
{
    public class DirectoryManager
    {
        public void CreateDirectory()
        {
            string path = "MyFolder";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

                Console.WriteLine("Directory Created Successfully.");
            }
            else
            {
                Console.WriteLine("Directory Already Exists.");
            }
        }

        public static void Main(string[] args)
        {
            DirectoryManager manager = new DirectoryManager();
            manager.CreateDirectory();
        }
    }
}