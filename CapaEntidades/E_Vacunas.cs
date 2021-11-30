using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Vacunas
    {
        public int V_Codigo { get; set; }

        public int V_Laboratorio { get; set; }

        public string V_Marca { get; set; }

        public DateTime V_Expiracion { get; set; }

        public string V_Lote { get; set; }

        public decimal? V_Cantidad { get; set; }

    }
}
