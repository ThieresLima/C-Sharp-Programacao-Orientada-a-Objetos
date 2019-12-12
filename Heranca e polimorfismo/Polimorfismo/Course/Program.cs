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
            /*Em Programação Orientada a Objetos, polimorfismo é recurso que permite
                que variáveis de um mesmo tipo mais genérico possam apontar para objetos
                de tipos específicos diferentes, tendo assim comportamentos diferentes
                conforme cada tipo específico.*/

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
