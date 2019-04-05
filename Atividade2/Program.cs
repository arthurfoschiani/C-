using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            float presente;
            float nascimento;
            float idade;

            Console.WriteLine("Insira o ano em que estamos:");
            presente = float.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Insira o ano de seu nascimento:");
            nascimento = float.Parse(Console.ReadLine().ToLower());

            idade = presente - nascimento;

            if(idade < 16)
            {
                Console.WriteLine("Me desculpe, mas você ainda não pode votar.");
            }
            else
            {
                Console.WriteLine("Esse ano é permitido por lei votar, parabéns!");
            }
    
        }
    }
}
