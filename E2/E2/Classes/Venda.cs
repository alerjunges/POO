using System;
using System.Collections.Generic;

namespace E2.Classes
{
    public class Venda : Transacao
    {
        public Cliente Cliente { get; set; }
        private static List<Venda> vendas = new List<Venda>();

        public Venda(int id, Cliente cliente, Produto produto, int quantidade, DateTime data)
            : base(id, produto, quantidade, data)
        {
            Cliente = cliente;
            AtualizarEstoque();
        }

        public override void AtualizarEstoque()
        {
            if (Produto.Estoque >= Quantidade)
            {
                Produto.Estoque -= Quantidade;
            }
            else
            {
                Console.WriteLine($"Estoque insuficiente para o produto {Produto.Nome}.");
            }
        }

        public static void AdicionarVenda(Venda venda)
        {
            vendas.Add(venda);
            Console.WriteLine($"Venda do produto {venda.Produto.Nome} adicionada.");
        }

        public void ExibirEstoqueVenda()
        {
            Console.WriteLine($"Estoque atual do produto {Produto.Nome}: {Produto.Estoque}");
        }

    }
}
