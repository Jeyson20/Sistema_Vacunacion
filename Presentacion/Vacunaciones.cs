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
    public partial class Vacunaciones : Form
    {
        N_Vacunaciones ObjNegocio = new N_Vacunaciones();
        private bool Editarse = false;
        E_Vacunaciones ObjEntidad = new E_Vacunaciones();
        public Vacunaciones()
        {
            InitializeComponent();
            mostrarTabla();
            mostrarCentros();
            mostrarDosis();
            mostrarPacientes("");
            mostrarVacunas();
        }

        public void mostrarTabla()
        {
            N_Vacunaciones objnegocio1 = new N_Vacunaciones();
            tablaVacunacion.DataSource = objnegocio1.ListadoVacunaciones();
        }

        public void mostrarPacientes(string buscar)
        {
            N_Pacientes objnegocio = new N_Pacientes();
            cmbPaciente.DataSource = objnegocio.ListadoPacientes(buscar);
            cmbPaciente.ValueMember = "Cedula";
            cmbPaciente.DisplayMember = "Nombre";
        }
        public void mostrarDosis()
        {
            N_dosis objnegocio = new N_dosis();
            cmbDosis.DataSource = objnegocio.ListadoDosis();
            cmbDosis.ValueMember = "Id_Dosis";
            cmbDosis.DisplayMember = "Descripcion";
        }
        public void mostrarVacunas()
        {
            VACU objnegocio = new VACU();
            cmbVacuna.DataSource = objnegocio.listado();
            cmbVacuna.ValueMember = "V_Codigo";
            cmbVacuna.DisplayMember ="V_Marca";

        }
        public void mostrarCentros()
        {
            CENT objnegocio = new CENT();
            cmbCentro.DataSource = objnegocio.listado();
            cmbCentro.ValueMember = "Cen_Codigo";
            cmbCentro.DisplayMember = "Cen_Descripcion";

        }

        private void Limpiarcajas()
        {
            Editarse = false;
            txtId.Text = "";
            cmbVacuna.Text = "";
            cmbPaciente.Text = "";
            cmbDosis.Text = "";
            cmbCentro.Text = "";
            cmbPaciente.Focus();
        }

        private void Vacunaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vacunacionDataSet.P_BUSCAR_VACUNACION' table. You can move, or remove it, as needed.
            this.p_BUSCAR_VACUNACIONTableAdapter.Fill(this.vacunacionDataSet.P_BUSCAR_VACUNACION);
            // TODO: This line of code loads data into the 'vacunacionDataSet2.P_BUSCAR_VACUNACION' table. You can move, or remove it, as needed.


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {

                    ObjEntidad.Vac_Paciente = cmbPaciente.SelectedValue.ToString();
                    ObjEntidad.Vac_Centro = Convert.ToInt32(cmbCentro.SelectedValue);
                    ObjEntidad.Vac_Vacuna = Convert.ToInt32(cmbVacuna.SelectedValue);
                    ObjEntidad.Vac_Dosis = Convert.ToInt32(cmbDosis.SelectedValue);

                        if (ObjNegocio.ExisteCedula(cmbPaciente.SelectedValue.ToString()) == cmbDosis.SelectedValue.ToString())
                        {
                            MessageBox.Show("Ya este paciente esta vacunado con esta dosis!!");

                        }
                        else
                        {
                        ObjNegocio.EditcENTRO(ObjEntidad);
                        ObjNegocio.InsertandoVacunacion(ObjEntidad);
                        MessageBox.Show("Se ha Guardado el registro");
                        mostrarTabla();
                        mostrarCentros();
                        mostrarDosis();
                        mostrarPacientes("");
                        mostrarVacunas();
                        Limpiarcajas();
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
                    ObjEntidad.Vac_Codigo = Convert.ToInt32(txtId.Text);
                    ObjEntidad.Vac_Paciente = cmbPaciente.SelectedValue.ToString();
                    ObjEntidad.Vac_Centro = Convert.ToInt32(cmbCentro.SelectedValue.ToString());
                    ObjEntidad.Vac_Vacuna = Convert.ToInt32(cmbVacuna.SelectedValue.ToString());
                    ObjEntidad.Vac_Dosis = Convert.ToInt32(cmbDosis.SelectedValue.ToString());

                    if (ObjNegocio.ExisteCedula(cmbPaciente.SelectedValue.ToString()) == cmbDosis.SelectedValue.ToString())
                    {
                        MessageBox.Show("Ya este paciente esta vacunado con esta dosis!!");

                    }
                    else
                    {
                        ObjNegocio.EditandoVacunas(ObjEntidad);

                        MessageBox.Show("Se ha Editado el registro");
                        mostrarTabla();
                        mostrarCentros();
                        mostrarDosis();
                        mostrarPacientes("");
                        mostrarVacunas();

                        Limpiarcajas();
                        Editarse = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaVacunacion.SelectedRows.Count > 0)
            {
                Editarse = true;
                txtId.Text = tablaVacunacion.CurrentRow.Cells[0].Value.ToString();
                cmbPaciente.Text = tablaVacunacion.CurrentRow.Cells[1].Value.ToString();
                cmbCentro.Text = tablaVacunacion.CurrentRow.Cells[2].Value.ToString();
                cmbVacuna.Text = tablaVacunacion.CurrentRow.Cells[3].Value.ToString();
                cmbDosis.Text = tablaVacunacion.CurrentRow.Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desae editar");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form reporte = new ReportesVacunaciones();
            reporte.Show();
        }

        private void btndosis_Click(object sender, EventArgs e)
        {
            Form reporte = new RSegunVacunacion();
            reporte.Show();
        }

        
    }
}
