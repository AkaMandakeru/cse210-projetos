using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas geradorDePerguntas = new GeradorDePerguntas();

        Console.WriteLine("Bem-vindo ao Programa Diário!");

        string escolha = "";

        while (escolha != "5")
        {
            Console.WriteLine("Por favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");
            escolha = Console.ReadLine();

            if (escolha == "1")
            {
                string pergunta = geradorDePerguntas.ObterPerguntaAleatoria();
                Console.WriteLine(pergunta);
                Console.Write("> ");
                string resposta = Console.ReadLine();

                Registro registro = new Registro();
                registro._data = DateTime.Now.ToShortDateString();
                registro._textoPergunta = pergunta;
                registro._textoResposta = resposta;

                diario.AdicionarRegistro(registro);
            }
            else if (escolha == "2")
            {
                diario.ExibirTodos();
            }
            else if (escolha == "3")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                diario.CarregarDoArquivo(arquivo);
            }
            else if (escolha == "4")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                diario.SalvarNoArquivo(arquivo);
            }
        }
    }
}
