using System;

namespace APLICATIVO_FINANCEIRO.ViewModel
{
    public class TransacaoViewModel : BaseViewModel
    {
        public string TipoDaTransacao;
        public string DescricaoDaTransacao;
        public DateTime DataDaTransacao;
        public float ValorDaTransacao;
        public int IdUsuario;
    }
}