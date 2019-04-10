using System;

namespace CompanhiaAérea
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            string[] nome = new string[5];
            int[] passagem = new int[5];
            DateTime[] data = new DateTime[5];
            int x = 0;

                System.Console.WriteLine("--------Bem Vindo à Arthur & Cia--------");

            while (repetir)
            {
                System.Console.WriteLine("Escolha uma das opções (com os números indicados respectivamente):\n1-Registrar Passagem\n2-Visualizar Passagens\n0-Sair");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        if (x < 5)
                        {
                            System.Console.WriteLine("Insira o seu nome:");
                            nome[x] = Console.ReadLine();
                            System.Console.WriteLine("Insira o número de sua passagem:");
                            passagem[x] = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Insira a data desejada para o voo (dd/mm/aaaa):");
                            data[x] = DateTime.Parse(Console.ReadLine());
                            System.Console.WriteLine("Passageiro cadastrado com sucesso!");
                            x++;
                        }
                        else
                        {
                            System.Console.WriteLine("Limite de passagem atingido.");
                        }
                        break;

                    case 2:
                        int y = 0;
                        System.Console.WriteLine("--------Passagens Registradas--------");
                        for (int i = 0; i < x; i++)
                        {
                            System.Console.WriteLine($"\n\nPassagem {i + 1}:\n\nNome: {nome[i]}\nNúmero da Passagem: {passagem[i]}\nData Escolhida: {data[i].ToShortDateString()}");
                            i++;
                        }
                        break;

                    case 0:
                        System.Console.WriteLine("Obrigado por nos visitar, volte sempre!");
                        repetir = false;
                        break;

                    default:
                        System.Console.WriteLine("Opição Inválida");
                        break;
                }
            }
        }
    }
}