using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras = new List<Palavra>();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;

        foreach (string textoPalavra in texto.Split(' '))
        {
            _palavras.Add(new Palavra(textoPalavra));
        }
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random geradorAleatorio = new Random();

        for (int i = 0; i < numeroParaOcultar; i++)
        {
            int indice = geradorAleatorio.Next(_palavras.Count);
            _palavras[indice].Ocultar();
        }
    }

    public string ObterTexto()
    {
        List<string> textosPalavras = new List<string>();

        foreach (Palavra palavra in _palavras)
        {
            textosPalavras.Add(palavra.ObterTexto());
        }

        return $"{_referencia.ObterTexto()} {string.Join(" ", textosPalavras)}";
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }
}
