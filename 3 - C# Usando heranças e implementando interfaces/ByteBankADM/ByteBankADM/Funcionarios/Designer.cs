using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Designer : Funcionario
    {
        // Foco em :base(variavel)
        public Designer(string cpf) : base(cpf, 3000)
        {
        }

        // Foco em override
        public override double GetBonificacao()
        {
            // Foco em base
            return this.Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

    }
}
