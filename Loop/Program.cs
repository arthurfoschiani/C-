using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] suspeitos = {"Cesar", "Tsukamoto", "Rusbé", "Culpado", "Bona", "Zé Mané", "Fulano"};

            for (int i = 0; i < suspeitos.Length; i++)
            {
                System.Console.WriteLine("Você é o " + suspeitos[i]);
                if (suspeitos[i].Equals("Culpado"))
                {
                    System.Console.WriteLine("TEJE PRESO");
                    break;
                }
            }
        }
    }
}
