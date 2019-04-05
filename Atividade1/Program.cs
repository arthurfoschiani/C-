using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor1;
            float valor2;

            Console.WriteLine("Insira o primeiro valor.");
            valor1 = float.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Insira o segundo valor.");
            valor2 = float.Parse(Console.ReadLine().ToLower());

            if(valor1 > valor2)
            {
                Console.WriteLine("o maior valor é " + valor1);
            }
            else
            {
                Console.WriteLine("o maior valor é " + valor2);
            }
        }
    }
}
