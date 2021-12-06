using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class VACU
    {
        VACUs objDato = new VACUs();

        public DataTable listado()
        {

            return objDato.ListarVacunas();
        }
    }

}