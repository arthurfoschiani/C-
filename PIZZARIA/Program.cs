using System;
using PIZZARIA.Utils;
using PIZZARIA.ViewController;
using PIZZARIA.ViewModel;

namespace PIZZARIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            do {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                switch (opcaoDeslogado)
                {
                    case 1:
                    //Cadastra Usuário
                    UsuarioViewController.CadastroUsuario();
                    break;
                    case 2:
                    //Efetua Login
                    UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                    if (usuarioRecuperado != null) {
                        System.Console.WriteLine($"Seja bem vindo - {usuarioRecuperado.Nome}");
                        Console.ReadLine();
                        do {
                        MenuUtil.MenuLogado();
                        opcaoLogado = int.Parse(Console.ReadLine());
                            switch (opcaoLogado)
                            {
                                case 1:
                                //Cadastrar Produto
                                ProdutoViewController.cadastrarProduto ();
                                break;
                                case 2:
                                //Listar Produto
                                ProdutoViewController.ListarProduto ();
                                break;
                                case 3:
                                //Buscar por Id
                                ProdutoViewController.BuscarPorId ();
                                break;
                                case 0:
                                System.Console.WriteLine("Obrigado, você deslogou da sua conta!");
                                break;
                                default:
                                System.Console.WriteLine("Opção Inválida");
                                break;
                            }
                        } while (opcaoLogado != 0);
                    }
                    break;
                    case 3:
                    //Listar
                    UsuarioViewController.ListarUsuario();
                    break;
                    case 0:
                    //Sair
                    System.Console.WriteLine("Obrigado, Volte sempre!");
                    break;
                    default:
                    System.Console.WriteLine("Opção Inválida");
                    break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}
