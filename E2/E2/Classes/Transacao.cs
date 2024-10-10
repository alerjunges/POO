using System;

namespace E2.Classes
{
    public abstract class Transacao
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }

        public Transacao(int id, Produto produto, int quantidade, DateTime data)
        {
            Id = id;
            Produto = produto;
            Quantidade = quantidade;
            Data = data;
        }

        public abstract void AtualizarEstoque();
        public virtual decimal CalcularValor() => Produto.PrecoVenda * Quantidade;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Id: {Id}, Produto: {Produto.Nome}, Quantidade: {Quantidade}, Data: {Data}");
        }
    }
}
