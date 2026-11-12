using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);
        string texto = "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas.";
        Escritura escritura = new Escritura(referencia, texto);

        Console.Clear();
        Console.WriteLine(escritura.ObterTexto());

        while (!escritura.EstaCompletamenteOculta())
        {
            Console.WriteLine();
            Console.Write("Pressione Enter para continuar ou digite 'sair' para terminar: ");
            string entrada = Console.ReadLine();

            if (entrada == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);

            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
        }
    }
}
