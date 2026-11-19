using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco("123 Main Street", "Provo", "UT", "EUA");
        Cliente cliente1 = new Cliente("John Smith", endereco1);
        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(new Produto("Caderno", "P001", 3.00m, 5));
        pedido1.AdicionarProduto(new Produto("Caneta azul", "P002", 1.50m, 10));
        pedido1.AdicionarProduto(new Produto("Mochila", "P003", 45.90m, 1));

        Endereco endereco2 = new Endereco("Rua das Flores, 250", "Curitiba", "PR", "Brasil");
        Cliente cliente2 = new Cliente("Maria Oliveira", endereco2);
        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(new Produto("Fone de ouvido", "P004", 59.99m, 1));
        pedido2.AdicionarProduto(new Produto("Cabo USB-C", "P005", 12.50m, 2));

        List<Pedido> pedidos = new List<Pedido> { pedido1, pedido2 };

        int numero = 1;
        foreach (Pedido pedido in pedidos)
        {
            Console.WriteLine($"===== Pedido {numero} =====");
            Console.WriteLine(pedido.ObterEtiquetaEmbalagem());
            Console.WriteLine(pedido.ObterEtiquetaEnvio());
            Console.WriteLine($"Frete: ${pedido.ObterCustoFrete():F2}");
            Console.WriteLine($"Preço total: ${pedido.CalcularPrecoTotal():F2}");
            Console.WriteLine();
            numero++;
        }
    }
}
