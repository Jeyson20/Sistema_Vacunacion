using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Pacientes : Form
    {
        private bool Editarse = false;
        E_Pacientes ObjEntidad = new E_Pacientes();
        N_Pacientes ObjNegocio = new N_Pacientes();
        public Pacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vacunacionDataSet.Pacientes' table. You can move, or remove it, as needed.
            this.pacientesTableAdapter.Fill(this.vacunacionDataSet.Pacientes);

        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Pacientes objnegocio = new N_Pacientes();
            tablaPacientes.DataSource = objnegocio.ListadoPacientes(buscar);
        }
        private void Limpiarcajas()
        {
            Editarse = false;
            txtcedula.Text = "";
            textnombre.Text = "";
            txtapellido.Text = "";
            dateTimePicker1.Text = "";
            checkSexo.Text = "";
            txtdireccion.Text = "";
            txtcedula.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaPacientes.SelectedRows.Count > 0)
            {
                Editarse = true;
                txtcedula.Text = tablaPacientes.CurrentRow.Cells[1].Value.ToString();
                textnombre.Text = tablaPacientes.CurrentRow.Cells[2].Value.ToString();
                txtapellido.Text = tablaPacientes.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(tablaPacientes.CurrentRow.Cells[4].Value.ToString());
                checkSexo.Text = tablaPacientes.CurrentRow.Cells[5].Value.ToString();
                txtdireccion.Text = tablaPacientes.CurrentRow.Cells[6].Value.ToString();

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
                    ObjEntidad.Sexo = checkSexo.Text.ToUpper();
                    ObjEntidad.Direccion = txtdireccion.Text.ToUpper();
                    if (dateTimePicker1.Value.CompareTo(DateTime.Now) == 1)

                    {

                        MessageBox.Show("La fecha de nacimiento no puede ser mayor a la actual");

                    }
                    
                    else if (string.IsNullOrWhiteSpace(txtcedula.Text))
                    {
                        MessageBox.Show("La cedula es un campo obligatorio!");
                        txtcedula.Clear();

                    } else {
                        if (ObjNegocio.ExisteCedula(txtcedula.Text) == txtcedula.Text)
                        {
                            MessageBox.Show("Ya existe esta cedula!!");
                            this.pacientesTableAdapter.Fill(this.vacunacionDataSet.Pacientes);


                        }
                        else
                        {
                            ObjNegocio.InsertandoPacientes(ObjEntidad);

                            MessageBox.Show("Se ha Guardado el registro");
                            Limpiarcajas();
                        }
                       
                    }
                    
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
                    txtcedula.ReadOnly = true;
                    ObjEntidad.Cedula = txtcedula.Text;
                    ObjEntidad.Nombre = textnombre.Text;
                    ObjEntidad.Apellido = txtapellido.Text;
                    ObjEntidad.Fnacimiento = Convert.ToDateTime(dateTimePicker1.Text);
                    ObjEntidad.Sexo = checkSexo.Text;
                    ObjEntidad.Direccion = txtdireccion.Text;

                    ObjNegocio.EditandoPaciente(ObjEntidad);

                    MessageBox.Show("Se ha Editado el registro");
                    Limpiarcajas();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form reporte = new ReportesPacientes();
            reporte.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiarcajas();
        }

       
        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
