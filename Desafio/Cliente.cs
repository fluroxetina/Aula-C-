using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }

        public string Telefone { get; set; }

        public abstract string ConsultarFidelidade();

        public Cliente()
        {
            Endereco = new Endereco();
        }

        public Cliente(string nome,string rua , string cidade, string estado, int cep ,string cpf, string telefone)
        {
            this.Nome = nome;
            this.Endereco = new Endereco(rua, cidade, estado, cep);
            this.Cpf = cpf;
            this.Telefone = telefone;
        }
    }

    public class ClienteGold : Cliente
    {

        public double Desconto { get; set; } 
        public override string ConsultarFidelidade()
        {
            return "Fidelidade Gold, tem descontro de 10%";
        }
    }

    public class ClientePlatinum : Cliente
    {
        public double Desconto { get; set; }

        public override string ConsultarFidelidade()
        {
            return "Fidelidade Platinum, tem desconto de 15%";
        }
    }


}