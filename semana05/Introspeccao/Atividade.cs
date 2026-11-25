using System;
using System.Threading;

public class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = 0;
    }

    public int ObterDuracao()
    {
        return _duracao;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Bem-vindo à {_nome}.");
        Console.WriteLine();
        Console.WriteLine(_descricao);
        Console.WriteLine();
        Console.Write("Quantos segundos você gostaria para esta sessão? ");
        _duracao = LerNumeroPositivo();

        Console.Clear();
        Console.WriteLine("Prepare-se...");
        ExibirSpinner(3);
        Console.WriteLine();
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Muito bem!!");
        ExibirSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"Você completou mais {_duracao} segundos da {_nome}.");
        ExibirSpinner(3);
    }

    public void ExibirSpinner(int segundos)
    {
        string[] quadros = { "|", "/", "-", "\\" };
        DateTime fim = DateTime.Now.AddSeconds(segundos);
        int i = 0;

        while (DateTime.Now < fim)
        {
            Console.Write(quadros[i % quadros.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            string numero = i.ToString();
            Console.Write(numero);
            Thread.Sleep(1000);
            Console.Write(new string('\b', numero.Length) + new string(' ', numero.Length) + new string('\b', numero.Length));
        }
    }

    private int LerNumeroPositivo()
    {
        while (true)
        {
            string entrada = Console.ReadLine();
            if (entrada == null)
            {
                return 1;
            }

            if (int.TryParse(entrada, out int valor) && valor > 0)
            {
                return valor;
            }

            Console.Write("Digite um número inteiro maior que zero: ");
        }
    }
}
