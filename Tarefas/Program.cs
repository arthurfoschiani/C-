using System;
using Tarefas.Utils;
using Tarefas.ViewControllerr;
using Tarefas.ViewModel;

namespace Tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslog = 0;
            int opcaoLog = 0;

            do {
                MenusUtil.menuDeslogado ();
                opcaoDeslog = int.Parse(Console.ReadLine());
                switch (opcaoDeslog) {
                    case 1:
                    //Cadastrar Usuário
                    UsuarioViewController.CadastrarUsuario ();
                    break;
                    case 2:
                    //Logar Usuário
                    UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                    if (usuarioRecuperado != null) {
                        System.Console.WriteLine($"Seja vem vindo - {usuarioRecuperado.Nome}");
                        do {
                        MenusUtil.menuLogado ();
                        opcaoLog = int.Parse(Console.ReadLine());
                            switch (opcaoLog)
                            {
                                case 1:
                                //Cadastrar Tarefa
                                TarefasViewController.cadastrarTarefas (usuarioRecuperado);
                                break;
                                case 2:
                                //Logar Tarefa
                                TarefasViewController.ListarTarefas (usuarioRecuperado);
                                break;
                                case 0:
                                System.Console.WriteLine("Você foi deslogado.");
                                break;
                                default:
                                System.Console.WriteLine("Valor Inválido, digite novamente!");
                                break;
                            }
                        } while (opcaoLog != 0);
                    }
                    break;
                    case 0:
                    System.Console.WriteLine("Obrigado pela visita, Volte Sempre!");
                    break;
                    default:
                    System.Console.WriteLine("Opção Inválida, digite novamente...");
                    break;
                }
            } while (opcaoDeslog != 0);
        }
    }
}
