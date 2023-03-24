using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o terceiro projeto");

        int idadeJoao = 16;
        int quantidadePessoas = 42;

        if (idadeJoao < 18) 
        {
            // João está acompanhado
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Entrada concedida");
            }

            Console.WriteLine("Apenas maiores de 18 anos ou acompanhados são permitidos");
        }
        else
        {
            Console.WriteLine("Entrada concedida");
        }

        Console.WriteLine("Tecle [ENTER] para fechar");
        Console.ReadLine();

        // Escrevendo de outra forma...
        bool acompanhado = quantidadePessoas > 1;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Entrada concedida");
        }
        else
        {
            Console.WriteLine("Apenas maiores de 18 anos ou acompanhados são permitidos");
        }

    }

}