
namespace CapaPresentacion
{
    partial class FrmPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pacinetes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkSexo = new System.Windows.Forms.CheckedListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunacionDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunacionDataSet2 = new CapaPresentacion.VacunacionDataSet2();
            this.pacientesTableAdapter = new CapaPresentacion.VacunacionDataSet2TableAdapters.PacientesTableAdapter();
            this.pacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPacientes = new System.Windows.Forms.DataGridView();
            this.pacientesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pacCodigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacCedulaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacNombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacApellidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacFNacimientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacSexoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacDireccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacinetes
            // 
            this.Pacinetes.AutoSize = true;
            this.Pacinetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pacinetes.Location = new System.Drawing.Point(317, 32);
            this.Pacinetes.Name = "Pacinetes";
            this.Pacinetes.Size = new System.Drawing.Size(156, 37);
            this.Pacinetes.TabIndex = 0;
            this.Pacinetes.Text = "Pacientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "CEDULA";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(152, 422);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(321, 26);
            this.txtdireccion.TabIndex = 27;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(467, 332);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(173, 26);
            this.txtapellido.TabIndex = 26;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(152, 332);
            this.textnombre.Multiline = true;
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(193, 26);
            this.textnombre.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "NACIMIENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "SEXO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "NOMBRE";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(152, 291);
            this.txtcedula.Multiline = true;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(193, 26);
            this.txtcedula.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "DIRECCION";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // checkSexo
            // 
            this.checkSexo.FormattingEnabled = true;
            this.checkSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO",
            "OTROS"});
            this.checkSexo.Location = new System.Drawing.Point(467, 364);
            this.checkSexo.Name = "checkSexo";
            this.checkSexo.Size = new System.Drawing.Size(173, 49);
            this.checkSexo.TabIndex = 34;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(170, 470);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 40);
            this.button2.TabIndex = 36;
            this.button2.Text = "IMPRIMIR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(50, 470);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.vacunacionDataSet2BindingSource;
            // 
            // vacunacionDataSet2BindingSource
            // 
            this.vacunacionDataSet2BindingSource.DataSource = this.vacunacionDataSet2;
            this.vacunacionDataSet2BindingSource.Position = 0;
            // 
            // vacunacionDataSet2
            // 
            this.vacunacionDataSet2.DataSetName = "VacunacionDataSet2";
            this.vacunacionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesBindingSource1
            // 
            this.pacientesBindingSource1.DataMember = "Pacientes";
            this.pacientesBindingSource1.DataSource = this.vacunacionDataSet2BindingSource;
            // 
            // pacientesBindingSource2
            // 
            this.pacientesBindingSource2.DataMember = "Pacientes";
            this.pacientesBindingSource2.DataSource = this.vacunacionDataSet2BindingSource;
            // 
            // pacientesBindingSource3
            // 
            this.pacientesBindingSource3.DataMember = "Pacientes";
            this.pacientesBindingSource3.DataSource = this.vacunacionDataSet2BindingSource;
            // 
            // tablaPacientes
            // 
            this.tablaPacientes.AutoGenerateColumns = false;
            this.tablaPacientes.BackgroundColor = System.Drawing.Color.White;
            this.tablaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacCodigoDataGridViewTextBoxColumn1,
            this.pacCedulaDataGridViewTextBoxColumn1,
            this.pacNombreDataGridViewTextBoxColumn1,
            this.pacApellidoDataGridViewTextBoxColumn1,
            this.pacFNacimientoDataGridViewTextBoxColumn1,
            this.pacSexoDataGridViewTextBoxColumn1,
            this.pacDireccionDataGridViewTextBoxColumn1});
            this.tablaPacientes.DataSource = this.pacientesBindingSource4;
            this.tablaPacientes.Location = new System.Drawing.Point(50, 97);
            this.tablaPacientes.Name = "tablaPacientes";
            this.tablaPacientes.Size = new System.Drawing.Size(706, 164);
            this.tablaPacientes.TabIndex = 40;
            // 
            // pacientesBindingSource4
            // 
            this.pacientesBindingSource4.DataMember = "Pacientes";
            this.pacientesBindingSource4.DataSource = this.vacunacionDataSet2BindingSource;
            // 
            // pacCodigoDataGridViewTextBoxColumn1
            // 
            this.pacCodigoDataGridViewTextBoxColumn1.DataPropertyName = "Pac_Codigo";
            this.pacCodigoDataGridViewTextBoxColumn1.HeaderText = "Pac_Codigo";
            this.pacCodigoDataGridViewTextBoxColumn1.Name = "pacCodigoDataGridViewTextBoxColumn1";
            this.pacCodigoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pacCodigoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // pacCedulaDataGridViewTextBoxColumn1
            // 
            this.pacCedulaDataGridViewTextBoxColumn1.DataPropertyName = "Pac_Cedula";
            this.pacCedulaDataGridViewTextBoxColumn1.HeaderText = "CEDULA";
            this.pacCedulaDataGridViewTextBoxColumn1.Name = "pacCedulaDataGridViewTextBoxColumn1";
            // 
            // pacNombreDataGridViewTextBoxColumn1
            // 
            this.pacNombreDataGridViewTextBoxColumn1.DataPropertyName = "Pac_Nombre";
            this.pacNombreDataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.pacNombreDataGridViewTextBoxColumn1.Name = "pacNombreDataGridViewTextBoxColumn1";
            // 
            // pacApellidoDataGridViewTextBoxColumn1
            // 
            this.pacApellidoDataGridViewTextBoxColumn1.DataPropertyName = "Pac_Apellido";
            this.pacApellidoDataGridViewTextBoxColumn1.HeaderText = "APELLIDO";
            this.pacApellidoDataGridViewTextBoxColumn1.Name = "pacApellidoDataGridViewTextBoxColumn1";
            // 
            // pacFNacimientoDataGridViewTextBoxColumn1
            // 
            this.pacFNacimientoDataGridViewTextBoxColumn1.DataPropertyName = "Pac_FNacimiento";
            this.pacFNacimientoDataGridViewTextBoxColumn1.HeaderText = "FECHA NACIMIENTO";
            this.pacFNacimientoDataGridViewTextBoxColumn1.Name = "pacFNacimientoDataGridViewTextBoxColumn1";
            // 
            // pacSexoDataGridViewTextBoxColumn1
            // 
            this.pacSexoDataGridViewTextBoxColumn1.DataPropertyName = "Pac_Sexo";
            this.pacSexoDataGridViewTextBoxColumn1.HeaderText = "SEXO";
            this.pacSexoDataGridViewTextBoxColumn1.Name = "pacSexoDataGridViewTextBoxColumn1";
            // 
            // pacDireccionDataGridViewTextBoxColumn1
            // 
            this.pacDireccionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pacDireccionDataGridViewTextBoxColumn1.DataPropertyName = "Pac_Direccion";
            this.pacDireccionDataGridViewTextBoxColumn1.HeaderText = "DIRECCION";
            this.pacDireccionDataGridViewTextBoxColumn1.Name = "pacDireccionDataGridViewTextBoxColumn1";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(389, 282);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(193, 26);
            this.txtId.TabIndex = 41;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 576);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.tablaPacientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.checkSexo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pacinetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPacientes";
            this.Text = "FrmPacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pacinetes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox checkSexo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource vacunacionDataSet2BindingSource;
        private VacunacionDataSet2 vacunacionDataSet2;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private VacunacionDataSet2TableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource pacientesBindingSource1;
        private System.Windows.Forms.BindingSource pacientesBindingSource2;
        private System.Windows.Forms.BindingSource pacientesBindingSource3;
        private System.Windows.Forms.DataGridView tablaPacientes;
        private System.Windows.Forms.BindingSource pacientesBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacCodigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacCedulaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacNombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacApellidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacFNacimientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacSexoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacDireccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtId;
    }
}