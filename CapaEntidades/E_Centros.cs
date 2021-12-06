using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class E_Centros
    {
        private int _cen_Codigo;
        private int _cen_Provincia;
        private string _numero_Lotes;
        private decimal _cen_CantidadLotes;
        private DateTime _vencimiento;
        private string _cen_Descripcion;
        private string _cen_Direccion;

        public int Cen_Codigo { get => _cen_Codigo; set => _cen_Codigo = value; }
        public int Cen_Provincia { get => _cen_Provincia; set => _cen_Provincia = value; }
        public string Numero_Lotes { get => _numero_Lotes; set => _numero_Lotes = value; }
        public decimal Cen_CantidadLotes { get => _cen_CantidadLotes; set => _cen_CantidadLotes = value; }
        public DateTime Vencimiento { get => _vencimiento; set => _vencimiento = value; }
        public string Cen_Descripcion { get => _cen_Descripcion; set => _cen_Descripcion = value; }
        public string Cen_Direccion { get => _cen_Direccion; set => _cen_Direccion = value; }
    }
}
