using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\PerfLogs\file1.txt"; // origem
            string targetPath = @"c:\PerfLogs\file2.txt"; // destino

            try
            {
                File.Copy(sourcePath, targetPath); // origem & destino

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
