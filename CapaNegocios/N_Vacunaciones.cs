using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_Vacunaciones
    {
        D_Vacunaciones objDato = new D_Vacunaciones();
        public DataTable ListadoVacunaciones()
        {

            return objDato.ListarVacunaciones();

        }

        public void InsertandoVacunacion(E_Vacunaciones vacunaciones)
        {
            objDato.InsertarVacunacion(vacunaciones);
        }


        public void EditandoVacunas(E_Vacunaciones vacunaciones)
        {
            objDato.Editarvacunacion(vacunaciones);
        }
    }
}
