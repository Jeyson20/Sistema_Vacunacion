using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Vacunas
    {
        private int _v_Codigo;

        private int _v_Laboratorio;

        private string _v_Marca;

        private DateTime _v_Expiracion;

        private string _v_Lote;

        private decimal? _v_Cantidad;

        public int V_Codigo { get => _v_Codigo; set => _v_Codigo = value; }
        public int V_Laboratorio { get => _v_Laboratorio; set => _v_Laboratorio = value; }
        public string V_Marca { get => _v_Marca; set => _v_Marca = value; }
        public DateTime V_Expiracion { get => _v_Expiracion; set => _v_Expiracion = value; }
        public string V_Lote { get => _v_Lote; set => _v_Lote = value; }
        public decimal? V_Cantidad { get => _v_Cantidad; set => _v_Cantidad = value; }
    }
}
