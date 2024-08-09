using System;
using System.Collections.Generic;

namespace E2.Classes
{
    //Classe venda
    public class Venda
    {
        protected int _id;
        protected Cliente _cliente;
        protected Produto _produto;
        protected int _quantidade;
        protected DateTime _dataVenda;

        //Lista para armazenar venda
        private static List<Venda> vendas = new List<Venda>();

        //Construtor da classe Venda para inicializar os campos
        public Venda(int id, Cliente cliente, Produto produto, int quantidade, DateTime dataVenda)
        {
            _id = id;
            _cliente = cliente;
            _produto = produto;
            _quantidade = quantidade;
            _dataVenda = dataVenda;
            AtualizarEstoqueVenda();
        }

        //Método para exibir as informações da venda
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Id: {Id}, Cliente: {Cliente.Nome}, Produto: {Produto.Nome}, Quantidade: {Quantidade}, Data Venda: {DataVenda}");
        }

        //Método para calcular o valor total da venda
        public decimal CalcularValorVenda()
        {
            return _produto.PrecoVenda * _quantidade;
        }

        //Método para atualizar o estoque do produto após a venda
        public void AtualizarEstoqueVenda()
        {
            if (_produto.Estoque >= _quantidade)
            {
                _produto.Estoque -= _quantidade;
            }
            else
            {
                Console.WriteLine($"Estoque insuficiente para o produto {_produto.Nome}.");
            }
        }

        //Método para adicionar uma nova venda
        public static void AdicionarVenda(Venda venda)
        {
            vendas.Add(venda);
            Console.WriteLine($"Venda do produto {venda.Produto.Nome} adicionada.");
        }

        //Método para listar todas as vendas
        public static void ListarVendas()
        {
            Console.WriteLine("\nVendas registradas:");
            foreach (var venda in vendas)
            {
                venda.ExibirInformacoes();
            }
        }

        //Método para exibir estoque após a venda
        public void ExibirEstoqueVenda()
        {
            Console.WriteLine($"Estoque após venda do produto {Produto.Nome}: {Produto.Estoque}");
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public Produto Produto
        {
            get { return _produto; }
            set { _produto = value; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public DateTime DataVenda
        {
            get { return _dataVenda; }
            set { _dataVenda = value; }
        }
    }
}
