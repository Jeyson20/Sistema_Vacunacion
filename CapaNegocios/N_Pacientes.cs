
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaNegocios
{
    public class N_Pacientes
    {
        D_Pacientes objDato = new D_Pacientes();
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


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
        public string ExisteCedula(string paciente)
        {

            string emp = "";
            string query = "SELECT Pac_Cedula FROM Pacientes Where Pac_Cedula = @cedula";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@cedula", paciente);
                conexion.Open();

                emp = cmd.ExecuteScalar().ToString();

            }
            catch (Exception)
            {

                conexion.Close();
            }
            return emp;
        }
    }
}
