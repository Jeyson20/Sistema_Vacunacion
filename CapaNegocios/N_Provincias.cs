using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_Provincias
    {
        D_Provincias objDato = new D_Provincias();

        public DataTable ListadoProvincias()
        {

            return objDato.ListarPcentros();

        }
    }
}
