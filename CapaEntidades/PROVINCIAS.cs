using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Provincias
    {
        private int _prv_Codigo;
        private string _prv_Descripcion;

        public int Prv_Codigo { get => _prv_Codigo; set => _prv_Codigo = value; }
        public string Prv_Descripcion { get => _prv_Descripcion; set => _prv_Descripcion = value; }
    }
}