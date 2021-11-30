using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
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

        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {

        }

        private void Pacientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioWrapper(new FrmPacientes());
        }

        private void btnCentros_Click(object sender, EventArgs e)
        {
            AbrirFormularioWrapper(new FrmCentros());
        }
        bool vai = false;
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;

        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai ==true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }


    }
}
