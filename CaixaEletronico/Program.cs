using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = {1, 5, 10, 20, 50, 100};
            int a;
            int x = 0;
            int y = 0;
            int z = 0;
            int r = 0;
            int t = 0;
            int p = 0;

            Console.WriteLine("Insira o valor que você deseja sacar");
            a = int.Parse(Console.ReadLine());

            x = a / 100;
            int b = a - 100 * x;
            Console.WriteLine("Você receberá {0} notas de R$100,00", x);
            y = b / 50;
            int c = b - 50 * y;
            Console.WriteLine("Você receberá {0} notas de R$50,00", y);
            z = c / 20;
            int d = c - 20 * z;
            Console.WriteLine("Você receberá {0} notas de R$20,00", z);
            r = d / 10;
            int e = d - 10 * r;
            Console.WriteLine("Você receberá {0} notas de R$10,00", r);
            t = e / 5;
            int f = e - 5 * t;
            Console.WriteLine("Voce receberá {0} notas de R$5,00", t);
            p = f / 1;
            int g = f - 5 * p;
            Console.WriteLine("Você receberá {0} moedas de R$1,00", p);
        }
    }
}
