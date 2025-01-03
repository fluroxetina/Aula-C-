using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01._1
{
    public class Animalia : Taxonomia
    {
        public Animalia(string reino, string filo, string classe, string ordem, string familia, string genero, string especie) : base("Animalia", filo, classe, ordem, familia, genero, especie)
        {
        }

        public override string ObterDescricao()
        {
            return $"{this.Reino} \n{this.Filo} \n{this.Classe} \n{this.Ordem} \n{this.Familia} \n{this.Genero} \n{this.Especie}";
        }
    }
}