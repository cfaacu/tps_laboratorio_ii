using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListVaciaException:Exception
    {
        public ListVaciaException(string mensaje):base(mensaje)
        {

        }
    }
}
