using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.Append_Text_to_File
{
    public class FileManager
    {
        public void AppendFile()
        {
            string path = "Sample.txt";

            File.AppendAllText(path, Environment.NewLine + "This is appended text.");

            Console.WriteLine("Text Appended Successfully.");
        }

        public static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.AppendFile();
        }
    }
}