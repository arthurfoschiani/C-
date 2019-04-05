using System;

namespace Ex8for
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int idade;
            int maiores = 0;

            for(i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite a idade da pessoa {0}", i);
                idade = int.Parse(Console.ReadLine());
                if(idade >= 18)
                {
                    maiores += 1;
                }
                Console.WriteLine("O numero de maiores de idaade é {0}", maiores);
            }
        }
    }
}
