﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public  class CENTS
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarCentros()
        {
            DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader;
            SqlCommand cmd = new SqlCommand("P_Listar_CENTRO", conexion);
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
