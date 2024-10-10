using System;
using System.Collections.Generic;

namespace E2.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Estoque { get; set; }

        private static List<Produto> produtos = new List<Produto>();

        public Produto(int id, string nome, decimal precoCompra, decimal precoVenda, int estoque)
        {
            Id = id;
            Nome = nome;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            Estoque = estoque;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Id: {Id}, Nome: {Nome}, Preço da compra: {PrecoCompra}, Preço da venda: {PrecoVenda}, Estoque: {Estoque}");
        }

        public static void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado.");
        }

        public static void ListarProdutos()
        {
            Console.WriteLine("\nProdutos disponíveis:");
            foreach (var produto in produtos)
            {
                produto.ExibirInformacoes();
            }
        }
    }
}
