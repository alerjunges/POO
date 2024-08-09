using System;
using System.Collections.Generic;
using E2.Interfaces;

namespace E2.Classes
{
    //Classe Fornecedor
    public class Fornecedor : IPessoa
    {
        // Lista para armazenar fornecedores
        private static List<Fornecedor> fornecedores = new List<Fornecedor>();

        private int _id;
        private string _nome;
        private string _endereco;
        private string _telefone;

        //Construtor da classe Fornecedor para inicializar os campos
        public Fornecedor(int id, string nome, string endereco, string telefone)
        {
            _id = id;
            _nome = nome;
            _endereco = endereco;
            _telefone = telefone;
        }

        public string IdUnico()
        {
            return $"Fornecedor-{_id}";
        }

        //Método que simula o fornecimento do produto
        public void FornecerProduto()
        {
            Console.WriteLine($"{_nome} está fornecendo um produto.");
        }

        public void Andar()
        {
            Console.WriteLine("Fornecedor andando");
        }

        public void Falar()
        {
            Console.WriteLine("Fornecedor falando");
        }

        //Método para adicionar um novo fornecedor à lista de fornecedores
        public static void AdicionarFornecedor(Fornecedor fornecedor)
        {
            fornecedores.Add(fornecedor);
            Console.WriteLine($"Fornecedor {fornecedor._nome} adicionado.");
        }

        //Método para listar todos os fornecedores registrados
        public static void ListarFornecedores()
        {
            Console.WriteLine("\nFornecedores cadastrados:");
            foreach (var fornecedor in fornecedores)
            {
                fornecedor.ExibirInformacoes();
            }
        }

        //Método para exibir as informações do fornecedor
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {_nome}, Endereço: {_endereco}, Telefone: {_telefone}");
        }

        public static Fornecedor BuscarFornecedorPorNome(string nome)
        {
            return fornecedores.Find(fornecedor => fornecedor.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
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

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
    }
}
