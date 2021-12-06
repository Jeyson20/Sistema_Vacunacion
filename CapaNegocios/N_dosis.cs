using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_dosis
    {
        D_Dosis objDato = new D_Dosis();

        public DataTable ListadoDosis()
        {

            return objDato.ListarDosis();

        }
    }
}
