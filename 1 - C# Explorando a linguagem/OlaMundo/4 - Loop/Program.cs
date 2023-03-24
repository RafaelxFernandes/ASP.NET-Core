using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simulação de uma poupança");

        double investimento = 1000;

        int mes = 1;

        while (mes <= 12)
        {
            // Rendimento de 0.5% (0.005) ao mês
            investimento *= 1.005;
    
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
            
            mes++;
        }

        // Escrevendo de outra forma...

        Console.WriteLine("\n\nComparando resultados escritos de outra forma:");

        investimento = 1000;
        for (int i = 0 ; i < 12; i++) 
        {
            investimento *= 1.005;

            Console.WriteLine("No mês " + (i + 1) + " você tem " + investimento);
        }

        Console.WriteLine("Tecle [ENTER] para fechar...");
        Console.ReadLine();
    }
}