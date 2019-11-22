using System;
using System.Collections.Generic;
using System.IO;
using APLICATIVO_FINANCEIRO.ViewModel;

namespace APLICATIVO_FINANCEIRO.Repositório
{
    public class TransacaoRepositorio
    {
        List<TransacaoViewModel> listaDeTransacao = new List<TransacaoViewModel> ();

        public static TransacaoViewModel Inserir (TransacaoViewModel transacao) {
            int contador = 0;

            List<TransacaoViewModel> listaDeTransacao = Listar();
            if (listaDeTransacao != null) {
                contador = listaDeTransacao.Count;
            }
            transacao.Id = contador + 1;
            transacao.DataDaTransacao = DateTime.Now;
            StreamWriter sw = new StreamWriter ("ArquivosCSV/transação.csv", true);
            sw.WriteLine($"{transacao.Id};{transacao.TipoDaTransacao};{transacao.DescricaoDaTransacao};{transacao.ValorDaTransacao};{transacao.DataDaTransacao:dd/MM/yyyy};{transacao.IdUsuario}");
            sw.Close();

            return transacao;
        }

        public static List<TransacaoViewModel> Listar() {
            List<TransacaoViewModel> listaDeTransacao = new List<TransacaoViewModel>();
            TransacaoViewModel transacaoViewModel;
            if (!File.Exists("ArquivosCSV/transação.csv")) {
                return null;
            }
            string[] transacao = File.ReadAllLines("ArquivosCSV/transação.csv");
            foreach (var item in transacao)
            {
                if (item != null) {
                    string[] dadosDeCadaTransacao = item.Split(";");
                    transacaoViewModel = new TransacaoViewModel();
                    transacaoViewModel.Id = int.Parse(dadosDeCadaTransacao[0]);
                    transacaoViewModel.TipoDaTransacao = dadosDeCadaTransacao[1];
                    transacaoViewModel.DescricaoDaTransacao = dadosDeCadaTransacao[2];
                    transacaoViewModel.ValorDaTransacao = float.Parse(dadosDeCadaTransacao[3]);
                    transacaoViewModel.DataDaTransacao = DateTime.Parse(dadosDeCadaTransacao[4]);
                    transacaoViewModel.IdUsuario = int.Parse(dadosDeCadaTransacao[5]);
                    listaDeTransacao.Add(transacaoViewModel);
                }
            }
            return listaDeTransacao;
        }
    }
}