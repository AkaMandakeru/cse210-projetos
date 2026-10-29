using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;
        while (numero != 0)
        {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numeros.Add(numero);
            }
        }

        int soma = 0;
        foreach (int n in numeros)
        {
            soma += n;
        }
        Console.WriteLine($"A soma é: {soma}");

        double media = (double)soma / numeros.Count;
        Console.WriteLine($"A média é: {media}");

        int maior = numeros[0];
        foreach (int n in numeros)
        {
            if (n > maior)
            {
                maior = n;
            }
        }
        Console.WriteLine($"O maior número é: {maior}");

        // Começa com o maior valor possível para que qualquer positivo seja menor
        int menorPositivo = int.MaxValue;
        foreach (int n in numeros)
        {
            if (n > 0 && n < menorPositivo)
            {
                menorPositivo = n;
            }
        }
        Console.WriteLine($"O menor número positivo é: {menorPositivo}");

        numeros.Sort();
        Console.WriteLine("A lista reordenada é:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}
