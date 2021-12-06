using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Vacunaciones
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable ListarVacunaciones()
        {
            DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader;
            SqlCommand cmd = new SqlCommand("P_BUSCAR_VACUNACION", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            sqlDataReader = cmd.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            conexion.Close();
            return dataTable;
        }

        public void InsertarVacunacion(E_Vacunaciones vacunaciones)
        {

            SqlCommand cmd = new SqlCommand("P_INSERTAR_VACUNACION", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@PACIENTE", vacunaciones.Vac_Paciente);
            cmd.Parameters.AddWithValue("@CENTRO", vacunaciones.Vac_Centro);
            cmd.Parameters.AddWithValue("@VACUNA", vacunaciones.Vac_Vacuna);
            cmd.Parameters.AddWithValue("@DOSIS", vacunaciones.Vac_Dosis);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void Editarvacunacion(E_Vacunaciones vacunaciones)
        {
            SqlCommand cmd = new SqlCommand("P_EDITAR_VACUNACION", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID", vacunaciones.Vac_Codigo);
            cmd.Parameters.AddWithValue("@PACIENTE", vacunaciones.Vac_Paciente);
            cmd.Parameters.AddWithValue("@CENTRO", vacunaciones.Vac_Centro);
            cmd.Parameters.AddWithValue("@VACUNA", vacunaciones.Vac_Vacuna);
            cmd.Parameters.AddWithValue("@DOSIS", vacunaciones.Vac_Dosis);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
