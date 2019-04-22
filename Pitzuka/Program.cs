using System;

namespace Pitzuka
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escolha = false;
            Usuário[] us = new Usuário[10];

            do {
                Console.Clear ();
                System.Console.WriteLine ("===================================");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine ("                    PITZUKA                    ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastrar Usuário        ||");
                System.Console.WriteLine ("||  2 - Efetuar Login            ||");
                System.Console.WriteLine ("||  3 - Listar Usuários          ||");
                System.Console.WriteLine ("||  9 - Sair                     ||");
                System.Console.WriteLine ("===================================");

                System.Console.Write("Código:");
                int opição = int.Parse(Console.ReadLine());

                switch (opição)
                {
                    case 1:
                        Console.WriteLine("----------CADASTRO----------");
                        int i = 0;
                        Usuário cadastro = new Usuário();

                        Console.WriteLine("Digite seu nome:");
                        cadastro.nome = new string[4];

                        Console.WriteLine("Digite seu email:");
                        cadastro.emailUsuario[i] = Console.ReadLine();
                        
                        Console.WriteLine("Digite sua senha (mínimo 6 caracteres):");
                        cadastro.senhaUsuario[i] = Console.ReadLine();
                        
                        i++;
                        break;
                    case 2:
                        System.Console.WriteLine("----------LOGIN----------");

                        System.Console.WriteLine("Digite seu email:");
                        string email = Console.ReadLine();
                        Usuário usuarioValido = null;
                        foreach (Usuário item in emailUsuario)
                        {
                            if (item != null && email.Equals(item.emailUsuario)) 
                            {
                                    usuarioValido = item;
                                    System.Console.WriteLine("Digite sua senha:");
                                    string senha = Console.ReadLine();
                                    Usuário senhaValida = null;
                                    foreach (Usuário item2 in senhaUsuario)
                                    {
                                        if (item != null && senha.Equals(item.senhaUsuario)) 
                                        {
                                            senhaValida = item2;
                                            System.Console.WriteLine($"Bem Vindo {item.nome}");
                                            break;
                                        }
                                    }
                                    if (senhaValida == null)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        System.Console.WriteLine ($"Senha Inválida!");
                                        Console.ResetColor ();

                                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                                        Console.ReadLine ();
                                        continue;
                                    }
                                break;
                            }
                        }
                        if (usuarioValido == null) 
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Email {email} não encontrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        break;
                    case 3:
                        System.Console.WriteLine("----------LISTA CONTATOS----------");
                        for(int i =0; i < nome.Length; i++)
                        {
                            System.Console.WriteLine($"ID: {i}");
                            System.Console.WriteLine($"Nome: {nome[i]}");
                            System.Console.WriteLine($"E-mail: {emailUsuario[i]}");
                        }
                        break;
                    case 9:
                        System.Console.WriteLine("Obrigado pela visita,\nVolte Sempre!!");
                        escolha = true;
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida!");

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();
                        break;
                }

            }while (!escolha);
        }
    }
}
