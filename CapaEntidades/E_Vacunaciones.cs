using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Vacunaciones
    {
        private int _vac_Codigo;

        private string _vac_Paciente;

        private int _vac_Centro;

        private int _vac_Vacuna;

        private int _vac_Dosis;

        private DateTime _vac_Fecha;

        public int Vac_Codigo { get => _vac_Codigo; set => _vac_Codigo = value; }
        public string Vac_Paciente { get => _vac_Paciente; set => _vac_Paciente = value; }
        public int Vac_Centro { get => _vac_Centro; set => _vac_Centro = value; }
        public int Vac_Vacuna { get => _vac_Vacuna; set => _vac_Vacuna = value; }
        public int Vac_Dosis { get => _vac_Dosis; set => _vac_Dosis = value; }
        public DateTime Vac_Fecha { get => _vac_Fecha; set => _vac_Fecha = value; }
    }
}