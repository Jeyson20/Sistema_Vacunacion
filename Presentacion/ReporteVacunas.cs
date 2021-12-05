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
    public partial class ReporteVacunas : Form
    {
        public ReporteVacunas()
        {
            InitializeComponent();
        }

        private void ReporteVacunas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VacunacionDataSet1.Vacunas' table. You can move, or remove it, as needed.
            this.VacunasTableAdapter.Fill(this.VacunacionDataSet1.Vacunas);

            this.reportViewer1.RefreshReport();
        }
    }
}
