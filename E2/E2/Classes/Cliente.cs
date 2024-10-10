using System;
using System.Collections.Generic;

namespace E2.Classes
{
    public class Cliente : Pessoa
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public Cliente(int id, string nome, string endereco, string telefone) : base(id, nome, endereco, telefone) { }

        public override string IdUnico()
        {
            return $"Cliente-{Id}";
        }

        public static void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine($"Cliente {cliente.Nome} adicionado.");
        }

        public static void ListarClientes()
        {
            Console.WriteLine("\nClientes cadastrados:");
            foreach (var cliente in clientes)
            {
                cliente.ExibirInformacoes();
            }
        }

        public static Cliente BuscarClientePorId(int id)
        {
            return clientes.Find(cliente => cliente.Id == id);
        }
    }
}
