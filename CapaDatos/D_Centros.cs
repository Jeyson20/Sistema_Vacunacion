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

        public object ListarCentros(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("P_BUSCAR_CENTRO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Centros> Listar = new List<E_Centros>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Centros
                {
                    Cen_Codigo = LeerFilas.GetInt32(0),
                    Cen_Provincia=  LeerFilas.GetInt32(1),
                    Cen_CantidadLotes = LeerFilas.GetDecimal(2),
                    Cen_Descripcion = LeerFilas.GetString(3),
                    Cen_Direccion = LeerFilas.GetString(4),
                });

            }
            conexion.Close();
            LeerFilas.Close();


            return Listar;
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
            cmd.Parameters.AddWithValue("@CANTIDAD", centros.Cen_CantidadLotes);
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
            cmd.Parameters.AddWithValue("@CANTIDAD", centros.Cen_CantidadLotes);
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
