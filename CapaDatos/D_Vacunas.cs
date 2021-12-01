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
    public class D_Vacunas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarVacunas()
        {
            DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader;
            SqlCommand cmd = new SqlCommand("P_BUSCAR_VACUNA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            sqlDataReader = cmd.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            conexion.Close();
            return dataTable;
        }



        public void InsertarVacunas(E_Vacunas vacunas)
        {

            SqlCommand cmd = new SqlCommand("P_INSERTAR_VACUNA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@LABORATORIO", vacunas.V_Laboratorio);
            cmd.Parameters.AddWithValue("@MARCA", vacunas.V_Marca);
            cmd.Parameters.AddWithValue("@EXPIRACION", vacunas.V_Expiracion);
            cmd.Parameters.AddWithValue("@LOTE", vacunas.V_Lote);
            cmd.Parameters.AddWithValue("@CANTIDAD", vacunas.V_Cantidad);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public void EditarVacuna(E_Vacunas vacunas)
        {
            SqlCommand cmd = new SqlCommand("P_EDITAR_VACUNAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@LABORATORIO", vacunas.V_Laboratorio);
            cmd.Parameters.AddWithValue("@MARCA", vacunas.V_Marca);
            cmd.Parameters.AddWithValue("@EXPIRACION", vacunas.V_Expiracion);
            cmd.Parameters.AddWithValue("@LOTE", vacunas.V_Lote);
            cmd.Parameters.AddWithValue("@CANTIDAD", vacunas.V_Cantidad);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public void EliminarVacuna(E_Vacunas vacunas)
        {
            SqlCommand cmd = new SqlCommand("P_ELIMINAR_VACUNA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", vacunas.V_Codigo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
