using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Pacientes
    {
        private int _idpaciente;
        private string _cedula;
        private string _nombre;
        private string _apellido;
        private DateTime _fnacimiento;
        private string _sexo;
        private string _direccion;

        public int Idpaciente { get => _idpaciente; set => _idpaciente = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime Fnacimiento { get => _fnacimiento; set => _fnacimiento = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
