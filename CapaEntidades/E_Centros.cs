using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class E_Centros
    {
        private int _Cen_Codigo;

        private int _Cen_Provincia;

        private decimal _Cen_CantidadLotes;

        private string _Cen_Descripcion;

        private string _Cen_Direccion;
        private string _buscar;

        public int Cen_Codigo { get => _Cen_Codigo; set => _Cen_Codigo = value; }
        public int Cen_Provincia { get => _Cen_Provincia; set => _Cen_Provincia = value; }
        public decimal Cen_CantidadLotes { get => _Cen_CantidadLotes; set => _Cen_CantidadLotes = value; }
        public string Cen_Descripcion { get => _Cen_Descripcion; set => _Cen_Descripcion = value; }
        public string Cen_Direccion { get => _Cen_Direccion; set => _Cen_Direccion = value; }
        public string Buscar { get => _buscar; set => _buscar = value; }
    }
}
