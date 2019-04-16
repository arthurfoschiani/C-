using System;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            Sala[] Salas = new Sala[1];
            Aluno[] Alunos = new Aluno[2];
            int salasCadastradas = 0;
            int alunosCadastrados = 0;

                System.Console.WriteLine("----------Bem vindo----------");

            do{
                System.Console.WriteLine("Escolha uma das opções abaixo:\n1 - Cadastrar Aluno\n2 - Cadastrar Sala\n3 - Alocar Aluno\n4 - Remover Aluno\n5 - Verificar Salas\n6 - Verificar Alunos\n0 - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Aluno a = new Aluno();

                        System.Console.WriteLine("--------Cadastrar Alunos--------");

                        System.Console.WriteLine("Digite o nome completo do aluno:");
                        a.nome = Console.ReadLine();

                        System.Console.WriteLine("Digite a data de nascimento do aluno (dd/mm/aaaa):");
                        a.Nascimento = DateTime.Parse(Console.ReadLine());

                        System.Console.WriteLine("Digite o curso do aluno:");
                        a.curso = Console.ReadLine();

                        // System.Console.WriteLine("Digite a sala do aluno:");
                        // a.numSala = int.Parse(Console.ReadLine());

                        Alunos[alunosCadastrados] = a;

                        alunosCadastrados++;

                        System.Console.WriteLine("Cadastro do aluno concluido!");
                    break;
                    case 2:
                        Sala s = new Sala();

                        System.Console.WriteLine("--------Cadastrar Sala--------");

                        System.Console.WriteLine("Digite o número da sala:");
                        s.numSala = int.Parse(Console.ReadLine());

                        System.Console.WriteLine("Digite a capacidade de alunos na sala:");
                        s.capacidadeTotal = int.Parse(Console.ReadLine());

                        s.capacidadeAtual = s.capacidadeTotal;

                        s.alunos = new string[s.capacidadeTotal];

                        Salas[salasCadastradas] = s;

                        salasCadastradas++;

                        System.Console.WriteLine("Cadastro da sala concluido!");
                    break;
                    case 3:
                        Sala aluno = new Sala();
                        System.Console.WriteLine("--------Alocar alunos--------");
                        System.Console.WriteLine($"na sala tem ");
                    break;
                    case 4:
                        System.Console.WriteLine("--------Remover Aluno--------");
                        
                    break;
                    case 5:
                        System.Console.WriteLine("--------Verificar Salas--------");
                        foreach (var item in Salas)
                        {
                            if (item != null)
                            {
                                System.Console.WriteLine("---------------------------------");
                                System.Console.WriteLine($"Número da sala: {item.numSala}");
                                System.Console.WriteLine($"Vagas disponíveis: {item.capacidadeAtual}");
                                System.Console.WriteLine("---------------------------------");
                            }
                        }

                    break;
                    case 6:
                        System.Console.WriteLine("--------Verificar Alunos--------");
                        foreach (var item in Alunos)
                        {
                            if (item != null)
                            {
                                System.Console.WriteLine("---------------------------------");
                                System.Console.WriteLine($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine($"Curso: {item.curso}");
                                System.Console.WriteLine("---------------------------------");
                            }
                        }
                    break;
                    case 0:
                        System.Console.WriteLine("Obrigado por nos visitar, volte sempre!");
                    break;
                    default:
                        System.Console.WriteLine("Valor Inválido, insira novamente!");
                    break;
                }
            }while(escolha != 0);
        }
    }
}
