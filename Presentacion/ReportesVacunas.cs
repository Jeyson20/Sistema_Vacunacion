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
    public partial class ReportesVacunas : Form
    {
        public ReportesVacunas()
        {
            InitializeComponent();
        }

        private void ReportesVacunas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VacunacionDataSet.P_BUSCAR_VACUNA' table. You can move, or remove it, as needed.
            this.P_BUSCAR_VACUNATableAdapter.Fill(this.VacunacionDataSet.P_BUSCAR_VACUNA);

            this.reportViewer1.RefreshReport();
        }
    }
}
