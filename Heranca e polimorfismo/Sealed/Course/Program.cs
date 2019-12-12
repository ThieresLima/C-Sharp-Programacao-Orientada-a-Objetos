using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1081, "João", 500.0);
            Account acc2 = new SavingsAccount(1230, "Maria", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            // evita que a classe seja herdada

            // evita que um método sobreposto possa ser sobreposto novamente // Só pode ser aplicado a métodos sobrepostos
        }
    }
}
