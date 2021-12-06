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
    public partial class ReportesCentros : Form
    {
        public ReportesCentros()
        {
            InitializeComponent();
        }

        private void ReportesCentros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VacunacionDataSet.P_BUSCAR_CENTRO' table. You can move, or remove it, as needed.
            this.P_BUSCAR_CENTROTableAdapter.Fill(this.VacunacionDataSet.P_BUSCAR_CENTRO);

            this.reportViewer1.RefreshReport();
        }
    }
}
