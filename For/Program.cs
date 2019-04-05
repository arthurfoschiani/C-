using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string pontos = "";
            int i;
            int quantidade;

            Console.WriteLine("Escolha a quantidade de pontos que você deseja ter na base do triangulo.");
            quantidade = int.Parse(Console.ReadLine());

            for (i = 0; i < quantidade; i++)
            {
                pontos += "*";
                Console.WriteLine(pontos);
            }
        }
    }
}
