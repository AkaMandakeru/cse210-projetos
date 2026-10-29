using System;

class Program
{
    static void Main(string[] args)
    {
        Random geradorAleatorio = new Random();
        string jogarNovamente = "sim";

        while (jogarNovamente == "sim")
        {
            int numeroMagico = geradorAleatorio.Next(1, 101);
            int palpite = -1;
            int quantidadePalpites = 0;

            while (palpite != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                palpite = int.Parse(Console.ReadLine());
                quantidadePalpites++;

                if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else if (palpite > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }
                else
                {
                    Console.WriteLine("Você adivinhou!");
                }
            }

            Console.WriteLine($"Você fez {quantidadePalpites} palpites.");

            Console.Write("Quer jogar novamente? ");
            jogarNovamente = Console.ReadLine();
        }
    }
}
