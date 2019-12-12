using System;

namespace DateTimeOperacoes {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine(d.Date);
            Console.WriteLine(d.Day);
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine(d.DayOfYear);
            Console.WriteLine(d.Hour);
            Console.WriteLine(d.Kind);
            Console.WriteLine(d.Millisecond);
            Console.WriteLine(d.Month);
            Console.WriteLine(d.Second);
            Console.WriteLine(d.Ticks);
            Console.WriteLine(d.TimeOfDay);
            Console.WriteLine(d.Year);

            Console.WriteLine("--------------------");

            DateTime dt = new DateTime(2001, 8, 15, 13, 45, 58);

            // DateTime para string;
            string s1 = dt.ToLongDateString();
            string s2 = dt.ToLongTimeString();
            string s3 = dt.ToShortDateString();
            string s4 = dt.ToShortTimeString();
            string s5 = dt.ToString();
            string s6 = dt.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = dt.ToString("yyyy=MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            /*
            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);
            */
        }
    }
}
