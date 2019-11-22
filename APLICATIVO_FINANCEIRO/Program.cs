using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Compression;
using APLICATIVO_FINANCEIRO.Repositório;
using APLICATIVO_FINANCEIRO.Utils;
using APLICATIVO_FINANCEIRO.ViewController;
using APLICATIVO_FINANCEIRO.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace APLICATIVO_FINANCEIRO {
    class Program {
        static void Main (string[] args) {

            string OpcaoDeslogado;
            string OpcaoLogado;
            bool QuerSair2 = false;
            bool QuerSair = false;
            do {
                MenuUtil.MenuDeslogado ();
                OpcaoDeslogado = Console.ReadLine ();
                int deslog = 0;
                if (int.TryParse (OpcaoDeslogado, out deslog)) {
                    switch (deslog) {
                        case 1:
                            UsuarioViewController.CadastrarUsuario ();
                            break;
                        case 2:
                            UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                            if (usuarioRecuperado != null) {
                                System.Console.WriteLine ($"Bem vindo {usuarioRecuperado.Nome}");
                                do {
                                    MenuUtil.MenuLogado ();
                                    OpcaoLogado = Console.ReadLine ();
                                    int log = 0;
                                    if (int.TryParse (OpcaoLogado, out log)) {
                                    switch (log) {
                                        case 1:
                                            TransacaoViewController.CadastrarTransacao (usuarioRecuperado);
                                            Console.ReadLine ();
                                            break;
                                        case 2:
                                            TransacaoViewController.EfetuarExtrato (usuarioRecuperado);
                                            Console.ReadLine ();
                                            break;
                                        case 0:
                                            System.Console.WriteLine ("Você foi deslogado, volte sempre!");
                                            TransacaoViewController.WordDocTransacao (usuarioRecuperado);
                                            Console.ReadLine ();
                                            QuerSair2 = true;
                                            break;
                                        default:
                                            System.Console.WriteLine ("Valor Inválido, digite novamente");
                                            Console.ReadLine ();
                                            break;
                                    }
                                    } else {
                                        System.Console.WriteLine("Digite um número e não uma letra");
                                    }

                                } while (!QuerSair2);
                            }
                            break;
                        case 0:
                            MenuUtil.MenuEscolhazip ();
                            int escolhaZip = int.Parse (Console.ReadLine ());
                            int QuantidadeZip = 0;
                            if (escolhaZip == 1) {
                                ZiparCSV (QuantidadeZip);
                                WordDocUsuários ();
                                QuantidadeZip++;
                                System.Console.WriteLine ("Obrigado, volte sempre!");
                            } else if (escolhaZip == 2) {
                                System.Console.WriteLine ("Obrigado, volte sempre!");
                            }
                            QuerSair = true;
                            break;
                        default:
                            System.Console.WriteLine ("Valor Inválido, digite novamente.");
                            break;
                    }
                } else {
                    System.Console.WriteLine ("Digite um número e não uma letra");
                    Console.ReadLine();
                }

            } while (!QuerSair);

        }

        static void WordDocUsuários () {
            Document doc = new Document ();
            List<UsuarioViewModel> listaDeUsuario = UsuarioRepositorio.Listar ();

            //Add Section
            Section section = doc.AddSection ();
            //Add Paragraph
            Paragraph Titulo = section.AddParagraph ();
            //Append Text
            Titulo.Text = "Listagem dos Usuários cadastrados na aplicação Finança de Mesa";
            Titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;
            foreach (var item in listaDeUsuario) {
                Paragraph Corpo = section.AddParagraph ();
                Corpo.AppendText ($"\n=========================================================================");
                Corpo.AppendText ($"\nUsuário {item.Id}                                                        ");
                Corpo.AppendText ($"\nNome do Usuário {item.Id}:                                               {item.Nome}    ");
                Corpo.AppendText ($"\nE-mail do Usuário {item.Id}:                                              {item.Email}    ");
                Corpo.AppendText ($"\nData de Nascimento do Usuário {item.Id}:                        {item.DataDeNascimento}    ");
                Corpo.AppendText ($"\n=========================================================================");
            }
            //Save Word1
            doc.SaveToFile ("RelatórioDosUsuários.docx", FileFormat.Docx);
        }
        static void ZiparCSV (int QuantidadeZip) {

            string NomeInicialDaPasta = $@".\ArquivosCSV";
            string NomeDaPastaZip = $@".\ArquivosCSV{QuantidadeZip}.zip";

            ZipFile.CreateFromDirectory (NomeInicialDaPasta, NomeDaPastaZip);
        }
    }
}