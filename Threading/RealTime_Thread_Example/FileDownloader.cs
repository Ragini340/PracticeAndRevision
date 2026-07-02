using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.RealTime_Thread_Example
{
    public class FileDownloader
    {
        public void Download()
        {
            Console.WriteLine("Downloading Started...");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Downloading " + (i * 20) + "%");

                Thread.Sleep(1000);
            }

            Console.WriteLine("Download Completed");
        }

        public static void Main(string[] args)
        {
            FileDownloader downloader = new FileDownloader();

            Thread thread = new Thread(downloader.Download);

            thread.Start();

            Console.WriteLine("Main Thread is Free for Other Work...");
        }
    }
}