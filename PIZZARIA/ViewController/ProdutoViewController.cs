using System;
using System.Collections.Generic;
using PIZZARIA.Repositorio;
using PIZZARIA.ViewModel;

namespace PIZZARIA.ViewController
{
    public class ProdutoViewController
    {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void cadastrarProduto () {
            string nome, descrição, categoria;
            float preço;

            do {
                System.Console.WriteLine ("Digite o Nome do Produto:");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                } //fim if
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Insira e descrição do produto:");
                descrição = Console.ReadLine ();
                if (string.IsNullOrEmpty (descrição)) {
                    System.Console.WriteLine ("Descrição Inválido");
                } //fim if
            } while (string.IsNullOrEmpty (descrição));

            do {
                System.Console.WriteLine ("Digite o preço do Produto:");
                preço = float.Parse(Console.ReadLine());
                if (preço <= 0) {
                    System.Console.WriteLine ("Valor Inválido");
                } //fim if
            } while (preço <= 0);

            do {
                System.Console.WriteLine("Qual a categoria do produto?");
                categoria = Console.ReadLine();
                if (string.IsNullOrEmpty (categoria)) {
                    System.Console.WriteLine("Categoria Inválida");
                } //fim if
            }while(string.IsNullOrEmpty (categoria));

            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Nome = nome;
            produtoViewModel.Descrição = descrição;
            produtoViewModel.Preco = preço;
            produtoViewModel.Categoria = categoria;

            produtoRepositorio.Inserir (produtoViewModel);
            
            System.Console.WriteLine("Cadastro realizado com sucesso!");
        }

        public static void ListarProduto () {
            List<ProdutoViewModel> listaDeProduto = produtoRepositorio.Listar();
            foreach (var item in listaDeProduto)
            {
                System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Descrição: {item.Descrição} - Preço: R${item.Preco} - Categoria: {item.Categoria} - Data de criação: {item.DataCriacao}");
            }
        }

        public static void BuscarPorId () {
            int id;
            List<ProdutoViewModel> listaDeProduto = produtoRepositorio.Listar();
            
            System.Console.WriteLine("Digite o ID do produto que você deseja encontrar:");
            id = int.Parse(Console.ReadLine());
            foreach (var item in listaDeProduto)
            {
                if (item != null && id.Equals(item.Id))
                {
                    if (id.Equals(item.Id))
                    {
                        System.Console.WriteLine($"Nome do produto: {item.Nome}");
                        System.Console.WriteLine($"Descrição do produto: {item.Descrição}");
                        System.Console.WriteLine($"Preço do produto: R${item.Preco}");
                        System.Console.WriteLine($"Categoria do produto: {item.Categoria}");
                        System.Console.WriteLine($"Data de criação: {item.DataCriacao}");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Produto não cadastrado");
                    }
                }
            }
        }
    }
}