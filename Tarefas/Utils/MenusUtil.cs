namespace Tarefas.Utils
{
    public class MenusUtil
    {
        public static void menuDeslogado () {
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------- AGENDA DE TAREFAS ----------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("----- (1) CADASTRAR USUÁRIO -----------");
            System.Console.WriteLine("----- (2) EFETUAR LOGIN ---------------");
            System.Console.WriteLine("----- (0) SAIR ------------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("------ DIGITE A OPÇÃO DESEJADA: -------");
        }
        public static void menuTipoUsuario () {
            System.Console.WriteLine("----- VOCÊ É UM ... -------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("----- (1) Usuário ---------------------");
            System.Console.WriteLine("----- (2) Administrador ---------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("------ DIGITE A OPÇÃO DESEJADA: -------");
        }

        public static void menuLogado () {
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("-------------- BEM VINDO --------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("----- (1) CADASTRAR TAREFAS -----------");
            System.Console.WriteLine("----- (2) LISTAR TAREFAS --------------");
            System.Console.WriteLine("----- (0) DESLOGAR --------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("------ DIGITE A OPÇÃO DESEJADA: -------");
        }

        public static void menuStatus () {
            System.Console.WriteLine("----- O STATUS DA TAREFA É ... --------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("----- (1) Para fazer ------------------");
            System.Console.WriteLine("----- (2) Fazendo ---------------------");
            System.Console.WriteLine("----- (3) Feito -----------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("------ DIGITE A OPÇÃO: ----------------");
        }
    }
}