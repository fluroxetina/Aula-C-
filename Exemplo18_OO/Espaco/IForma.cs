using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public interface IForma
    {
        double CalcualrArea();

        double CalcularPerimetro();

        void ExibirInfo()
        {
            System.Console.WriteLine("Area" + CalcualrArea());
            System.Console.WriteLine("Perimetro" + CalcularPerimetro());

        }
    }
}

// Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Exemplo18_OO", "Exemplo18_OO\Exemplo18_OO.csproj", "{9EE5230A-24E3-41FF-9A4C-074A6F2B08FE}"
// EndProject