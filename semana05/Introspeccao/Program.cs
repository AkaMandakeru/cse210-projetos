using System;

// Além dos requisitos:
// 1. As sugestões e perguntas das atividades de Reflexão e Listagem não se repetem
//    até que todas tenham sido usadas pelo menos uma vez (classe ListaSemRepeticao).
// 2. O programa conta quantas vezes cada atividade foi feita na sessão e mostra
//    esse resumo no menu e ao sair.
// 3. A entrada da duração é validada: só aceita números inteiros maiores que zero.
// 4. Na Atividade de Listagem, respostas em branco não são contadas como itens.

class Program
{
    static void Main(string[] args)
    {
        AtividadeDeRespiracao respiracao = new AtividadeDeRespiracao();
        AtividadeDeReflexao reflexao = new AtividadeDeReflexao();
        AtividadeDeListagem listagem = new AtividadeDeListagem();

        int vezesRespiracao = 0;
        int vezesReflexao = 0;
        int vezesListagem = 0;

        string opcao = "";
        while (opcao != "4")
        {
            Console.Clear();
            Console.WriteLine("Opções do menu:");
            Console.WriteLine($"  1. Iniciar atividade de respiração (feita {vezesRespiracao}x)");
            Console.WriteLine($"  2. Iniciar atividade de reflexão (feita {vezesReflexao}x)");
            Console.WriteLine($"  3. Iniciar atividade de listagem (feita {vezesListagem}x)");
            Console.WriteLine("  4. Sair");
            Console.Write("Selecione uma opção do menu: ");
            opcao = Console.ReadLine() ?? "4";

            switch (opcao)
            {
                case "1":
                    respiracao.Executar();
                    vezesRespiracao++;
                    break;
                case "2":
                    reflexao.Executar();
                    vezesReflexao++;
                    break;
                case "3":
                    listagem.Executar();
                    vezesListagem++;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    respiracao.ExibirSpinner(2);
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Resumo da sessão:");
        Console.WriteLine($"  Respiração: {vezesRespiracao}x");
        Console.WriteLine($"  Reflexão: {vezesReflexao}x");
        Console.WriteLine($"  Listagem: {vezesListagem}x");
        Console.WriteLine("Até a próxima!");
    }
}
