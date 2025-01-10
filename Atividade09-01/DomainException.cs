using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade09_01
{
    public class DomainException : ApplicationException
    {
       public DomainException(string message) : base(message) { }
   
    }
}