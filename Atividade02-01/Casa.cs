using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01
{
    public class Casa : Edificacao
{
        public bool Condominio { get; set; }

        public Casa(bool condominio, double metragemTotal, string endereco, Engenheiro responsavel ): base(metragemTotal, endereco, responsavel)
        {
            Condominio = condominio;
        }

        public override string DescricaoDoImovel()
        {
            if (Condominio == true)
            {
                return $"Metragem total de {this.MetragemTotal}m2  \nO endereco do apartamento é {this.Endereco} ";
            }
            else
            {
                return "Casa sem condominio";
            }
        }
    }
}