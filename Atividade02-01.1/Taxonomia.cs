using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01._1
{
    public abstract class Taxonomia
    {
        protected string Reino;
        protected string Filo;
        protected string Classe;
        protected string Ordem;
        protected string Familia;
        protected string Genero;
        protected string Especie;

        public Taxonomia(string reino, string filo, string classe, string ordem, string familia, string genero, string especie)
        {
            this.Reino = reino;
            this.Filo = filo;
            this.Classe = classe;
            this.Ordem = ordem;
            this.Familia = familia;
            this.Genero = genero;
            this.Especie = especie;
        }

        public abstract string ObterDescricao();
    }
}