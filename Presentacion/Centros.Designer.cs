
namespace Presentacion
{
    partial class Centros
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tablacentros = new System.Windows.Forms.DataGridView();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVINCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMLOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENCIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBUSCARCENTROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunacionDataSet = new Presentacion.VacunacionDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.p_BUSCAR_CENTROTableAdapter = new Presentacion.VacunacionDataSetTableAdapters.P_BUSCAR_CENTROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUSCARCENTROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "PROVINCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "DESCRIPCION";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(155, 429);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(174, 26);
            this.txtDescripcion.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(71, 304);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(43, 26);
            this.txtId.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "CANTIDAD  LOTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "DIRECCION";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(508, 347);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(174, 26);
            this.txtCantidad.TabIndex = 36;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(465, 429);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(217, 26);
            this.txtDireccion.TabIndex = 37;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(38, 496);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(290, 496);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(167, 496);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(508, 496);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(175, 40);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "CENTROS";
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
            this.pROVINCIADataGridViewTextBoxColumn,
            this.nUMLOTEDataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.vENCIMIENTODataGridViewTextBoxColumn,
            this.cENTRODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn});
            this.tablacentros.DataSource = this.pBUSCARCENTROBindingSource;
            this.tablacentros.Location = new System.Drawing.Point(38, 110);
            this.tablacentros.Name = "tablacentros";
            this.tablacentros.ReadOnly = true;
            this.tablacentros.Size = new System.Drawing.Size(725, 162);
            this.tablacentros.TabIndex = 43;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIGODataGridViewTextBoxColumn.Visible = false;
            // 
            // pROVINCIADataGridViewTextBoxColumn
            // 
            this.pROVINCIADataGridViewTextBoxColumn.DataPropertyName = "PROVINCIA";
            this.pROVINCIADataGridViewTextBoxColumn.HeaderText = "PROVINCIA";
            this.pROVINCIADataGridViewTextBoxColumn.Name = "pROVINCIADataGridViewTextBoxColumn";
            this.pROVINCIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMLOTEDataGridViewTextBoxColumn
            // 
            this.nUMLOTEDataGridViewTextBoxColumn.DataPropertyName = "NUMLOTE";
            this.nUMLOTEDataGridViewTextBoxColumn.HeaderText = "NUMLOTE";
            this.nUMLOTEDataGridViewTextBoxColumn.Name = "nUMLOTEDataGridViewTextBoxColumn";
            this.nUMLOTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            this.cANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vENCIMIENTODataGridViewTextBoxColumn
            // 
            this.vENCIMIENTODataGridViewTextBoxColumn.DataPropertyName = "VENCIMIENTO";
            this.vENCIMIENTODataGridViewTextBoxColumn.HeaderText = "VENCIMIENTO";
            this.vENCIMIENTODataGridViewTextBoxColumn.Name = "vENCIMIENTODataGridViewTextBoxColumn";
            this.vENCIMIENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cENTRODataGridViewTextBoxColumn
            // 
            this.cENTRODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cENTRODataGridViewTextBoxColumn.DataPropertyName = "CENTRO";
            this.cENTRODataGridViewTextBoxColumn.HeaderText = "CENTRO";
            this.cENTRODataGridViewTextBoxColumn.Name = "cENTRODataGridViewTextBoxColumn";
            this.cENTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pBUSCARCENTROBindingSource
            // 
            this.pBUSCARCENTROBindingSource.DataMember = "P_BUSCAR_CENTRO";
            this.pBUSCARCENTROBindingSource.DataSource = this.vacunacionDataSet;
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
            this.label6.Location = new System.Drawing.Point(34, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "ID";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(155, 386);
            this.txtLote.Multiline = true;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(92, 26);
            this.txtLote.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "NUMERO LOTE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "CADUCIDAD LOTE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(507, 387);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.BackColor = System.Drawing.Color.White;
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(155, 347);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(174, 21);
            this.cmbProvincias.TabIndex = 49;
            // 
            // p_BUSCAR_CENTROTableAdapter
            // 
            this.p_BUSCAR_CENTROTableAdapter.ClearBeforeFill = true;
            // 
            // Centros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 576);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tablacentros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Centros";
            this.Text = "Centros";
            this.Load += new System.EventHandler(this.Centros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUSCARCENTROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablacentros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cmbProvincias;
        private VacunacionDataSet vacunacionDataSet;
        private System.Windows.Forms.BindingSource pBUSCARCENTROBindingSource;
        private VacunacionDataSetTableAdapters.P_BUSCAR_CENTROTableAdapter p_BUSCAR_CENTROTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVINCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMLOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENCIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
    }
}