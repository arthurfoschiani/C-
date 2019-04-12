using System;

namespace CompAer2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem-vindo à Arthur & CIA");

            int codigo;
            bool sair = false;
            int passageirosCadastrados = 0;
            Passageiro[] passageiros = new Passageiro[2];

            do
            {
                System.Console.WriteLine("Escolha uma das opções (com os números indicados respectivamente):\n1-Registrar Passagem\n2-Visualizar Passagens\n0-Sair");
                codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        Passageiro p = new Passageiro();
                        System.Console.WriteLine("Digite o nome do passageiro:");
                        p.setNome(Console.ReadLine());
                        System.Console.WriteLine("Digite o numero da passagem do usuário:");
                        p.setNumPassagem(int.Parse(Console.ReadLine()));
                        System.Console.WriteLine("Digite a data desejada para o voo (dd/mm/aaaa):");
                        p.setData(DateTime.Parse(Console.ReadLine()));
                        passageiros[passageirosCadastrados] = p;
                        passageirosCadastrados++;
                        System.Console.WriteLine("Passageiro cadastrado com sucesso!");
                        break;
                    case 2:
                            System.Console.WriteLine("Todos os passageiros cadastrados:");
                        for (int i = 0; i < passageirosCadastrados; i++)
                        {
                            System.Console.WriteLine($"O nome do {i + 1}º passageiro é: {passageiros[i].getNome()}");
                            System.Console.WriteLine($"O número da {i + 1}ª passagem é: {passageiros[i].getNumPassagem()}");
                            System.Console.WriteLine($"A data escolhida pela {i + 1}ª pessoa é: {passageiros[i].getData()}");
                        }
                        break;
                }

            } while (!sair);

        }
    }
}
