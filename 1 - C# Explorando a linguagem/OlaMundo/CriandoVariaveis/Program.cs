using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criando variáveis em C#");

        // Int
        int idade;
        idade = 24;

        Console.WriteLine(idade);
        Console.WriteLine("Minha idade é " + idade);

        // Double
        double salario;
        salario = 30.30;

        Console.WriteLine(salario);

        // Typecast
        int salarioInteiro;
        salarioInteiro = (int)salario;

        Console.WriteLine(salarioInteiro);

        // Long
        long grande;
        grande = 2000000000000000000;

        // Short
        short pequeno;
        pequeno = 15000;

        // Char
        char letra = 'A';
        Console.Write(letra);

        // String
        string frase = " esperança é a última que morre";
        Console.WriteLine(frase);

        Console.WriteLine("Tecle [ENTER] para fechar...");
        Console.ReadLine();
    }
}
