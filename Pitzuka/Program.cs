using System;

namespace Pitzuka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Pizzaria do Tsukamoto");

    
           int escolha = 0;
           int resposta = 0;
           do{
               
               Console.Clear ();
                System.Console.WriteLine ("===================================");
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine ("         PIZZARIA PIZZUKA         ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastro de usuário      ||");
                System.Console.WriteLine ("||  2 - Efetuar Login            ||");
                System.Console.WriteLine ("||  3 - Listar Usuários          ||");
                System.Console.WriteLine ("||  9 - Sair                     ||");
                System.Console.WriteLine ("===================================");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                         Usuario.Inserir();
                    break;
                    case 2:
                        Usuario.EfetuarLogin();
                        
                        do {
                            System.Console.WriteLine("==================================");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.White;
                            System.Console.WriteLine("               Digite uma opição:                ");
                            Console.ResetColor();
                            System.Console.WriteLine("1 - Cadastrar produto");
                            System.Console.WriteLine("2 - Listagem dos produtos");
                            System.Console.WriteLine("3 - Buscar produtos pelo ID");
                            System.Console.WriteLine("9 - Fazer Logout");
                            resposta = int.Parse(Console.ReadLine());
                            switch (resposta)
                            {
                                case 1:
                                    Produto.CadastrarProduto();
                                break;
                                case 2:
                                    Produto.ListarProdutos();
                                break;
                                case 3:
                                    Produto.BuscarID();
                                break;
                                case 9:
                                    System.Console.WriteLine("Obrigado!");
                                break;
                                default:
                                    System.Console.WriteLine("Opição Inválida, Digite novamente!");
                                break;
                            }
                        }while (resposta != 9);
                    break;
                    case 3:
                        Usuario.Listar();
                    break;
                    case 9:
                        System.Console.WriteLine("Obrigado pela visita, volte sempre!");
                    break;
                    
                    default:
                        Console.WriteLine("Valor inválido, tente novamente!");
                    break;
                }

           }while(escolha != 9);

        }
    }
}
