using ByteBankADM.Funcionarios;
using ByteBankADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Login(IAutenticavel autenticavel, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Usuário reconhecido. Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
