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
    public class N_Vacunas
    {

        D_Vacunas objDato = new D_Vacunas();

        public DataTable ListadoVacunas()
        {

            return objDato.ListarVacunas();

        }

        public void InsertandoVacunas(E_Vacunas vacunas)
        {
            objDato.InsertarVacunas(vacunas);
        }


        public void EditandoVacunas(E_Vacunas vacunas)
        {
            objDato.EditarVacuna(vacunas);
        }
        public void EliminandoVacunas(E_Vacunas vacunas)
        {
            objDato.EliminarVacuna(vacunas);
        }
    }
}
