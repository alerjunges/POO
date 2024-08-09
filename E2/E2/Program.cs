using System;
using E2.Classes;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLIENTE
            // Criando instâncias de clientes
            Cliente cliente1 = new Cliente(1, "João Silva", "Rua A, 123", "1234-5678");
            Cliente cliente2 = new Cliente(2, "Ana Pereira", "Rua C, 789", "5555-1234");
           
            // Adicionando clientes e exibindo info dos clientes
            Console.WriteLine("Clientes adicionados:");
            Cliente.AdicionarCliente(cliente1);
            Cliente.AdicionarCliente(cliente2);
            Cliente.ListarClientes();


            //FORNECEDOR
            // Criando instâncias do fornecedor
            Fornecedor fornecedor = new Fornecedor(1, "Maria Oliveira", "Avenida B, 456", "9876-5432");
            
            // Adicionando fornecedores e exibindo indo dos fornecedores
            Console.WriteLine("\nFornecedores adicionados:");
            Fornecedor.AdicionarFornecedor(fornecedor);
            Fornecedor.ListarFornecedores();


            //PRODUTO
            // Criando instâncias dos produtos
            Produto roupa = new Produto(1, "Camisa Polo", 30.00m, 50.00m, 10);
            Produto disco = new Produto(2, "Álbum de Rock", 20.00m, 40.00m, 50);

            // Adicionando produtos e exibindo info dos produtos
            Console.WriteLine("\nProdutos adicionados:");
            Produto.AdicionarProduto(roupa);
            Produto.AdicionarProduto(disco);
            Produto.ListarProdutos();


            //COMPRA
            // Criando instâncias das compras
            Compra compraRoupa = new Compra(1, fornecedor, roupa, 10, DateTime.Now);
            Compra compraDisco = new Compra(2, fornecedor, disco, 5, DateTime.Now);

            // Adicionando compras 
            Console.WriteLine("\nCompras adicionadas:");
            Compra.AdicionarCompra(compraRoupa);
            Compra.AdicionarCompra(compraDisco);

            // Exibindo info das compras e calculando o valor da compra
            Console.WriteLine("\nCompras Realizadas:");
            compraRoupa.ExibirInformacoes();
            Console.WriteLine($"Valor da compra: {compraRoupa.CalcularValorCompra():C}");

            compraDisco.ExibirInformacoes();
            Console.WriteLine($"Valor da compra: {compraDisco.CalcularValorCompra():C}");

            // Exibindo estoque após as compras
            Console.WriteLine("\nEstoque Após Compras:");
            compraRoupa.ExibirEstoqueCompra();
            compraDisco.ExibirEstoqueCompra();


            //VENDA
            // Criando instâncias das vendas
            Venda vendaRoupa = new Venda(1, cliente1, roupa, 2, DateTime.Now);
            Venda vendaDisco = new Venda(2, cliente2, disco, 1, DateTime.Now);

            // Adicionando vendas
            Console.WriteLine("\nVendas adicionadas:");
            Venda.AdicionarVenda(vendaRoupa);
            Venda.AdicionarVenda(vendaDisco);

            // Exibindo info das vendas e calculando o valor de venda
            Console.WriteLine("\nVendas Realizadas:");
            vendaRoupa.ExibirInformacoes();
            Console.WriteLine($"Valor da venda: {vendaRoupa.CalcularValorVenda():C}");

            vendaDisco.ExibirInformacoes();
            Console.WriteLine($"Valor da venda: {vendaDisco.CalcularValorVenda():C}");

            // Exibindo estoque após as vendas
            Console.WriteLine("\nEstoque Após Vendas:");
            vendaRoupa.ExibirEstoqueVenda();
            vendaDisco.ExibirEstoqueVenda();


            //Buscando fornecedor por nome
            Fornecedor fornecedorEncontrado = Fornecedor.BuscarFornecedorPorNome("Maria Oliveira");
            if (fornecedorEncontrado != null)
            {
                Console.WriteLine($"\n\nFornecedor encontrado: {fornecedorEncontrado.Nome}");
            }
            else
            {
                Console.WriteLine("\n\nFornecedor não encontrado.");
            }

            //Buscando cliente por id
            Cliente clienteEncontrado = Cliente.BuscarClientePorId(1);
            if (clienteEncontrado != null)
            {
                Console.WriteLine($"\n\nCliente encontrado: {clienteEncontrado.Nome}");
            }
            else
            {
                Console.WriteLine("\n\nCliente não encontrado.");
            }
        }
    }
}
