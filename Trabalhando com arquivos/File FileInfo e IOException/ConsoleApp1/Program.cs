using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\PerfLogs\file1.txt"; // caminho de origem
            string targetPath = @"c:\PerfLogs\file2.txt"; // caminho de destino

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // caminho de origem
                fileInfo.CopyTo(targetPath); // caminho de destino
            }
            catch (IOException e) // excessao
            {
                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}