using System;
using System.Collections.Generic;

public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>
    {
        "Quem foi a pessoa mais interessante com quem interagi hoje?",
        "Qual foi a melhor parte do meu dia?",
        "Como vi a mão do Senhor em minha vida hoje?",
        "Qual foi a emoção mais forte que senti hoje?",
        "Se eu pudesse fazer uma coisa hoje, o que seria?",
        "O que aprendi hoje que não sabia ontem?",
        "Pelo que sou grato hoje?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random geradorAleatorio = new Random();
        int indice = geradorAleatorio.Next(_perguntas.Count);

        return _perguntas[indice];
    }
}
