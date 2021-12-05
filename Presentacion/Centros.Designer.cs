
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
            this.txtProvincia = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.vacunacionDataSet1 = new Presentacion.VacunacionDataSet1();
            this.vacunacionDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centrosVacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centrosVacunasTableAdapter = new Presentacion.VacunacionDataSet1TableAdapters.CentrosVacunasTableAdapter();
            this.cenCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenProvinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenCantidadLotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenVencimientoLotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosVacunasBindingSource)).BeginInit();
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
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(155, 347);
            this.txtProvincia.Multiline = true;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(174, 26);
            this.txtProvincia.TabIndex = 29;
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
            this.cenCodigoDataGridViewTextBoxColumn,
            this.cenProvinciaDataGridViewTextBoxColumn,
            this.numeroLotesDataGridViewTextBoxColumn,
            this.cenCantidadLotesDataGridViewTextBoxColumn,
            this.cenVencimientoLotesDataGridViewTextBoxColumn,
            this.cenDescripcionDataGridViewTextBoxColumn,
            this.cenDireccionDataGridViewTextBoxColumn});
            this.tablacentros.DataSource = this.centrosVacunasBindingSource;
            this.tablacentros.Location = new System.Drawing.Point(38, 110);
            this.tablacentros.Name = "tablacentros";
            this.tablacentros.ReadOnly = true;
            this.tablacentros.Size = new System.Drawing.Size(725, 162);
            this.tablacentros.TabIndex = 43;
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
            // vacunacionDataSet1
            // 
            this.vacunacionDataSet1.DataSetName = "VacunacionDataSet1";
            this.vacunacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacunacionDataSet1BindingSource
            // 
            this.vacunacionDataSet1BindingSource.DataSource = this.vacunacionDataSet1;
            this.vacunacionDataSet1BindingSource.Position = 0;
            // 
            // centrosVacunasBindingSource
            // 
            this.centrosVacunasBindingSource.DataMember = "CentrosVacunas";
            this.centrosVacunasBindingSource.DataSource = this.vacunacionDataSet1BindingSource;
            // 
            // centrosVacunasTableAdapter
            // 
            this.centrosVacunasTableAdapter.ClearBeforeFill = true;
            // 
            // cenCodigoDataGridViewTextBoxColumn
            // 
            this.cenCodigoDataGridViewTextBoxColumn.DataPropertyName = "Cen_Codigo";
            this.cenCodigoDataGridViewTextBoxColumn.HeaderText = "Cen_Codigo";
            this.cenCodigoDataGridViewTextBoxColumn.Name = "cenCodigoDataGridViewTextBoxColumn";
            this.cenCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenCodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cenProvinciaDataGridViewTextBoxColumn
            // 
            this.cenProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Cen_Provincia";
            this.cenProvinciaDataGridViewTextBoxColumn.HeaderText = "PROVINCIA";
            this.cenProvinciaDataGridViewTextBoxColumn.Name = "cenProvinciaDataGridViewTextBoxColumn";
            this.cenProvinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroLotesDataGridViewTextBoxColumn
            // 
            this.numeroLotesDataGridViewTextBoxColumn.DataPropertyName = "Numero_Lotes";
            this.numeroLotesDataGridViewTextBoxColumn.HeaderText = "NUMERO LOTE";
            this.numeroLotesDataGridViewTextBoxColumn.Name = "numeroLotesDataGridViewTextBoxColumn";
            this.numeroLotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenCantidadLotesDataGridViewTextBoxColumn
            // 
            this.cenCantidadLotesDataGridViewTextBoxColumn.DataPropertyName = "Cen_CantidadLotes";
            this.cenCantidadLotesDataGridViewTextBoxColumn.HeaderText = "CANTIDAD LOTE";
            this.cenCantidadLotesDataGridViewTextBoxColumn.Name = "cenCantidadLotesDataGridViewTextBoxColumn";
            this.cenCantidadLotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenVencimientoLotesDataGridViewTextBoxColumn
            // 
            this.cenVencimientoLotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenVencimientoLotesDataGridViewTextBoxColumn.DataPropertyName = "Cen_VencimientoLotes";
            this.cenVencimientoLotesDataGridViewTextBoxColumn.HeaderText = "FECHA CADUCIDAD LOTE";
            this.cenVencimientoLotesDataGridViewTextBoxColumn.Name = "cenVencimientoLotesDataGridViewTextBoxColumn";
            this.cenVencimientoLotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenDescripcionDataGridViewTextBoxColumn
            // 
            this.cenDescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Cen_Descripcion";
            this.cenDescripcionDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.cenDescripcionDataGridViewTextBoxColumn.Name = "cenDescripcionDataGridViewTextBoxColumn";
            this.cenDescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenDireccionDataGridViewTextBoxColumn
            // 
            this.cenDireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenDireccionDataGridViewTextBoxColumn.DataPropertyName = "Cen_Direccion";
            this.cenDireccionDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.cenDireccionDataGridViewTextBoxColumn.Name = "cenDireccionDataGridViewTextBoxColumn";
            this.cenDireccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Centros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 576);
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
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Centros";
            this.Text = "Centros";
            this.Load += new System.EventHandler(this.Centros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosVacunasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProvincia;
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
        private System.Windows.Forms.BindingSource vacunacionDataSet1BindingSource;
        private VacunacionDataSet1 vacunacionDataSet1;
        private System.Windows.Forms.BindingSource centrosVacunasBindingSource;
        private VacunacionDataSet1TableAdapters.CentrosVacunasTableAdapter centrosVacunasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenProvinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenCantidadLotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenVencimientoLotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenDireccionDataGridViewTextBoxColumn;
    }
}