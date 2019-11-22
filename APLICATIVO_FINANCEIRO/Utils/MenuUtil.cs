using System;

namespace APLICATIVO_FINANCEIRO.Utils {
    public class MenuUtil {
        public static void MenuDeslogado () {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            System.Console.WriteLine ("        Seja bem-vindo ao          ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine ("         FINANÇA DE MESA           ");
            Console.ResetColor ();
            System.Console.WriteLine ("===================================");
            System.Console.WriteLine ("|| Digite sua opção:             ||");
            System.Console.WriteLine ("||    1 - Cadastrar Usuário      ||");
            System.Console.WriteLine ("||    2 - Efetuar Login          ||");
            System.Console.WriteLine ("||    0 - Sair                   ||");
            System.Console.WriteLine ("===================================");
        }
        public static void MenuLogado () {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine ("         FINANÇA DE MESA           ");
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine ("            Transações             ");
            Console.ResetColor ();
            System.Console.WriteLine ("===================================");
            System.Console.WriteLine ("|| Digite sua opção:             ||");
            System.Console.WriteLine ("||    1 - Registar Transação     ||");
            System.Console.WriteLine ("||    2 - Efetuar um Extrato     ||");
            System.Console.WriteLine ("||    0 - Sair                   ||");
            System.Console.WriteLine ("===================================");
        }
        public static void MenuTipoTarefa () {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine ("         Tipo de Transação        ");
            Console.ResetColor ();
            System.Console.WriteLine ("==================================");
            System.Console.WriteLine ("|| Escolha o tipo da Transação: ||");
            System.Console.WriteLine ("||    1 - Receita (Depósito)    ||");
            System.Console.WriteLine ("||    2 - Despesa (Saque)       ||");
            System.Console.WriteLine ("==================================");
        }
        public static void MenuEscolhazip () {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine ("  Você deseja salvar os dados do banco de dados em um arquivo zip?  ");
            Console.ResetColor ();
            System.Console.WriteLine ("====================================================================");
            System.Console.WriteLine ("||                  Digite o Número da sua Escolha:               ||");
            System.Console.WriteLine ("||                            1 - Sim                             ||");
            System.Console.WriteLine ("||                            2 - Não                             ||");
            System.Console.WriteLine ("====================================================================");
        }
    }
}