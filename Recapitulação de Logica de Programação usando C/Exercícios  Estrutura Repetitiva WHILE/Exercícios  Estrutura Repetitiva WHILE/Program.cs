﻿using System;
using System.Globalization;

namespace Exercícios__Estrutura_Repetitiva_WHILE {
    class Program {
        static void Main(string[] args) {
            /*  Console.Write("Insira a senha: ");

              int senha = int.Parse(Console.ReadLine());

              while (senha != 2002) {
                  Console.WriteLine("Senha invalida");

                  Console.Write("Insira a senha novamente: ");
                  senha = int.Parse(Console.ReadLine());
              }
              Console.WriteLine("Acesso Permitido");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1) {
                    alcool = alcool + 1;
                }
                else if (tipo == 2) {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3) {
                    diesel = diesel + 1;
                }
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("gasolina: " + gasolina);
            Console.WriteLine("diesel: " + diesel);*/

            string[] valores = Console.ReadLine().Split(" ");
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(" ");
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }



    }
    }
