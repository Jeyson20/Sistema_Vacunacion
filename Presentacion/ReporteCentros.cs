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
    public partial class ReporteCentros : Form
    {
        public ReporteCentros()
        {
            InitializeComponent();
        }

        private void ReporteCentros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VacunacionDataSet.CentrosVacunas' table. You can move, or remove it, as needed.
            this.CentrosVacunasTableAdapter.Fill(this.VacunacionDataSet.CentrosVacunas);

            this.reportViewer1.RefreshReport();
        }
    }
}
