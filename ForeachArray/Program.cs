using System;

namespace ForeachArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numCasas = new int [5];
            for (int i = 0; i < numCasas.Length; i++)
            {
                Console.WriteLine("Coloque o numero da casa {0}:", i+1);
                numCasas[i] = int.Parse(Console.ReadLine());
            }
            foreach (var num in numCasas)
            {
                System.Console.WriteLine($"{num}");
            }
        }
    }
}
