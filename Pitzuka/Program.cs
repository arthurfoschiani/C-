using System;

namespace Pitzuka
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escolha = false;

            do {
                Console.Clear ();
                System.Console.WriteLine ("===================================");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine ("                    PITZUKA                         ");
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

                switch (escolha)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 9:
                        System.Console.WriteLine("Obrigado pela visita,\nVolte Sempre!!");
                        escolha = true;
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida, digite novamente:");
                        escolha = true;
                        break;
                }

            }while (!escolha);
        }
    }
}
