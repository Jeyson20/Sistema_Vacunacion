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
    public partial class Vacunas : Form
    {
        private bool Editarse = false;
        E_Vacunas ObjEntidad = new E_Vacunas();
        N_Vacunas ObjNegocio = new N_Vacunas();
        public Vacunas()
        {
            InitializeComponent();
            mostrarBuscarTabla();
            mostrarLaboratorios();
        }

        public void mostrarBuscarTabla()
        {
            tablacentros.DataSource = ObjNegocio.ListadoVacunas();
        }
        public void mostrarLaboratorios()
        {
            N_Laboratorio objnegocio = new N_Laboratorio();
            cmbLaboratorio.DataSource = objnegocio.ListadoLabo();
            cmbLaboratorio.ValueMember = "Lab_Codigo";
            cmbLaboratorio.DisplayMember = "Lab_Descripcion";
        }

        private void Limpiarcajas()
        {
            Editarse = false;
            txtId.Text = "";
            cmbLaboratorio.Text = "";
            txtMarca.Text = "";
            dateTimePicker1.Text = "";
            txtLote.Text = "";
            txtCantidad.Text = "";
            cmbLaboratorio.Focus();

        }

        private void Vacunas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vacunacionDataSet.P_BUSCAR_VACUNA' table. You can move, or remove it, as needed.
            this.p_BUSCAR_VACUNATableAdapter.Fill(this.vacunacionDataSet.P_BUSCAR_VACUNA);
            mostrarBuscarTabla();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    ObjEntidad.V_Laboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue);
                    ObjEntidad.V_Marca = txtMarca.Text;
                    ObjEntidad.V_Expiracion = Convert.ToDateTime(dateTimePicker1.Text);
                    ObjEntidad.V_Lote = txtLote.Text;
                    ObjEntidad.V_Cantidad = Convert.ToDecimal(txtCantidad.Text);

                    ObjNegocio.InsertandoVacunas(ObjEntidad);
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
                    ObjEntidad.V_Codigo = Convert.ToInt32(txtId.Text);
                    ObjEntidad.V_Laboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue.ToString());
                    ObjEntidad.V_Marca = txtMarca.Text;
                    ObjEntidad.V_Expiracion = Convert.ToDateTime(dateTimePicker1.Text);
                    ObjEntidad.V_Lote = txtLote.Text;
                    ObjEntidad.V_Cantidad = Convert.ToDecimal(txtCantidad.Text);

                    ObjNegocio.EditandoVacunas(ObjEntidad);

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
                cmbLaboratorio.Text = tablacentros.CurrentRow.Cells[1].Value.ToString();
                txtMarca.Text = tablacentros.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(tablacentros.CurrentRow.Cells[3].Value.ToString());
                txtLote.Text = tablacentros.CurrentRow.Cells[4].Value.ToString();
                txtCantidad.Text = tablacentros.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablacentros.SelectedRows.Count > 0)
            {
                ObjEntidad.V_Codigo = Convert.ToInt32(tablacentros.CurrentRow.Cells[0].Value.ToString());
                ObjNegocio.EliminandoVacunas(ObjEntidad);

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
            Form reporte = new ReportesVacunas();
            reporte.Show();
        }
    }
}
