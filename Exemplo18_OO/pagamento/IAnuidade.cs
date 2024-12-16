using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public interface IAnuidade
    {
        DateTime Vencimento();
        double CalcularValorAnuidade();
    }
}