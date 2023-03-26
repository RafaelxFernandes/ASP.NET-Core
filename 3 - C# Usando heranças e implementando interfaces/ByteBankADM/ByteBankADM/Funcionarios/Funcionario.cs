using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }

        // Foco em protected
        public double Salario { get; protected set; }

        // Foco em static e private set
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario) 
        {
            this.Cpf = cpf;
            this.Salario = salario;

            Console.WriteLine("Criando um funcionário...");
            TotalFuncionarios++;
        }

        // Foco em abstract
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}
