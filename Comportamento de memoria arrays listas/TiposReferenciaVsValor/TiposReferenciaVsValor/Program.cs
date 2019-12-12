using System;

namespace TiposReferenciaVsValor {
    class Program {
        static void Main(string[] args) {

            /* Classes são tipos referência 
             
          Product p1, p2;
          p1 = new Product("TV", 900.00, 0);
          p2 = p1;
          p2 = p1;
          "p2 passa a apontar para onde p1 aponta"
                    
           Valor "null"
           Tipos referência aceitam o valor "null",
           que indica que a variável aponta pra ninguém

            Product p1, p2;
            p1 = new Product("TV", 900.00, 0);
            p2 = null;

            Structs são tipos valor
            A linguagem C# possui também tipos valor,
            que são os "structs". Structs são CAIXAS e não ponteiros.

            double x, y;
            x = 10;
            y = x;
            y = x;
            "y recebe uma CÓPIA de x"
                
             */

            Point p;
            // Console.WriteLine(p); // erro: variável não atribuída

            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p); // 0,0

        }
    }
}
