using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class N_Pacientes
    {
        Db_Vacunacion objDato = new Db_Vacunacion();

        public List<E_Pacientes>ListadoPacientes(string buscar)
        {

            return (List<E_Pacientes>)objDato.ListarPacientes(buscar);

        }

        public void InsertandoPacientes(E_Pacientes pacientes)
        {
            objDato.InsertarPaciente(pacientes);
        }

        public void EditandoPaciente(E_Pacientes pacientes)
        {
            objDato.EditarPaciente(pacientes);
        }
        public void EliminandoPaciente(E_Pacientes pacientes)
        {
            objDato.EliminarPaciente(pacientes);
        }
    }
}
