using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07_01
{
    public class GerenteVendas : Vendedor, IGerente
    {
        protected Regiao regiao;

        public GerenteVendas(string nome, double salario,int licencasPremioRecebidas, double comissao,Regiao regiao) : base(nome, salario ,licencasPremioRecebidas,comissao )
        {
            this.regiao = regiao;
        }

        public void Autorizar()
        {
            System.Console.WriteLine("Autorizado");
        }

        public bool ConcederAumento()
        {
            return true;
        }

        public bool AutorizarLicenca(Empregado empregado)
        {
            return true;
        }
    }
}