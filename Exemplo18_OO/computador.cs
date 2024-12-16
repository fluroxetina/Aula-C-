using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class computador
    {
        public Processador processador;

        public computador()
        {
            processador = new Processador();
        }

        void iniciar()
        {
            System.Console.WriteLine("Processando...");
            processador.processar();
        }
    }
}

