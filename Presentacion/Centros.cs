using CapaEntidades;
using CapaNegocios;
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
    public partial class Centros : Form
    {
        private bool Editarse = false;
        E_Centros ObjEntidad = new E_Centros();
        N_Centros ObjNegocio = new N_Centros();
        public Centros()
        {
            InitializeComponent();
           
            mostrarBuscarTabla();
            mostrarProvincias();
        }
        public void mostrarBuscarTabla()
        {
            N_Centros objnegocio = new N_Centros();
            tablacentros.DataSource = objnegocio.ListadoCentros();
        }

        public void mostrarProvincias()
        {
            N_Provincias objnegocio = new N_Provincias();
            cmbProvincias.DataSource = objnegocio.ListadoProvincias();
            cmbProvincias.ValueMember = "Prv_Codigo";
            cmbProvincias.DisplayMember = "Prv_Descripcion";
        }

        private void Limpiarcajas()
        {
            Editarse = false;
            txtId.Text = "";
            cmbProvincias.Text = "";
            txtLote.Text = "";
            txtCantidad.Text = "";
            dateTimePicker1.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            cmbProvincias.Focus();

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    ObjEntidad.Cen_Provincia = Convert.ToInt32(cmbProvincias.SelectedValue);
                    ObjEntidad.Numero_Lotes = txtLote.Text;
                    ObjEntidad.Cen_CantidadLotes = Convert.ToInt32(txtCantidad.Text);
                    ObjEntidad.Vencimiento = Convert.ToDateTime(dateTimePicker1.Text);
                    ObjEntidad.Cen_Descripcion = txtDescripcion.Text;
                    ObjEntidad.Cen_Direccion = txtDireccion.Text;

                    ObjNegocio.InsertandoCentros(ObjEntidad);
                    MessageBox.Show("Se ha Guardado el registro");
                    mostrarProvincias();
                    mostrarBuscarTabla();
                    Limpiarcajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
            if (Editarse == true)
            {
                try
                {
                    ObjEntidad.Cen_Codigo = Convert.ToInt32(txtId.Text);
                    ObjEntidad.Cen_Provincia = Convert.ToInt32(cmbProvincias.SelectedValue.ToString());
                    ObjEntidad.Numero_Lotes = txtLote.Text;
                    ObjEntidad.Cen_CantidadLotes = Convert.ToInt32(txtCantidad.Text);
                    ObjEntidad.Vencimiento = Convert.ToDateTime(dateTimePicker1.Text);
                    ObjEntidad.Cen_Descripcion = txtDescripcion.Text;
                    ObjEntidad.Cen_Direccion = txtDireccion.Text;

                    ObjNegocio.EditandoCentro(ObjEntidad);

                    MessageBox.Show("Se ha Editado el registro");
                    mostrarBuscarTabla();
                    mostrarProvincias();
                    Limpiarcajas();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablacentros.SelectedRows.Count > 0)
            {
                Editarse = true;
                txtId.Text = tablacentros.CurrentRow.Cells[0].Value.ToString();
                cmbProvincias.Text = tablacentros.CurrentRow.Cells[1].Value.ToString();
                txtLote.Text = tablacentros.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = tablacentros.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(tablacentros.CurrentRow.Cells[4].Value.ToString());
                txtDescripcion.Text = tablacentros.CurrentRow.Cells[5].Value.ToString();
                txtDireccion.Text = tablacentros.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desae editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Limpiarcajas();

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form reporte = new ReportesCentros();
            reporte.Show();
        }

        private void Centros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vacunacionDataSet.P_BUSCAR_CENTRO' table. You can move, or remove it, as needed.
            this.p_BUSCAR_CENTROTableAdapter.Fill(this.vacunacionDataSet.P_BUSCAR_CENTRO);
            mostrarBuscarTabla();


        }

  
    }
}
