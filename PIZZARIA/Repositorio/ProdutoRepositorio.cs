using System;
using System.Collections.Generic;
using System.IO;
using PIZZARIA.ViewModel;

namespace PIZZARIA.Repositorio
{
    public class ProdutoRepositorio
    {
        List<ProdutoViewModel> listaDeProduto = new List<ProdutoViewModel>();
        /// <summary>Método responsável por armazenar um usuário</summary>
        public ProdutoViewModel Inserir (ProdutoViewModel produto) {
            int contador = 0;
            List<ProdutoViewModel> listaDeProduto = Listar();
            if (listaDeProduto != null) {
                contador = listaDeProduto.Count;
            }
            produto.Id = contador + 1;
            produto.DataCriacao = DateTime.Now;
            StreamWriter SW = new StreamWriter ("produtos.csv", true);
            SW.WriteLine($"{produto.Id};{produto.Nome};{produto.Descrição};{produto.Categoria};{produto.Preco};{produto.DataCriacao}");
            SW.Close();
            
            return produto;
        }
        public List<ProdutoViewModel> Listar() {
            List<ProdutoViewModel> listaDeProduto = new List<ProdutoViewModel>();
            ProdutoViewModel produtoViewModel;
            if (!File.Exists("produtos.csv")) {
                return null;
            }
            string[] produtos = File.ReadAllLines("produtos.csv");
            foreach (var item in produtos)
            {
                if (item != null) {
                    string[] dadosDeCadaProduto = item.Split(";");
                    produtoViewModel = new ProdutoViewModel();
                    produtoViewModel.Id = int.Parse(dadosDeCadaProduto[0]);
                    produtoViewModel.Nome = dadosDeCadaProduto[1];
                    produtoViewModel.Descrição = dadosDeCadaProduto[2];
                    produtoViewModel.Categoria = dadosDeCadaProduto[3];
                    produtoViewModel.Preco = float.Parse(dadosDeCadaProduto[4]);
                    produtoViewModel.DataCriacao = DateTime.Parse(dadosDeCadaProduto[5]);
                    listaDeProduto.Add(produtoViewModel);
                }
            }
            return listaDeProduto;
        }//Fim listar
    }
}