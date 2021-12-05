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
        private string _Numero_Lotes;
        private decimal _Cen_CantidadLotes;
        private DateTime _Vencimiento;
        private string _Cen_Descripcion;

        private string _Cen_Direccion;

        public int Cen_Codigo { get => _Cen_Codigo; set => _Cen_Codigo = value; }
        public int Cen_Provincia { get => _Cen_Provincia; set => _Cen_Provincia = value; }
        public string Numero_Lotes { get => _Numero_Lotes; set => _Numero_Lotes = value; }
        public decimal Cen_CantidadLotes { get => _Cen_CantidadLotes; set => _Cen_CantidadLotes = value; }
        public DateTime Vencimiento { get => _Vencimiento; set => _Vencimiento = value; }
        public string Cen_Descripcion { get => _Cen_Descripcion; set => _Cen_Descripcion = value; }
        public string Cen_Direccion { get => _Cen_Direccion; set => _Cen_Direccion = value; }
    }
}
