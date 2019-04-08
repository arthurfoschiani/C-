using System;

namespace ArrayExCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numcasa = new int [3];

            for(int i = 0; i < numcasa.Length; i++)
            {
                Console.WriteLine("Coloque o numero da casa {0}:", i+1);
                numcasa [i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Os numeros são:\n{0}, {1} e {2}", numcasa [0], numcasa [1], numcasa [2]);
        }
    }
}
