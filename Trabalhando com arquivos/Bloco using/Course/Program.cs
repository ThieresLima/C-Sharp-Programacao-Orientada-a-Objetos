using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bloco using : garante que os objetos IDisposable serão fechados (n precisa do finally)
            //Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser manualmente fechados.
            // Exemplos: Font, FileStream, StreamReader, StreamWriter

            string path = @"c:\PerfLogs\file1.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
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
