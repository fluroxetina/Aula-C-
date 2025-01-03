using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01._1
{
    public class HomoSapiens : Animalia
    {
        public HomoSapiens() : base("Animalia", "Chordata", "Mammalia", "Primates", "Homo", "Homo sapiens", "Homo sapiens")
        {
        }

        public override string ObterDescricao() 
        {
            return $"{this.Reino} \n{this.Filo} \n{this.Classe} \n{this.Ordem} \n{this.Familia} \n{this.Genero} \n{this.Especie}";
        }
    }
}