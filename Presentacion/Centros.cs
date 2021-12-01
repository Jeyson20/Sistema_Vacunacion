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
        }
        public void mostrarBuscarTabla()
        {
            N_Centros objnegocio = new N_Centros();
            tablacentros.DataSource = objnegocio.ListadoCentros();
        }

        private void Limpiarcajas()
        {
            Editarse = false;
            txtId.Text = "";
            txtProvincia.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Focus();

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    ObjEntidad.Cen_Provincia = Convert.ToInt32(txtProvincia.Text);
                    ObjEntidad.Cen_CantidadLotes = Convert.ToInt32(txtCantidad.Text);
                    ObjEntidad.Cen_Descripcion = txtDescripcion.Text;
                    ObjEntidad.Cen_Direccion = txtDireccion.Text;

                    ObjNegocio.InsertandoCentros(ObjEntidad);
                    MessageBox.Show("Se ha Guardado el registro");
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
                    ObjEntidad.Cen_Provincia = Convert.ToInt32(txtProvincia.Text);
                    ObjEntidad.Cen_CantidadLotes = Convert.ToInt32(txtCantidad.Text);
                    ObjEntidad.Cen_Descripcion = txtDescripcion.Text;
                    ObjEntidad.Cen_Direccion = txtDireccion.Text;

                    ObjNegocio.EditandoCentro(ObjEntidad);

                    MessageBox.Show("Se ha Editado el registro");
                    mostrarBuscarTabla();
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
                txtProvincia.Text = tablacentros.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text = tablacentros.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = tablacentros.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = tablacentros.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desae editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablacentros.SelectedRows.Count > 0)
            {
                ObjEntidad.Cen_Codigo = Convert.ToInt32(tablacentros.CurrentRow.Cells[0].Value.ToString());
                ObjNegocio.EliminandoCentros(ObjEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla();
                Limpiarcajas();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea Eliminar");
            }

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form reporte = new ReporteCentros();
            reporte.Show();
        }

        private void Centros_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla();


        }

  
    }
}
