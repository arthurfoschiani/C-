using System;

namespace GeradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escreve uma palavra aí, meu consagrado!");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 5;

            string[] palavrasUsuario = new string[maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0; i++)
            {
                palavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)
                {
                    System.Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma!");
                }
                else
                {
                    System.Console.WriteLine("Valeu, Jovem! Agora deixa comigo!");
                }
            }
            string[,] matrizPalavras = { { "eu", "ele", "ela", "nós", "" },
                                         { "fui", "foi", "estavamos", "estava", "" },
                                         { "viajar", "tomar", "andar", "mexer", "" },
                                         { "para", "banho", "eperando", "no seu", "" },
                                         { "praia", "escondido", "a chuva", "filho", "" } };
            for (int i = 0; i < matrizPalavras.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPalavras.GetLength(0); j++)
                {
                    if ("".Equals(matrizPalavras[i, j]))
                    {
                        matrizPalavras[i, j] = palavrasUsuario[i];
                    }
                }
            }

            string frase = "";

            Random r = new Random();
            for (int i = 0; i < maxPalavrasFrase; i++)
            {
                frase += matrizPalavras[i, r.Next(matrizPalavras.GetLength(0))]
                    + " ";
            }
            System.Console.WriteLine("Sua frase é: \n" + frase);
        }
    }
}