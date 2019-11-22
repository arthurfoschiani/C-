using System;
namespace PIZZARIA.Utils
{
    public class MenuUtil
    {
        /// <sumary>Exibe as opções do usuário Deslogado</summary>
        public static void MenuDeslogado () {
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("------------- ARTHURZZA ---------------");
            System.Console.WriteLine("--- (1) Cadastrar Usuário -------------");
            System.Console.WriteLine("--- (2) Efetuar Login -----------------");
            System.Console.WriteLine("--- (3) Listar ------------------------");
            System.Console.WriteLine("--- (0) Sair --------------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------- Escolha um Opção -----------");
        }

        public static void MenuLogado () {
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("------------- ARTHURZZA ---------------");
            System.Console.WriteLine("----------    Cardápio    -------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("--- (1) Cadastrar Produto -------------");
            System.Console.WriteLine("--- (2) Listar todos os produtos ------");
            System.Console.WriteLine("--- (3) Buscar produto por Id ---------");
            System.Console.WriteLine("--- (0) Deslogar ----------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------- Escolha um Opção -----------");
        }
    }
}