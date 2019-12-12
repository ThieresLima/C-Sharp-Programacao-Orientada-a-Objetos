using System;

namespace TimeSpanOperacoes {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("----------------");

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11); // dias, horas, minutos, segundos, milissegundos

            Console.WriteLine(t);
            Console.WriteLine(t.Hours);
            Console.WriteLine(t.Minutes);
            Console.WriteLine(t.Milliseconds);
            Console.WriteLine(t.Seconds);
            Console.WriteLine(t.Ticks);

            Console.WriteLine("--------------");

            Console.WriteLine(t.TotalDays);
            Console.WriteLine(t.TotalHours);
            Console.WriteLine(t.TotalMinutes);
            Console.WriteLine(t.TotalSeconds);
            Console.WriteLine(t.TotalMilliseconds);

            Console.WriteLine("--------------");

            TimeSpan tx = new TimeSpan(1, 30, 10);
            TimeSpan ty = new TimeSpan(0, 10, 5);

            TimeSpan sum = tx.Add(ty);
            TimeSpan dif = tx.Subtract(ty);
            TimeSpan mult = ty.Multiply(2.0);
            TimeSpan div = ty.Divide(2.0);

            Console.WriteLine(tx);
            Console.WriteLine(ty);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
