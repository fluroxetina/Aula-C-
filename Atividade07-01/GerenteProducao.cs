using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07_01
{
    public class GerenteProducao : Empregado, IGerente
    {
        public GerenteProducao(string nome,double salario, int licencasPremioRecebidas) : base( nome,salario, licencasPremioRecebidas){}

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