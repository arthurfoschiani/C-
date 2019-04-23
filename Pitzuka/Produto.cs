using System;
namespace Pitzuka
{
    public class Produto
    {
        static Produto[] arrayDeProduto = new Produto[1000];
        static int cont = 0;
        int ID {get; set;}
        string Nome {get; set;}
        string Descrição {get; set;}
        float Preço {get; set;}
        int Categoria {get; set;}
        DateTime dataCriação {get; set;}

        public Produto (string nome, string descrição, float preço, int categoria)
        {
            this.Nome = nome;
            this.Descrição = descrição;
            this.Preço = preço;
            this.Categoria = categoria;
            this.ID = cont + 1;
            this.dataCriação = DateTime.Now;
        }

        public static void CadastrarProduto () {
            string nome;
            string descrição;
            float preço;
            int categoria;

            System.Console.WriteLine("Digite o nome do produto:");
            nome = Console.ReadLine();
            
            System.Console.WriteLine("Insira a descrcição do produto:");
            descrição = Console.ReadLine();
            
            System.Console.WriteLine("Insira o preço do produto");
            preço = float.Parse(Console.ReadLine());

            System.Console.WriteLine("O produto é:");
            System.Console.WriteLine("1 - Pizza");
            System.Console.WriteLine("2 - Bebida");
            categoria = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, descrição, preço, categoria);

            arrayDeProduto[cont] = p;

            cont++;
        }
        public static void ListarProdutos () {
            foreach (var item in arrayDeProduto)
            {
                if (item == null)
                {
                    break;
                }
                System.Console.WriteLine($"O ID do produto é: {item.ID}");
                System.Console.WriteLine($"O nome do produto é: {item.Nome}");
                System.Console.WriteLine($"O preço do produto é: R${item.Preço}");
                System.Console.WriteLine("===============================================================");
            }
        }
        public static void BuscarID () {
            int Id;
           
            System.Console.WriteLine("Digite o ID do produto que você deseja encontrar:");
            Id = int.Parse(Console.ReadLine());
            foreach (var item in arrayDeProduto)
            {
                if (item != null)
                {
                    if (Id.Equals(item.ID))
                    {
                        System.Console.WriteLine($"Nome do produto: {item.Nome}");
                        System.Console.WriteLine($"Descrição do produto: {item.Descrição}");
                        System.Console.WriteLine($"Categoria do produto (1-Pizza | 2-Bedida): {item.Categoria}");
                        System.Console.WriteLine($"Preço do produto: R${item.Preço}");
                        System.Console.WriteLine($"Data de criação: {item.dataCriação}");
                    }
                    else
                    {
                        System.Console.WriteLine("Produto não cadastrado");
                        break;
                    }
                }
            }
        }
    }
}