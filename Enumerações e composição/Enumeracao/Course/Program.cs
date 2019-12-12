using System;
using Course.Entities;
using Course.Entities.Enum;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order { 
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPaygment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPaygment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
