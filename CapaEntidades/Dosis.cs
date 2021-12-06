using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Dosis
    {
        private int _id_Dosis;

        private string _descripcion;

        public int Id_Dosis { get => _id_Dosis; set => _id_Dosis = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
