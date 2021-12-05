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
   public class D_Centros
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarCentros()
        {
            DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader;
            SqlCommand cmd = new SqlCommand("P_BUSCAR_CENTRO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            sqlDataReader = cmd.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            conexion.Close();
            return dataTable;
        }

        public DataTable ListarC(string buscar)
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("P_BUSCAR_PROVINCIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.Close();
            return tabla;

        }

        

        public void InsertarCentros(E_Centros centros)
        {

            SqlCommand cmd = new SqlCommand("P_INSERTAR_CENTRO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@PROVINCIA", centros.Cen_Provincia);
            cmd.Parameters.AddWithValue("@NUMEROLOTES", centros.Numero_Lotes);
            cmd.Parameters.AddWithValue("@CANTIDAD", centros.Cen_CantidadLotes);
            cmd.Parameters.AddWithValue("@VENCIMIENTO", centros.Vencimiento);
            cmd.Parameters.AddWithValue("@DESCRIPCION", centros.Cen_Descripcion);
            cmd.Parameters.AddWithValue("@DIRECCION", centros.Cen_Direccion);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public void EditarCentro(E_Centros centros)
        {
            SqlCommand cmd = new SqlCommand("P_EDITAR_CENTRO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID", centros.Cen_Codigo);
            cmd.Parameters.AddWithValue("@PROVINCIA", centros.Cen_Provincia);
            cmd.Parameters.AddWithValue("@NUMEROLOTES", centros.Numero_Lotes);
            cmd.Parameters.AddWithValue("@CANTIDAD", centros.Cen_CantidadLotes);
            cmd.Parameters.AddWithValue("@VENCIMIENTO", centros.Vencimiento);
            cmd.Parameters.AddWithValue("@DESCRIPCION", centros.Cen_Descripcion);
            cmd.Parameters.AddWithValue("@DIRECCION", centros.Cen_Direccion);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public void EliminarCentro(E_Centros centros)
        {
            SqlCommand cmd = new SqlCommand("P_ELIMINAR_CENTRO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", centros.Cen_Codigo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        
    }
}
