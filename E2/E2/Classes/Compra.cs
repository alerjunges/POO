using System;
using System.Collections.Generic;

namespace E2.Classes
{
    //Classe Compra
    public class Compra
    {
        protected int _id;
        protected Fornecedor _fornecedor;
        protected Produto _produto;
        protected int _quantidade;
        protected DateTime _dataCompra;

        //Lista para armazenar compras
        private static List<Compra> compras = new List<Compra>();

        //Construtor da classe Compra para inicializar os campos
        public Compra(int id, Fornecedor fornecedor, Produto produto, int quantidade, DateTime dataCompra)
        {
            _id = id;
            _fornecedor = fornecedor;
            _produto = produto;
            _quantidade = quantidade;
            _dataCompra = dataCompra;
            AtualizarEstoqueCompra();
        }

        //Método para exibir as informações da compra
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Id: {Id}, Fornecedor: {Fornecedor.Nome}, Produto: {Produto.Nome}, Quantidade: {Quantidade}, Data Compra: {DataCompra}");
        }

        //Método para calcular o valor total da compra
        public decimal CalcularValorCompra()
        {
            return _produto.PrecoCompra * _quantidade;
        }

        //Método para atualizar o estoque do produto após a compra
        public void AtualizarEstoqueCompra()
        {
            _produto.Estoque += _quantidade;
        }

        //Método para adicionar uma nova compra
        public static void AdicionarCompra(Compra compra)
        {
            compras.Add(compra);
            Console.WriteLine($"Compra do produto {compra.Produto.Nome} adicionada.");
        }

        //Método para listar todas as compras
        public static void ListarCompras()
        {
            Console.WriteLine("\nCompras registradas:");
            foreach (var compra in compras)
            {
                compra.ExibirInformacoes();
            }
        }

        //Método para exibir estoque após a compra
        public void ExibirEstoqueCompra()
        {
            Console.WriteLine($"Estoque após compra do produto {Produto.Nome}: {Produto.Estoque}");
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Fornecedor Fornecedor
        {
            get { return _fornecedor; }
            set { _fornecedor = value; }
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

        public DateTime DataCompra
        {
            get { return _dataCompra; }
            set { _dataCompra = value; }
        }
    }
}
