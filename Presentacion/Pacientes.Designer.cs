
namespace Presentacion
{
    partial class Pacientes
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
            this.tablaPacientes = new System.Windows.Forms.DataGridView();
            this.vacunacionDataSet = new Presentacion.VacunacionDataSet();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new Presentacion.VacunacionDataSetTableAdapters.PacientesTableAdapter();
            this.pacCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacFNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkSexo = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacinetes
            // 
            this.Pacinetes.AutoSize = true;
            this.Pacinetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pacinetes.Location = new System.Drawing.Point(309, 53);
            this.Pacinetes.Name = "Pacinetes";
            this.Pacinetes.Size = new System.Drawing.Size(156, 37);
            this.Pacinetes.TabIndex = 1;
            this.Pacinetes.Text = "Pacientes";
            // 
            // tablaPacientes
            // 
            this.tablaPacientes.AllowUserToAddRows = false;
            this.tablaPacientes.AllowUserToDeleteRows = false;
            this.tablaPacientes.AutoGenerateColumns = false;
            this.tablaPacientes.BackgroundColor = System.Drawing.Color.White;
            this.tablaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacCodigoDataGridViewTextBoxColumn,
            this.pacCedulaDataGridViewTextBoxColumn,
            this.pacNombreDataGridViewTextBoxColumn,
            this.pacApellidoDataGridViewTextBoxColumn,
            this.pacFNacimientoDataGridViewTextBoxColumn,
            this.pacSexoDataGridViewTextBoxColumn,
            this.pacDireccionDataGridViewTextBoxColumn});
            this.tablaPacientes.DataSource = this.pacientesBindingSource;
            this.tablaPacientes.Location = new System.Drawing.Point(61, 102);
            this.tablaPacientes.Name = "tablaPacientes";
            this.tablaPacientes.ReadOnly = true;
            this.tablaPacientes.Size = new System.Drawing.Size(695, 205);
            this.tablaPacientes.TabIndex = 2;
            // 
            // vacunacionDataSet
            // 
            this.vacunacionDataSet.DataSetName = "VacunacionDataSet";
            this.vacunacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.vacunacionDataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // pacCodigoDataGridViewTextBoxColumn
            // 
            this.pacCodigoDataGridViewTextBoxColumn.DataPropertyName = "Pac_Codigo";
            this.pacCodigoDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.pacCodigoDataGridViewTextBoxColumn.Name = "pacCodigoDataGridViewTextBoxColumn";
            this.pacCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacCodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacCedulaDataGridViewTextBoxColumn
            // 
            this.pacCedulaDataGridViewTextBoxColumn.DataPropertyName = "Pac_Cedula";
            this.pacCedulaDataGridViewTextBoxColumn.HeaderText = "CEDULA";
            this.pacCedulaDataGridViewTextBoxColumn.Name = "pacCedulaDataGridViewTextBoxColumn";
            this.pacCedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacNombreDataGridViewTextBoxColumn
            // 
            this.pacNombreDataGridViewTextBoxColumn.DataPropertyName = "Pac_Nombre";
            this.pacNombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.pacNombreDataGridViewTextBoxColumn.Name = "pacNombreDataGridViewTextBoxColumn";
            this.pacNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacApellidoDataGridViewTextBoxColumn
            // 
            this.pacApellidoDataGridViewTextBoxColumn.DataPropertyName = "Pac_Apellido";
            this.pacApellidoDataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.pacApellidoDataGridViewTextBoxColumn.Name = "pacApellidoDataGridViewTextBoxColumn";
            this.pacApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacFNacimientoDataGridViewTextBoxColumn
            // 
            this.pacFNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Pac_FNacimiento";
            this.pacFNacimientoDataGridViewTextBoxColumn.HeaderText = "FECHA NACIMIENTO";
            this.pacFNacimientoDataGridViewTextBoxColumn.Name = "pacFNacimientoDataGridViewTextBoxColumn";
            this.pacFNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacSexoDataGridViewTextBoxColumn
            // 
            this.pacSexoDataGridViewTextBoxColumn.DataPropertyName = "Pac_Sexo";
            this.pacSexoDataGridViewTextBoxColumn.HeaderText = "SEXO";
            this.pacSexoDataGridViewTextBoxColumn.Name = "pacSexoDataGridViewTextBoxColumn";
            this.pacSexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacDireccionDataGridViewTextBoxColumn
            // 
            this.pacDireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pacDireccionDataGridViewTextBoxColumn.DataPropertyName = "Pac_Direccion";
            this.pacDireccionDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.pacDireccionDataGridViewTextBoxColumn.Name = "pacDireccionDataGridViewTextBoxColumn";
            this.pacDireccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkSexo
            // 
            this.checkSexo.FormattingEnabled = true;
            this.checkSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO",
            "OTROS"});
            this.checkSexo.Location = new System.Drawing.Point(478, 396);
            this.checkSexo.Name = "checkSexo";
            this.checkSexo.Size = new System.Drawing.Size(173, 49);
            this.checkSexo.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 408);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "DIRECCION";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(163, 323);
            this.txtcedula.Multiline = true;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(193, 26);
            this.txtcedula.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "CEDULA";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(163, 454);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(321, 26);
            this.txtdireccion.TabIndex = 41;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(478, 364);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(173, 26);
            this.txtapellido.TabIndex = 40;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(163, 364);
            this.textnombre.Multiline = true;
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(193, 26);
            this.textnombre.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "NACIMIENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "SEXO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "NOMBRE";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(183, 502);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 40);
            this.button2.TabIndex = 48;
            this.button2.Text = "IMPRIMIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(61, 502);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(302, 502);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpiar.TabIndex = 50;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 576);
            this.Controls.Add(this.btnLimpiar);
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
            this.Controls.Add(this.tablaPacientes);
            this.Controls.Add(this.Pacinetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pacinetes;
        private System.Windows.Forms.DataGridView tablaPacientes;
        private VacunacionDataSet vacunacionDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private VacunacionDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacFNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox checkSexo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}