using System;

namespace Ex2Media
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float nota3;
            int falta;
            float somanotas;
            double media;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de faltas:");
            falta = int.Parse(Console.ReadLine());

            somanotas = nota1 + nota2 + nota3;
            media = somanotas / 3;

            if (media < 6 || falta > 25)
            {
                Console.WriteLine("Aluno Reprovado");
            }
            else if(media < 9)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Isso aí, Jovem!");
            }
        }
    }
}
