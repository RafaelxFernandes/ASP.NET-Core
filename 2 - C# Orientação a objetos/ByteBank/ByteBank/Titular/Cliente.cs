using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        // prop
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
        
        // ctor
        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
        }
    }
}
