using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CENT
    {

        CENTS objDato = new CENTS();

        public DataTable listado()
        {

            return objDato.ListarCentros();
        }
    }
}
