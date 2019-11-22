using System;
using APLICATIVO_FINANCEIRO.Repositório;
using APLICATIVO_FINANCEIRO.ViewModel;

namespace APLICATIVO_FINANCEIRO.ViewController
{
    public class UsuarioViewController
    {
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmacaoSenha;
            DateTime dataDeNascimento;
            DateTime maiorDeIdade = DateTime.Parse("15/05/2001");
            string Data;

            do {
                System.Console.Write("\nDigite o Nome do Usuário: ");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine("Nome Inválido");
                }
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.Write("Digite o Email do Usuário: ");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine("Email Inválido, o email deve conter '@' e '.'");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.Write("Crie a senha do usuário, de pelo menos 6 caracteres: ");
                senha = Console.ReadLine();
                
                System.Console.Write("Confirme a senha: ");
                confirmacaoSenha = Console.ReadLine();

                if (!ValidacaoUtil.VerificaSenha (senha, confirmacaoSenha)) {
                    System.Console.WriteLine("As senhas não coincidem");
                }

                if (!ValidacaoUtil.TamanhoSenha (senha)) {
                    System.Console.WriteLine("A senha tem menos caracteres do que pedido.");
                }
            } while (!ValidacaoUtil.VerificaSenha (senha, confirmacaoSenha) || !ValidacaoUtil.TamanhoSenha (senha));

            do {
                System.Console.Write("Digite a Data de Nascimento, (dd/MM/yyyy): ");
                Data = Console.ReadLine();
                if (!DateTime.TryParse(Data, out dataDeNascimento) || dataDeNascimento > maiorDeIdade) {
                    System.Console.WriteLine("Data de Nascimento Inválida");
                }
            } while (!DateTime.TryParse(Data, out dataDeNascimento) || dataDeNascimento > maiorDeIdade);

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.DataDeNascimento = dataDeNascimento;

            UsuarioRepositorio.Colocar (usuarioViewModel);
            System.Console.WriteLine("Cadastro Realizado!");
            Console.ReadLine();
        }

        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;
            do {
                System.Console.Write("\nInsira o Email: ");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)) {
                    System.Console.WriteLine("Email Inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            System.Console.Write("Digite a Senha: ");
            senha = Console.ReadLine();
            
            UsuarioViewModel usuarioRecuperado = UsuarioRepositorio.BuscarUsuario (email, senha);
            if (usuarioRecuperado != null) {
                return usuarioRecuperado;
            } else {
                System.Console.WriteLine("E-mail ou Senha Inválida");
                return null;
            }
        }
    }
}