using System;

public class TarefaDeMatematica : Tarefa
{
    private string _secaoDoLivro;
    private string _problemas;

    public TarefaDeMatematica(string nomeEstudante, string topico, string secaoDoLivro, string problemas)
        : base(nomeEstudante, topico)
    {
        _secaoDoLivro = secaoDoLivro;
        _problemas = problemas;
    }

    public string ObterListaDeTarefas()
    {
        return $"Capítulo {_secaoDoLivro} Problemas {_problemas}";
    }
}
