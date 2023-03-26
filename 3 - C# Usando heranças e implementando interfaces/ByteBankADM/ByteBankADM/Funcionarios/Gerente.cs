using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Gerente : FuncionarioAutenticavel
    {
        
        // Foco em :base(variavel)
        public Gerente(string cpf) : base(cpf, 4000)
        {
        }

        // Foco em override
        public override double GetBonificacao()
        {
            // Foco em base
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }        
    }
}
