using System;
using System.Collections.Generic;
using APLICATIVO_FINANCEIRO.Repositório;
using APLICATIVO_FINANCEIRO.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;

namespace APLICATIVO_FINANCEIRO.ViewController {
    public class TransacaoViewController {
        public static void CadastrarTransacao (UsuarioViewModel usuario) {
            string descricao, StringOpcao = "";
            float valor;
            int opcao;

            do {
                Utils.MenuUtil.MenuTipoTarefa ();
                opcao = int.Parse (Console.ReadLine ());
            } while (opcao != 1 && opcao != 2);
            if (opcao == 1) {

                StringOpcao = "Receita (depósito)";
            } else if (opcao == 2) {

                StringOpcao = "Despesa (Saque)";
            }

            do {
                System.Console.Write ("Digite a descrição da Transação: ");
                descricao = Console.ReadLine ();
                if (string.IsNullOrEmpty (descricao)) {
                    System.Console.WriteLine ("Descrição Inválida");
                }
            } while (string.IsNullOrEmpty (descricao));

            do {
                System.Console.Write ("Digite o valor da transação: ");
                valor = float.Parse (Console.ReadLine ());
                if (valor <= 0) {
                    System.Console.WriteLine ("Valor Inválido, o valor tem que ser positivo!");
                }
            } while (valor <= 0);

            TransacaoViewModel transacaoViewModel = new TransacaoViewModel ();
            transacaoViewModel.TipoDaTransacao = StringOpcao;
            transacaoViewModel.DescricaoDaTransacao = descricao;
            transacaoViewModel.ValorDaTransacao = valor;
            transacaoViewModel.IdUsuario = usuario.Id;

            TransacaoRepositorio.Inserir (transacaoViewModel);
            System.Console.WriteLine ("Cadastro realizado com sucesso");
        }

        public static void EfetuarExtrato (UsuarioViewModel usuario) {
            float saldoReceita = 0, saldoDespesa = 0, saldoTotal = 0;
            List<TransacaoViewModel> listaDeTransacao = TransacaoRepositorio.Listar ();

            foreach (var item in listaDeTransacao) {
                if (item != null) {
                    if (item.IdUsuario.Equals (usuario.Id)) {
                        if (item.TipoDaTransacao != null) {
                            if (item.TipoDaTransacao.Equals ("Receita (depósito)")) {
                                saldoReceita = item.ValorDaTransacao + saldoReceita;
                            } else if (item.TipoDaTransacao.Equals ("Despesa (Saque)")) {
                                saldoDespesa = item.ValorDaTransacao + saldoDespesa;
                            }
                            saldoTotal = saldoReceita - saldoDespesa;
                        }

                        System.Console.WriteLine ($"Id do Usuário: {item.IdUsuario} - Id da Transição: {item.Id} - Tipo da Transação: {item.TipoDaTransacao} - Descrição: {item.DescricaoDaTransacao} - Valor da Transação: R${item.ValorDaTransacao} - Data da realização: {item.DataDaTransacao}");
                    }
                }
            }
            System.Console.WriteLine ($"Seu saldo atual é de: R${saldoTotal}");

        }

        public static void WordDocTransacao (UsuarioViewModel usuario) {
            Document doc = new Document ();
            Section section = doc.AddSection ();
            Paragraph Titulo = section.AddParagraph ();
            Paragraph Para = section.AddParagraph ();
            Titulo.Text = $"LISTAGEM DAS TRANSAÇÕES DO USUÁRIO: {usuario.Nome}\n\n\n";
            Titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;
            Para.AppendText ($"\nUsuário {usuario.Id}");
            Para.AppendText ($"\nNome do Usuário:   {usuario.Nome}");
            Para.AppendText ($"\nE-mail do Usuário:  {usuario.Email}");
            Para.AppendText ($"\nData de Nascimento do Usuário:   {usuario.DataDeNascimento}\n");
            Para.AppendText ($"\nTRANSAÇÕES:\n\n");

            List<TransacaoViewModel> transacoes = TransacaoRepositorio.Listar ();
            float saldoReceita = 0, saldoDespesa = 0, saldoTotal = 0;
            foreach (var item in transacoes) {
                if (item != null) {
                    if (item.IdUsuario.Equals (usuario.Id)) {
                        if (item.TipoDaTransacao != null) {
                            if (item.TipoDaTransacao.Equals ("Receita (depósito)")) {
                                saldoReceita = item.ValorDaTransacao + saldoReceita;
                            } else if (item.TipoDaTransacao.Equals ("Despesa (Saque)")) {
                                saldoDespesa = item.ValorDaTransacao + saldoDespesa;
                            }
                            saldoTotal = saldoReceita - saldoDespesa;
                        }
                    }
                }
            }
            foreach (var item in transacoes) {
                if (item != null) {
                    if (item.IdUsuario.Equals (usuario.Id)) {
                        Para.AppendText ($"---------------------------------------------------------------------------------------------------------------------------\n");
                        Para.AppendText ($"Id do Usuário:                                           {item.IdUsuario}\n");
                        Para.AppendText ($"Tipo:                                                                  {item.TipoDaTransacao}\n");
                        Para.AppendText ($"Descrição:                                                          {item.DescricaoDaTransacao}\n");
                        Para.AppendText ($"Valor:                                                                 R$ {item.ValorDaTransacao}\n");
                        Para.AppendText ($"Data da Transação:                                            {item.DataDaTransacao}\n");
                        Para.AppendText ($"---------------------------------------------------------------------------------------------------------------------------\n\n");
                    }
                }
            }

            Para.AppendText ($"Saldo Disponível:     R${saldoTotal}\n");
            Para.AppendText ($"---------------------------------------------------------------------------------------------------------------------------\n\n");
            doc.SaveToFile ($"RelatórioDasTransaçõesDoUsuário{usuario.Nome}.docx", FileFormat.Docx);
        }
    }
}