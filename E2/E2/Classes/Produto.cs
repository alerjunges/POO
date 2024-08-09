using System;
using System.Collections.Generic;

namespace E2.Classes
{
    //Classe produto
    public class Produto
    {
        protected int _id;
        protected string _nome;
        protected decimal _precoCompra;
        protected decimal _precoVenda;
        protected int _estoque;

        //Lista para armazenar produtos
        private static List<Produto> produtos = new List<Produto>();

        //Construtor da classe Produto para inicializar os campos
        public Produto(int id, string nome, decimal precoCompra, decimal precoVenda, int estoque)
        {
            _id = id;
            _nome = nome;
            _precoCompra = precoCompra;
            _precoVenda = precoVenda;
            _estoque = estoque;
        }

        //Método para exibir as informações do produt
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Id: {Id}, Nome: {Nome}, Preço da compra: {PrecoCompra}, Preço da venda {PrecoVenda}, Estoque {Estoque}");
        }

        // Método para adicionar um novo produto
        public static void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado.");
        }

        // Método para listar todos os produtos
        public static void ListarProdutos()
        {
            Console.WriteLine("\nProdutos disponíveis:");
            foreach (var produto in produtos)
            {
                produto.ExibirInformacoes();
            }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public decimal PrecoCompra
        {
            get { return _precoCompra; }
            set { _precoCompra = value; }
        }

        public decimal PrecoVenda
        {
            get { return _precoVenda; }
            set { _precoVenda = value; }
        }

        public int Estoque
        {
            get { return _estoque; }
            set { _estoque = value; }
        }

    }
}
