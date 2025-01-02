using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01
{
    public abstract class Edificacao
    {
        protected  double MetragemTotal {get; set;}
        protected  string Endereco {get; set;}
        protected  Engenheiro Responsavel {get; set;}  
        protected List<UnidadeResidencial> Unidade = new List<UnidadeResidencial>();

        public Edificacao(double metragemTotal, string endereco, Engenheiro responsavel)
        {
            this.MetragemTotal = metragemTotal;
            this.Endereco = endereco;
            this.Responsavel = responsavel;
           
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
        public abstract string DescricaoDoImovel();

        public void SetUnidade(UnidadeResidencial unidade)
        {
            this.Unidade.Add(unidade);
        }

        public List<UnidadeResidencial> GetUnidade()
        {
            return this.Unidade;
        }
        
    }
}