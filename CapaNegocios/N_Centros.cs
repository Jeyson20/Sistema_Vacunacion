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
   public class N_Centros
    {
        D_Centros objDato = new D_Centros();

        public DataTable ListadoCentros()
        {

            return objDato.ListarCentros();

        }

        public void InsertandoCentros(E_Centros centros1)
        {
            objDato.InsertarCentros(centros1);
        }


        public void EditandoCentro(E_Centros centros)
        {
            objDato.EditarCentro(centros);
        }
        public void EliminandoCentros(E_Centros centros)
        {
            objDato.EliminarCentro(centros);
        }
    }
}
