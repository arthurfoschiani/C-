using System;

namespace Ex10for
{
    class Program
    {
        static void Main(string[] args)
        {
            int piramides = 0;
            int num = 0;
            int i;
            int j;

            Console.WriteLine("Quantos pontos você deseja ter na base da piramide?");
            piramides = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas piramides você deseja ter?");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= piramides; i++)
            {
                string a = "";
                for (j = 1; j <= num; j++)
                {
                    a += "*";
                    Console.WriteLine(a);
                }
            }
        }
    }
}
