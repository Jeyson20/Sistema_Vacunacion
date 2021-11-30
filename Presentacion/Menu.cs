using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form formActivado = null;

        private void AbrirFormularioWrapper(Form formHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(formHijo);
            Wrapper.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnVacunaciones_Click(object sender, EventArgs e)
        {
            //AbrirFormularioWrapper();
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            //AbrirFormularioWrapper();
        }

        private void Pacientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioWrapper(new Pacientes());
        }

        private void btnCentros_Click(object sender, EventArgs e)
        {
            AbrirFormularioWrapper(new Centros());
        }
    }
}
