using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_Vacunaciones
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
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
        public void EditcENTRO(E_Vacunaciones vacunaciones)
        {
            objDato.Resta(vacunaciones);
        }

        public string ExisteCedula(string paciente)
        {

            string emp = "";
            string query = "SELECT Vac_Dosis  FROM Vacunaciones inner join Pacientes on Vacunaciones.Vac_Paciente = Pacientes.Pac_Cedula " +
                             "Where Vacunaciones.Vac_Paciente = @paciente";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@paciente", paciente);
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
