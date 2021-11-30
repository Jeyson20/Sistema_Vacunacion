using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Vacunaciones
    {
        public int Vac_Codigo { get; set; }

        public string Vac_Paciente { get; set; }

        public int Vac_Centro { get; set; }

        public int Vac_Vacuna { get; set; }

        public int Vac_Dosis { get; set; }

        public DateTime Vac_Fecha { get; set; }

    }
}