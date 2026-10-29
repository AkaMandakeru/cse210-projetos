using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a sua nota (em porcentagem)? ");
        int nota = int.Parse(Console.ReadLine());

        string letra;

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        int ultimoDigito = nota % 10;
        string sinal = "";

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }
        else if (ultimoDigito < 3)
        {
            sinal = "-";
        }

        // Não existe A+, nem F+ ou F-; e 100 é A sem sinal
        if (letra == "A" && (sinal == "+" || nota >= 100))
        {
            sinal = "";
        }
        else if (letra == "F")
        {
            sinal = "";
        }

        Console.WriteLine($"Sua nota é: {letra}{sinal}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns, você foi aprovado!");
        }
        else
        {
            Console.WriteLine("Não desanime, continue se esforçando e você vai conseguir da próxima vez!");
        }
    }
}
