using System;

namespace Ex6dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool JaAcordei = false;
            string resposta;

            do
            {
                Console.WriteLine("Pai, você ja acordou?");
                resposta = Console.ReadLine().ToLower();

                JaAcordei = resposta.Contains("sim") ? true : false;
            } while (!JaAcordei);
        }
    }
}