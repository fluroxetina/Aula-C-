using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo21_Sealed_Exept
{
    public class DomainException : ApplicationException
    {
       public DomainException(string message) : base(message) { }

       
    }
}