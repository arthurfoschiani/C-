using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            double maca;

            System.Console.WriteLine("Quantas maças você deseja comprar?");
            int quant = int.Parse(Console.ReadLine());
            if (quant < 12)
            {
                maca = 0.30;
            }
            else
            {
                maca = 0.25;
            }
                double total = quant * maca;

                System.Console.WriteLine($"O preço total de maças é: {total}");
        }
    }
}