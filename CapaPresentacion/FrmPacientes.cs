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

namespace CapaPresentacion
{
    public partial class FrmPacientes : Form
    {
        private string id;
        private bool Editarse = false;
        E_Pacientes ObjEntidad = new E_Pacientes();
        N_Pacientes ObjNegocio = new N_Pacientes();

        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }
        public void accionesTabla()
        {
            TablaPacintes.Columns[0].Visible = false;
            TablaPacintes.Columns[1].Width = 80;
            TablaPacintes.Columns[2].Width = 80;
            TablaPacintes.Columns[3].Width = 80;
            TablaPacintes.Columns[4].Width = 120;
            TablaPacintes.Columns[5].Width = 60;
            TablaPacintes.Columns[6].Width = 80;

            TablaPacintes.ClearSelection();

        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Pacientes objnegocio = new N_Pacientes();
            TablaPacintes.DataSource = objnegocio.ListadoPacientes(buscar);
        }

        private void cajabuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(cajabuscarPaciente.Text);
        }

        private void Limpiarcajas()
        {
            Editarse = false;
            txtcedula.Text = "";
            textnombre.Text = "";
            txtapellido.Text = "";
            dateTimePicker1.Text = "";
            txtsexo.Text = "";
            txtdireccion.Text = "";
            txtcedula.Focus();


        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TablaPacintes.SelectedRows.Count > 0)
            {
                Editarse = true;
                id = TablaPacintes.CurrentRow.Cells[0].Value.ToString();
                txtcedula.Text = TablaPacintes.CurrentRow.Cells[1].Value.ToString();
                textnombre.Text = TablaPacintes.CurrentRow.Cells[2].Value.ToString();
                txtapellido.Text = TablaPacintes.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(TablaPacintes.CurrentRow.Cells[4].Value.ToString());
                txtsexo.Text = TablaPacintes.CurrentRow.Cells[5].Value.ToString();
                txtdireccion.Text = TablaPacintes.CurrentRow.Cells[6].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desae editar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {

                    ObjEntidad.Cedula = txtcedula.Text.ToUpper();
                    ObjEntidad.Nombre = textnombre.Text.ToUpper();
                    ObjEntidad.Apellido = txtapellido.Text.ToUpper();
                    ObjEntidad.Fnacimiento = Convert.ToDateTime(dateTimePicker1.Text.ToUpper());
                    ObjEntidad.Sexo = txtsexo.Text.ToUpper();
                    ObjEntidad.Direccion = txtdireccion.Text.ToUpper();

                    ObjNegocio.InsertandoPacientes(ObjEntidad);

                    MessageBox.Show("Se ha Guardado el registro");
                    mostrarBuscarTabla("");
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
                    ObjEntidad.Cedula = txtcedula.Text.ToUpper();
                    ObjEntidad.Nombre = textnombre.Text.ToUpper();
                    ObjEntidad.Apellido = txtapellido.Text.ToUpper();
                    ObjEntidad.Fnacimiento = Convert.ToDateTime(dateTimePicker1.Text.ToUpper());
                    ObjEntidad.Sexo = txtsexo.Text.ToUpper();
                    ObjEntidad.Direccion = txtdireccion.Text.ToUpper();

                    ObjNegocio.EditandoPaciente(ObjEntidad);

                    MessageBox.Show("Se ha Editado el registro");
                    mostrarBuscarTabla("");
                    Limpiarcajas();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaPacintes.SelectedRows.Count > 0)
            {
                ObjEntidad.Cedula = TablaPacintes.CurrentRow.Cells[1].Value.ToString();
                ObjNegocio.EliminandoPaciente(ObjEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea Eliminar");
            }
        }

    }
}

