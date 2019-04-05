using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            bool repetir = true;
            string usuario;
            string nome = "jovem";
            string senha;

            while(repetir)
            {
            Console.WriteLine("Bem Vindo {0}", nome);
            Console.WriteLine("Escolha uma opição:\n1- Efetuar Login\n2- Contato\n3- Listar Comentário\n9- Sair");
            escolha = int.Parse(Console.ReadLine().ToLower());
            
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite seu usuário:");
                        usuario = Console.ReadLine().ToLower();
                        if(usuario == "arthur")
                        {
                            Console.WriteLine("Digite sua senha:");
                            senha = Console.ReadLine();
                            if (senha == "123")
                            {
                                nome = usuario;
                            }
                            else
                            {
                                Console.WriteLine("Senha Inválida");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Usuario Inesistente");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Você acessou contatos:");
                        Console.WriteLine("Arthur 0000-0000");
                        break;
                    case 3:
                        Console.WriteLine("Parabéns aos desenvolvedores!");
                        Console.WriteLine("Adorei o programa!");
                        break;
                    case 9:
                        repetir = false;
                        break;

                    default: 
                        Console.WriteLine("Valor Inválido,\nEscolha uma das opições mostradas");
                        break;
                }
            }
        }
    }
}
