using System;
using E2.Interfaces;

namespace E2.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Pessoa(int id, string nome, string endereco, string telefone)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public abstract string IdUnico();

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Endereço: {Endereco}, Telefone: {Telefone}");
        }
    }
}
