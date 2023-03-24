using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criando variáveis em C#");

        int idade;
        idade = 24;

        Console.WriteLine(idade);
        Console.WriteLine("Minha idade é " + idade);

        double salario;
        salario = 30.30;

        Console.WriteLine(salario);

        Console.WriteLine("Tecle [ENTER] para fechar...");
        Console.ReadLine();
    }
}
