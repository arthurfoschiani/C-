using System;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            Salas[] Salas = new Salas[1];

                System.Console.WriteLine("----------Bem vindo----------");

            do{
                System.Console.WriteLine("Escolha uma das opções abaixo:\n1 - Cadastrar Aluno\n2 - Cadastrar Sala\n3 - Alocar Aluno\n4 - Remover Aluno\n5 - Verificar Salas\n6 - Verificar Alunos\n0 - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Alunos[] Alunos = new Alunos[4];
                        Alunos a = new Alunos();
                        int i = 0;
                        System.Console.WriteLine("Digite o nome completo do aluno:");
                        a.nome = Console.ReadLine();
                        System.Console.WriteLine("Digite a data de nascimento do aluno (dd/mm/aaaa):");
                        a.Nascimento = DateTime.Parse(Console.ReadLine());
                        System.Console.WriteLine("Digite o curso do aluno:");
                        a.curso = Console.ReadLine();
                        System.Console.WriteLine("Digite a sala do aluno:");
                        a.numSala = int.Parse(Console.ReadLine());
                        Alunos[i] = a;
                        i++;
                    break;
                    case 2:
                    
                    break;
                    case 3:
                    break;
                    case 4:
                    break;
                    case 5:
                    break;
                    case 6:
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
