using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01
{
    public class Predio : Edificacao
    {
        private string Nome { get; set; }
        private int NumAndares { get; set; }
        private int ApPorAndar { get; set; }
        public Predio(string nome, int numAndares, int apPorAndar, string endereco, Engenheiro responsavel,  double metragem) : base(metragem, endereco, responsavel )
        {
            this.Nome = nome;
            this.NumAndares = numAndares;
            this.ApPorAndar = apPorAndar;
        }
    
        public override string DescricaoDoImovel()
        {
            return $"Predio {this.Nome} \nCom area total de {this.MetragemTotal}m2 \nCom {this.NumAndares} andares \nCom {this.ApPorAndar} apartamentos por andar \nO endereco do apartamento eh {this.Endereco}";
        }

        
        public virtual bool CadastrarUnidade(UnidadeResidencial NovaUnidade)
        {
            if(NovaUnidade != null)
            {
                this.Unidade.Add(NovaUnidade);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}