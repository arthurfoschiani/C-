using System;
using System.Collections.Generic;
using Tarefas.Repositorio;
using Tarefas.Utils;
using Tarefas.ViewModel;

namespace Tarefas.ViewControllerr
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmacaoSenha, tipoString = "";
            int tipo = 0;

            do {
                System.Console.WriteLine("Digite o Nome do Uuário");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine("Nome Inválido");
                }
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine("Digite o Email do Usuário");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine("Email Inválido, o email deve conter '@' e '.'");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine("Crie a senha do usuário");
                senha = Console.ReadLine();
                
                System.Console.WriteLine("Confirme a senha");
                confirmacaoSenha = Console.ReadLine();

                if (!ValidacaoUtil.confirmaSenha (senha, confirmacaoSenha)) {
                    System.Console.WriteLine("As senhas não coincidem");
                }
            } while (!ValidacaoUtil.confirmaSenha (senha, confirmacaoSenha));

            do {
                MenusUtil.menuTipoUsuario ();
                tipo = int.Parse(Console.ReadLine());
            } while (tipo != 1 && tipo != 2);

            if (tipo == 1) {
                tipoString = "Usuário";
            }
            else if (tipo == 2) {
                tipoString = "Administrador";
            }

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.Tipo = tipoString;

            usuarioRepositorio.Colocar (usuarioViewModel);
            System.Console.WriteLine("Cadastro efetuado com sucesso!");
        }

        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;
            do {
                System.Console.WriteLine("Insira o Email:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)) {
                    System.Console.WriteLine("Email Inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            System.Console.WriteLine("Digite a Senha:");
            senha = Console.ReadLine();
            
            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario (email, senha);
            if (usuarioRecuperado != null) {
                return usuarioRecuperado;
            } else {
                System.Console.WriteLine("E-mail ou senha Inválida");
                return null;
            }
        }
    }
}