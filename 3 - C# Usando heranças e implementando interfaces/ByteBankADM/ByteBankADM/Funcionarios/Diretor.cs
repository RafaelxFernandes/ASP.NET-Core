using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        // Foco em :base(variavel)
        public Diretor(string cpf):base(cpf, 5000)
        {
        }

        // Foco em override
        public override double GetBonificacao()
        {
            // Foco em base
            return this.Salario;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
