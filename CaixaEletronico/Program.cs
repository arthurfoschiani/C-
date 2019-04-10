using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
            int valor;
            int quantia = 0;

            Console.WriteLine("Insira o valor que você deseja sacar");
            quantia = int.Parse(Console.ReadLine());
            DateTime data = DateTime.Now;

            for (int i = 0; i < notas.Length; i++)
            {
                valor = quantia / notas[i];
                quantia = quantia % notas[i];
                if (valor != 0)
                {
                    System.Console.WriteLine($"Você recebeu {valor} nota(s) de {notas[i]} em {data}");
                }
            }
        }
    }
}