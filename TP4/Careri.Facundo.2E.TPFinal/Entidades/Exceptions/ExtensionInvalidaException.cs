using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExtensionInvalidaException:Exception
    {
        public ExtensionInvalidaException(string mensaje): base(mensaje)
        {

        }
    }
}
