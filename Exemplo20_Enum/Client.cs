using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo20_Enum
{
    public class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Client(string nome, string email, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Email = email;
            this.DataNascimento = dataNascimento;
        }
        
    }
}