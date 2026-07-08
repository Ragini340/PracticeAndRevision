using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.Async_File_Processing_Example
{
    public class FileService
    {
        public async Task ReadFileAsync()
        {
            string path = "Sample.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Welcome to Async File Processing");
            }

            string content = await File.ReadAllTextAsync(path);

            Console.WriteLine(content);
        }

        public static void Main(string[] args)
        {
            FileService service = new FileService();

            service.ReadFileAsync().Wait();
        }
    }
}