using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            float senha;

            Console.WriteLine("Digite a senha:");
            senha = float.Parse(Console.ReadLine());

            if(senha == 1234)
            {
                Console.WriteLine("Acesso Permitido.");
            }
            else
            {
                Console.WriteLine("Acesso Negado.");
            }
        }
    }
}
