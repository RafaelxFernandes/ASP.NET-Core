using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        // Foco em :base(variavel)
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        // Foco em override
        public override double GetBonificacao()
        {
            // Foco em base
            return this.Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

    }
}
