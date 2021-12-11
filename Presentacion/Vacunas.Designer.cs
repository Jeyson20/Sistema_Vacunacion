
namespace Presentacion
{
    partial class Vacunas
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
            this.label2 = new System.Windows.Forms.Label();
            this.tablacentros = new System.Windows.Forms.DataGridView();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lABORATORIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPIRACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBUSCARVACUNABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunacionDataSet = new Presentacion.VacunacionDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.p_BUSCAR_VACUNATableAdapter = new Presentacion.VacunacionDataSetTableAdapters.P_BUSCAR_VACUNATableAdapter();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUSCARVACUNABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 37);
            this.label2.TabIndex = 43;
            this.label2.Text = "VACUNAS";
            // 
            // tablacentros
            // 
            this.tablacentros.AllowUserToAddRows = false;
            this.tablacentros.AllowUserToDeleteRows = false;
            this.tablacentros.AutoGenerateColumns = false;
            this.tablacentros.BackgroundColor = System.Drawing.Color.White;
            this.tablacentros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablacentros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGODataGridViewTextBoxColumn,
            this.lABORATORIODataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn,
            this.eXPIRACIONDataGridViewTextBoxColumn,
            this.lOTEDataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn});
            this.tablacentros.DataSource = this.pBUSCARVACUNABindingSource;
            this.tablacentros.Location = new System.Drawing.Point(45, 111);
            this.tablacentros.Name = "tablacentros";
            this.tablacentros.ReadOnly = true;
            this.tablacentros.Size = new System.Drawing.Size(725, 162);
            this.tablacentros.TabIndex = 44;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lABORATORIODataGridViewTextBoxColumn
            // 
            this.lABORATORIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lABORATORIODataGridViewTextBoxColumn.DataPropertyName = "LABORATORIO";
            this.lABORATORIODataGridViewTextBoxColumn.HeaderText = "LABORATORIO";
            this.lABORATORIODataGridViewTextBoxColumn.Name = "lABORATORIODataGridViewTextBoxColumn";
            this.lABORATORIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            this.mARCADataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            this.mARCADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXPIRACIONDataGridViewTextBoxColumn
            // 
            this.eXPIRACIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eXPIRACIONDataGridViewTextBoxColumn.DataPropertyName = "EXPIRACION";
            this.eXPIRACIONDataGridViewTextBoxColumn.HeaderText = "EXPIRACION";
            this.eXPIRACIONDataGridViewTextBoxColumn.Name = "eXPIRACIONDataGridViewTextBoxColumn";
            this.eXPIRACIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOTEDataGridViewTextBoxColumn
            // 
            this.lOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE";
            this.lOTEDataGridViewTextBoxColumn.HeaderText = "LOTE";
            this.lOTEDataGridViewTextBoxColumn.Name = "lOTEDataGridViewTextBoxColumn";
            this.lOTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            this.cANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pBUSCARVACUNABindingSource
            // 
            this.pBUSCARVACUNABindingSource.DataMember = "P_BUSCAR_VACUNA";
            this.pBUSCARVACUNABindingSource.DataSource = this.vacunacionDataSet;
            // 
            // vacunacionDataSet
            // 
            this.vacunacionDataSet.DataSetName = "VacunacionDataSet";
            this.vacunacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "ID";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(167, 424);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(97, 26);
            this.txtCantidad.TabIndex = 53;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(454, 353);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(167, 26);
            this.txtMarca.TabIndex = 52;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(83, 310);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(43, 26);
            this.txtId.TabIndex = 51;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(454, 393);
            this.txtLote.Multiline = true;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(117, 26);
            this.txtLote.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "LOTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "LABORATORIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "MARCA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 392);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "EXPIRACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "CANTIDAD";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(508, 490);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(175, 40);
            this.btnImprimir.TabIndex = 65;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(167, 490);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(290, 490);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "LIMPIAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(38, 490);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // p_BUSCAR_VACUNATableAdapter
            // 
            this.p_BUSCAR_VACUNATableAdapter.ClearBeforeFill = true;
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(167, 349);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(172, 21);
            this.cmbLaboratorio.TabIndex = 66;
            // 
            // Vacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 576);
            this.Controls.Add(this.cmbLaboratorio);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tablacentros);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vacunas";
            this.Text = "Vacunas";
            this.Load += new System.EventHandler(this.Vacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUSCARVACUNABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablacentros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private VacunacionDataSet vacunacionDataSet;
        private System.Windows.Forms.BindingSource pBUSCARVACUNABindingSource;
        private VacunacionDataSetTableAdapters.P_BUSCAR_VACUNATableAdapter p_BUSCAR_VACUNATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lABORATORIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPIRACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
    }
}