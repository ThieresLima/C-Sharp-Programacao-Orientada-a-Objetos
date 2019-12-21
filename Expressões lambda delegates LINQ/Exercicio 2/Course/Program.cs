using System;
using Course.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(",");
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        emp.Add(new Employee(name, email, salary));
                    }
                }

                var empEmail = emp.Where(e => e.Salary > valor).OrderBy(e => e.Email).Select(e => e.Email);
                Console.WriteLine("Email of people whose salary is more than " + valor.ToString("F2", CultureInfo.InvariantCulture));
                foreach (string email in empEmail)
                {
                    Console.WriteLine(email);
                }

                var nameM = emp.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + nameM.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
