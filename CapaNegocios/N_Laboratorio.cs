using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_Laboratorio
    {
        D_Laboratorio objDato = new D_Laboratorio();

        public DataTable ListadoLabo()
        {

            return objDato.ListarLaboratorios();

        }
    }
}
