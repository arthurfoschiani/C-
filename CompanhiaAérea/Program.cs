using System;

namespace CompanhiaAérea
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            bool repetir = true;
            int[] passagem = new int[5];
            int menu;
            int x = 0;
            DateTime[] data = new DateTime[5];

            while (repetir)
            {
                System.Console.WriteLine("--------Bem Vindo a Arthur & Cia--------");
                System.Console.WriteLine("Escolha uma das opções (com os números indicados respectivamente):\n1-Registrar Passagem\n2-Visualizar Passagens\n0-Sair");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        if (x < 5)
                        {
                            System.Console.WriteLine("Insira o seu nome:");
                            nome[x] = Console.ReadLine();
                            System.Console.WriteLine("Insira o número de sua passagem:");
                            passagem[x] = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Insira a data desejada para o voo (dd/MM/aaaa):");
                            data[x] = DateTime.Parse(Console.ReadLine());
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
                        for (int j = 0; j < x; j++)
                        {
                            System.Console.WriteLine($"\n\nPassagem {y + 1}:\n\nNome: {nome[y]}\nNúmero da Passagem: {passagem[y]}\nData Escolhida: {data[y]}");
                            y++;
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