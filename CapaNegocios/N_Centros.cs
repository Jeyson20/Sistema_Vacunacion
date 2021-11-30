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

        public List<E_Centros> ListadoCentros(string buscar)
        {

            return (List<E_Centros>)objDato.ListarCentros(buscar);

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
