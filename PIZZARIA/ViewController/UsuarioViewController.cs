using System;
using System.Collections.Generic;
using PIZZARIA.Repositorio;
using PIZZARIA.Utils;
using PIZZARIA.ViewModel;

namespace PIZZARIA.ViewController {
    public class UsuarioViewController {
        
            // Instanciar o repositório
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CadastroUsuario () {
            string nome, email, senha, confirmaSenha;

            do {
                System.Console.WriteLine ("Digite o Nome do Usuário");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                } //fim if
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Digite o Email do Usuário");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine ("Email Inválido, o email deve conter '@' e '.'");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Digite a Senha do Usuário");
                senha = Console.ReadLine ();

                System.Console.WriteLine ("Confirme a Senha");
                confirmaSenha = Console.ReadLine ();

                if (!ValidacaoUtil.confirmaçãoSenha (senha, confirmaSenha)) {
                    System.Console.WriteLine ("As Senhas não são iguais");
                }
            } while (!ValidacaoUtil.confirmaçãoSenha (senha, confirmaSenha));

            // Cria um objeto do tipo usuário
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            // método para inserir no banco de dados

            usuarioRepositorio.Inserir (usuarioViewModel);

            System.Console.WriteLine ("Cadastro efetuado com sucesso");

        } //fim cadastrar usuário

        public static void ListarUsuario () {
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();
            foreach (var item in listaDeUsuarios)
            {
                System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Data de criação: {item.DataCriacao}");
            }
        }
        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;
            do {
                System.Console.WriteLine("insira o Email:");
                email = Console.ReadLine();
                if(!ValidacaoUtil.ValidarEmail(email)) {
                    System.Console.WriteLine("Email Inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            System.Console.WriteLine("Digite a Senha:");
            senha = Console.ReadLine();
            
            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRecuperado != null) {
                return usuarioRecuperado;
            } else {
                System.Console.WriteLine("E-mail ou Senha inválida");
                return null;
            }
        }
    }
}