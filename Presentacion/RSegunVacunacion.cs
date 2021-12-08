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
    public partial class RSegunVacunacion : Form
    {
        public RSegunVacunacion()
        {
            InitializeComponent();
        }

        private void RSegunVacunacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VacunacionDataSet1.P_PRIMERA' table. You can move, or remove it, as needed.
            this.P_PRIMERATableAdapter.Fill(this.VacunacionDataSet1.P_PRIMERA);
            // TODO: This line of code loads data into the 'VacunacionDataSet1.P_SEGUNDA' table. You can move, or remove it, as needed.
            this.P_SEGUNDATableAdapter.Fill(this.VacunacionDataSet1.P_SEGUNDA);
            // TODO: This line of code loads data into the 'VacunacionDataSet1.P_TERCERA' table. You can move, or remove it, as needed.
            this.P_TERCERATableAdapter.Fill(this.VacunacionDataSet1.P_TERCERA);

            this.reportViewer1.RefreshReport();
        }
    }
}
