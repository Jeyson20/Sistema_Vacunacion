
namespace Presentacion
{
    partial class Vacunaciones
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
            this.tablaVacunacion = new System.Windows.Forms.DataGridView();
            this.pBUSCARVACUNACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunacionDataSet = new Presentacion.VacunacionDataSet();
            this.p_BUSCAR_VACUNACIONTableAdapter = new Presentacion.VacunacionDataSetTableAdapters.P_BUSCAR_VACUNACIONTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbVacuna = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbDosis = new System.Windows.Forms.ComboBox();
            this.cmbCentro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pACIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACUNADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOSISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fVACUNACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVacunacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUSCARVACUNACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVacunacion
            // 
            this.tablaVacunacion.AllowUserToAddRows = false;
            this.tablaVacunacion.AllowUserToDeleteRows = false;
            this.tablaVacunacion.AutoGenerateColumns = false;
            this.tablaVacunacion.BackgroundColor = System.Drawing.Color.White;
            this.tablaVacunacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVacunacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGODataGridViewTextBoxColumn,
            this.pACIENTEDataGridViewTextBoxColumn,
            this.cENTRODataGridViewTextBoxColumn,
            this.vACUNADataGridViewTextBoxColumn,
            this.dOSISDataGridViewTextBoxColumn,
            this.fVACUNACIONDataGridViewTextBoxColumn});
            this.tablaVacunacion.DataSource = this.pBUSCARVACUNACIONBindingSource;
            this.tablaVacunacion.Location = new System.Drawing.Point(111, 76);
            this.tablaVacunacion.Name = "tablaVacunacion";
            this.tablaVacunacion.ReadOnly = true;
            this.tablaVacunacion.Size = new System.Drawing.Size(588, 216);
            this.tablaVacunacion.TabIndex = 0;
            // 
            // pBUSCARVACUNACIONBindingSource
            // 
            this.pBUSCARVACUNACIONBindingSource.DataMember = "P_BUSCAR_VACUNACION";
            this.pBUSCARVACUNACIONBindingSource.DataSource = this.vacunacionDataSet;
            // 
            // vacunacionDataSet
            // 
            this.vacunacionDataSet.DataSetName = "VacunacionDataSet";
            this.vacunacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_BUSCAR_VACUNACIONTableAdapter
            // 
            this.p_BUSCAR_VACUNACIONTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(111, 460);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(371, 460);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpiar.TabIndex = 40;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(241, 460);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(524, 460);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(175, 40);
            this.btnImprimir.TabIndex = 42;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(189, 344);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 21);
            this.cmbPaciente.TabIndex = 50;
            // 
            // cmbVacuna
            // 
            this.cmbVacuna.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVacuna.FormattingEnabled = true;
            this.cmbVacuna.Location = new System.Drawing.Point(189, 398);
            this.cmbVacuna.Name = "cmbVacuna";
            this.cmbVacuna.Size = new System.Drawing.Size(121, 21);
            this.cmbVacuna.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(140, 309);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(43, 26);
            this.txtId.TabIndex = 52;
            // 
            // cmbDosis
            // 
            this.cmbDosis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDosis.FormattingEnabled = true;
            this.cmbDosis.Location = new System.Drawing.Point(424, 399);
            this.cmbDosis.Name = "cmbDosis";
            this.cmbDosis.Size = new System.Drawing.Size(121, 21);
            this.cmbDosis.TabIndex = 54;
            // 
            // cmbCentro
            // 
            this.cmbCentro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCentro.FormattingEnabled = true;
            this.cmbCentro.Location = new System.Drawing.Point(424, 344);
            this.cmbCentro.Name = "cmbCentro";
            this.cmbCentro.Size = new System.Drawing.Size(132, 21);
            this.cmbCentro.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "PACIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "VACUNA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "DOSIS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(336, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "CENTRO";
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIGODataGridViewTextBoxColumn.Visible = false;
            // 
            // pACIENTEDataGridViewTextBoxColumn
            // 
            this.pACIENTEDataGridViewTextBoxColumn.DataPropertyName = "PACIENTE";
            this.pACIENTEDataGridViewTextBoxColumn.HeaderText = "PACIENTE";
            this.pACIENTEDataGridViewTextBoxColumn.Name = "pACIENTEDataGridViewTextBoxColumn";
            this.pACIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cENTRODataGridViewTextBoxColumn
            // 
            this.cENTRODataGridViewTextBoxColumn.DataPropertyName = "CENTRO";
            this.cENTRODataGridViewTextBoxColumn.HeaderText = "CENTRO";
            this.cENTRODataGridViewTextBoxColumn.Name = "cENTRODataGridViewTextBoxColumn";
            this.cENTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vACUNADataGridViewTextBoxColumn
            // 
            this.vACUNADataGridViewTextBoxColumn.DataPropertyName = "VACUNA";
            this.vACUNADataGridViewTextBoxColumn.HeaderText = "VACUNA";
            this.vACUNADataGridViewTextBoxColumn.Name = "vACUNADataGridViewTextBoxColumn";
            this.vACUNADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOSISDataGridViewTextBoxColumn
            // 
            this.dOSISDataGridViewTextBoxColumn.DataPropertyName = "DOSIS";
            this.dOSISDataGridViewTextBoxColumn.HeaderText = "DOSIS";
            this.dOSISDataGridViewTextBoxColumn.Name = "dOSISDataGridViewTextBoxColumn";
            this.dOSISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fVACUNACIONDataGridViewTextBoxColumn
            // 
            this.fVACUNACIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fVACUNACIONDataGridViewTextBoxColumn.DataPropertyName = "FVACUNACION";
            this.fVACUNACIONDataGridViewTextBoxColumn.HeaderText = "FECHA VACUNACION";
            this.fVACUNACIONDataGridViewTextBoxColumn.Name = "fVACUNACIONDataGridViewTextBoxColumn";
            this.fVACUNACIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Vacunaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 576);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCentro);
            this.Controls.Add(this.cmbDosis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbVacuna);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tablaVacunacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vacunaciones";
            this.Text = "Vacunaciones";
            this.Load += new System.EventHandler(this.Vacunaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVacunacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUSCARVACUNACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaVacunacion;
        private VacunacionDataSet vacunacionDataSet;
        private System.Windows.Forms.BindingSource pBUSCARVACUNACIONBindingSource;
        private VacunacionDataSetTableAdapters.P_BUSCAR_VACUNACIONTableAdapter p_BUSCAR_VACUNACIONTableAdapter;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnImprimir;
        public System.Windows.Forms.ComboBox cmbPaciente;
        public System.Windows.Forms.ComboBox cmbVacuna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.ComboBox cmbDosis;
        public System.Windows.Forms.ComboBox cmbCentro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pACIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACUNADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOSISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fVACUNACIONDataGridViewTextBoxColumn;
    }
}