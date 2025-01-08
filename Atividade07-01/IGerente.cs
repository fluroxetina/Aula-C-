using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07_01
{
    public interface IGerente
    {
        public void Autorizar();

        public bool ConcederAumento();

        public bool AutorizarLicenca(Empregado empregado);
    }
}