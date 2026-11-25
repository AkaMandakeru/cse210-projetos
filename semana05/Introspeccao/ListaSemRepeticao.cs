using System;
using System.Collections.Generic;

// Sorteia itens aleatórios sem repetir nenhum até que todos tenham sido usados.
public class ListaSemRepeticao
{
    private List<string> _itens;
    private List<string> _disponiveis = new List<string>();
    private Random _aleatorio = new Random();

    public ListaSemRepeticao(List<string> itens)
    {
        _itens = itens;
    }

    public string Sortear()
    {
        if (_disponiveis.Count == 0)
        {
            _disponiveis.AddRange(_itens);
        }

        int indice = _aleatorio.Next(_disponiveis.Count);
        string item = _disponiveis[indice];
        _disponiveis.RemoveAt(indice);
        return item;
    }
}
