using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Laboratorio
    {
        private int _lab_Codigo;

        private string _lab_Descripcion;

        public int Lab_Codigo { get => _lab_Codigo; set => _lab_Codigo = value; }
        public string Lab_Descripcion { get => _lab_Descripcion; set => _lab_Descripcion = value; }
    }
}

