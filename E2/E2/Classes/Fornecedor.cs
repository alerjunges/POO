using System;
using System.Collections.Generic;
using E2.Interfaces;

namespace E2.Classes
{
    public class Fornecedor : IPessoa
    {
        private static List<Fornecedor> fornecedores = new List<Fornecedor>();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Fornecedor(int id, string nome, string endereco, string telefone)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string IdUnico()
        {
            return $"Fornecedor-{Id}";
        }

        public void FornecerProduto()
        {
            Console.WriteLine($"{Nome} está fornecendo um produto.");
        }

        public void Andar()
        {
            Console.WriteLine("Fornecedor andando");
        }

        public void Falar()
        {
            Console.WriteLine("Fornecedor falando");
        }

        public static void AdicionarFornecedor(Fornecedor fornecedor)
        {
            fornecedores.Add(fornecedor);
            Console.WriteLine($"Fornecedor {fornecedor.Nome} adicionado.");
        }

        public static void ListarFornecedores()
        {
            Console.WriteLine("\nFornecedores cadastrados:");
            foreach (var fornecedor in fornecedores)
            {
                fornecedor.ExibirInformacoes();
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Endereço: {Endereco}, Telefone: {Telefone}");
        }

        public static Fornecedor BuscarFornecedorPorNome(string nome)
        {
            return fornecedores.Find(fornecedor => fornecedor.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
    }
}
