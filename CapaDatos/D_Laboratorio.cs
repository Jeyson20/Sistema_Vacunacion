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
    public class D_Laboratorio
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarLaboratorios()
        {
            DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader;
            SqlCommand cmd = new SqlCommand("P_BUSCAR_LABORATORIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            sqlDataReader = cmd.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            conexion.Close();
            return dataTable;
        }
    }
}
