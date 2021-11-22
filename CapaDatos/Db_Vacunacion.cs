using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class Db_Vacunacion
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public object ListarPacientes(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("P_BUSCAR_PACIENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR",buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Pacientes> Listar = new List<E_Pacientes>();

            while(LeerFilas.Read())
            {
                Listar.Add(new E_Pacientes
                {
                    Idpaciente = LeerFilas.GetInt32(0),
                    Cedula = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    Fnacimiento = LeerFilas.GetDateTime(4),
                    Sexo = LeerFilas.GetString(5),
                    Direccion = LeerFilas.GetString(6)
                });
  
            }
            conexion.Close();
            LeerFilas.Close();


            return Listar;
        }

        public void InsertarPaciente(E_Pacientes pacientes)
        {

            SqlCommand cmd = new SqlCommand("P_INSERTAR_PACIENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CEDULA", pacientes.Cedula);
            cmd.Parameters.AddWithValue("@NOMBRE", pacientes.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", pacientes.Apellido);
            cmd.Parameters.AddWithValue("@FNACIMIENTO", pacientes.Fnacimiento);
            cmd.Parameters.AddWithValue("@SEXO", pacientes.Sexo);
            cmd.Parameters.AddWithValue("@DIRECCION", pacientes.Direccion);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarPaciente(E_Pacientes pacientes)
        {
            SqlCommand cmd = new SqlCommand("P_EDITAR_PACIENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CEDULA", pacientes.Cedula);
            cmd.Parameters.AddWithValue("@NOMBRE", pacientes.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", pacientes.Apellido);
            cmd.Parameters.AddWithValue("@FNACIMIENTO", pacientes.Fnacimiento);
            cmd.Parameters.AddWithValue("@SEXO", pacientes.Sexo);
            cmd.Parameters.AddWithValue("@DIRECCION", pacientes.Direccion);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarPaciente(E_Pacientes pacientes)
        {
            SqlCommand cmd = new SqlCommand("P_ELIMINAR_PACIENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CEDULA", pacientes.Cedula);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
