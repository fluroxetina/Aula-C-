using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public interface IPagamento
    {
        void RealizarPagamento(double valor);
        void ExibirComprovante();
        
    }
}