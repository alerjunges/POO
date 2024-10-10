using System;
using System.Collections.Generic;

namespace E2.Classes
{
    public class Compra : Transacao
    {
        public Fornecedor Fornecedor { get; set; }
        private static List<Compra> compras = new List<Compra>();

        public Compra(int id, Fornecedor fornecedor, Produto produto, int quantidade, DateTime data)
            : base(id, produto, quantidade, data)
        {
            Fornecedor = fornecedor;
            AtualizarEstoque();
        }

        public override void AtualizarEstoque()
        {
            Produto.Estoque += Quantidade;
        }

        public static void AdicionarCompra(Compra compra)
        {
            compras.Add(compra);
            Console.WriteLine($"Compra do produto {compra.Produto.Nome} adicionada.");
        }
    }
}
