using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;

namespace CapaPresentacion.Centros
{
    public partial class AddCentros : Form
    {
        private bool Editarse = false;
        public int? id;
        E_Centros ObjEntidad = new E_Centros();
        N_Centros ObjNegocio = new N_Centros();
        public AddCentros(int? id =null)
        {
            InitializeComponent();
            this.id = id;
            CargarDatos();
        }

        public void CargarDatos()
        {
            ObjEntidad.Cen_Provincia = Convert.ToInt32(txtProvincia.Text);
            ObjEntidad.Cen_CantidadLotes = Convert.ToInt32(txtCantidad.Text);
            ObjEntidad.Cen_Descripcion = txtDescripcion.Text;
            ObjEntidad.Cen_Direccion = txtDireccion.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                ObjEntidad.Cen_Provincia = Convert.ToInt32(txtProvincia.Text);
                ObjEntidad.Cen_CantidadLotes = Convert.ToInt32(txtCantidad.Text);
                ObjEntidad.Cen_Descripcion = txtDescripcion.Text;
                ObjEntidad.Cen_Direccion = txtDireccion.Text;

                ObjNegocio.InsertandoCentros(ObjEntidad);
                this.Close();
                MessageBox.Show("Se ha Guardado el registro");



            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el registro" + ex);
            }
        }


    }
}
