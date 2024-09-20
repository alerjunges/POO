using System;
using System.Collections.Generic;
using E2.Interfaces;

namespace E2.Classes
{
    //Classe Cliente implementa a interface IPessoa
    public class Cliente : IPessoa
    {
        //Lista para armazenar clientes
        private static List<Cliente> clientes = new List<Cliente>();

        private int _id;
        private string _nome;
        private string _endereco;
        private string _telefone;

        //Contrutor para inicializar os campos
        public Cliente(int id, string nome, string endereco, string telefone)
        {
            _id = id;
            _nome = nome;
            _endereco = endereco;
            _telefone = telefone;
        }

        public string IdUnico()
        {
            return $"Cliente-{_id}";
        }
        public void Andar()
        {
            Console.WriteLine("Cliente andando");
        }

        public void Falar()
        {
            Console.WriteLine("Cliente falando");
        }

        //Método que simula a compra de um produto
        public void ComprarProduto()
        {
            Console.WriteLine($"{_nome} está comprando um produto.");
        }

        //Método para adicionar um cliente à lista de clientes
        public static void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine($"Cliente {cliente._nome} adicionado.");
        }

        //Método para listar todos os clientes cadastrados
        public static void ListarClientes()
        {
            Console.WriteLine("\nClientes cadastrados:");
            foreach (var cliente in clientes)
            {
                cliente.ExibirInformacoes();
            }
        }

        //Método para exibir as informações do client
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {_nome}, Endereço: {_endereco}, Telefone: {_telefone}");
        }

        public static Cliente BuscarClientePorId(int id)
        {
            return clientes.Find(cliente => cliente.Id == id);
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
