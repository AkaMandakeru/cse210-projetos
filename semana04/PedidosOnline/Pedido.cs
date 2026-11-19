using System;
using System.Collections.Generic;

public class Pedido
{
    private List<Produto> _produtos = new List<Produto>();
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public decimal ObterCustoFrete()
    {
        return _cliente.MoraNosEUA() ? 5m : 35m;
    }

    public decimal CalcularPrecoTotal()
    {
        decimal total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.ObterCustoTotal();
        }

        return total + ObterCustoFrete();
    }

    public string ObterEtiquetaEmbalagem()
    {
        string etiqueta = "Etiqueta de embalagem:\n";

        foreach (Produto produto in _produtos)
        {
            etiqueta += $"- {produto.ObterNome()} (ID: {produto.ObterId()})\n";
        }

        return etiqueta;
    }

    public string ObterEtiquetaEnvio()
    {
        return $"Etiqueta de envio:\n{_cliente.ObterNome()}\n{_cliente.ObterEndereco().ObterEnderecoCompleto()}\n";
    }
}
