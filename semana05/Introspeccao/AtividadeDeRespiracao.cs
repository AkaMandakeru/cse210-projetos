using System;

public class AtividadeDeRespiracao : Atividade
{
    private int _segundosPorRespiracao = 4;

    public AtividadeDeRespiracao()
        : base("Atividade de Respiração",
               "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.")
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime fim = DateTime.Now.AddSeconds(ObterDuracao());
        while (DateTime.Now < fim)
        {
            Console.WriteLine();
            Console.Write("Inspire... ");
            ExibirContagemRegressiva(_segundosPorRespiracao);
            Console.WriteLine();
            Console.Write("Expire...  ");
            ExibirContagemRegressiva(_segundosPorRespiracao + 2);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }
}
