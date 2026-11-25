using System;
using System.Collections.Generic;

public class AtividadeDeListagem : Atividade
{
    private ListaSemRepeticao _sugestoes = new ListaSemRepeticao(new List<string>
    {
        "Quem são as pessoas que você aprecia?",
        "Quais são seus pontos fortes pessoais?",
        "Quem são as pessoas que você ajudou esta semana?",
        "Quando você sentiu o Espírito Santo neste mês?",
        "Quem são alguns dos seus heróis pessoais?"
    });

    public AtividadeDeListagem()
        : base("Atividade de Listagem",
               "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.")
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.WriteLine("Liste o máximo de respostas que puder para a seguinte sugestão:");
        Console.WriteLine($" --- {_sugestoes.Sortear()} ---");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine();

        int quantidade = 0;
        DateTime fim = DateTime.Now.AddSeconds(ObterDuracao());
        while (DateTime.Now < fim)
        {
            Console.Write("> ");
            string resposta = Console.ReadLine();
            if (resposta == null)
            {
                break;
            }
            if (!string.IsNullOrWhiteSpace(resposta))
            {
                quantidade++;
            }
        }

        Console.WriteLine($"Você listou {quantidade} itens!");

        ExibirMensagemFinal();
    }
}
