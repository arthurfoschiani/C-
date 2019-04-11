using System;

namespace MediaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            string[] sobrenome = new string[10];
            double[] nota1 = new double[10];
            double[] nota2 = new double[10];
            double[] media = new double[10];
            string[] situacao = new string[10];

            System.Console.WriteLine("--------Relatório Escolar--------");

            for (int i = 0; i < nome.Length; i++)
            {
                System.Console.WriteLine($"Insira o nome do {i + 1}º aluno:");
                nome[i] = Console.ReadLine();

                System.Console.WriteLine($"Insira o sobrenome do {i + 1}º aluno");
                sobrenome[i] = Console.ReadLine();

                System.Console.WriteLine($"Insira a primeira nota do {i + 1}º aluno:");
                nota1[i] = double.Parse(Console.ReadLine());

                System.Console.WriteLine($"Insira a segunda nota do {i + 1}º aluno:");
                if(double.TryParse(Console.ReadLine(), out nota2[i])) {

                        if (nota1[i] > 100 || nota2[i] > 100 || nota1[i] < 1 || nota2[i] < 1)
                        {
                            System.Console.WriteLine("Desculpe, nota(s) inválida(s)");
                            break;
                        }

                        media[i] = (nota1[i] + nota2[i]) / 2;

                        if (media[i] >= 50)
                        {
                            situacao[i]="Aprovado";
                        }
                        else
                        {
                            situacao[i]="Reprovado";
                        }
                }
                else{
                    System.Console.WriteLine("Você digitou palavras. Só é aceito números.");
                }
            }

            for (int i = 0; i < nome.Length; i++)
            {
                System.Console.WriteLine($"O aluno {nome[i]} {sobrenome[i]} fechou com a média {media[i]} e está {situacao[i]}");
            }
}
    }
}