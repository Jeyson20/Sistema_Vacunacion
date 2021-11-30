
namespace CapaPresentacion
{
    partial class FrmCentros
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
            this.centrosVacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.vacunacionDataSet1 = new CapaPresentacion.VacunacionDataSet1();
            this.vacunacionDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centrosVacunasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.centrosVacunasTableAdapter = new CapaPresentacion.VacunacionDataSet1TableAdapters.CentrosVacunasTableAdapter();
            this.tablacentros = new System.Windows.Forms.DataGridView();
            this.cenCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenProvinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenCantidadLotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centrosVacunasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.centrosVacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosVacunasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosVacunasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "CENTROS";
            // 
            // centrosVacunasBindingSource
            // 
            this.centrosVacunasBindingSource.DataMember = "CentrosVacunas";
            this.centrosVacunasBindingSource.DataSource = this.vacunacionDataSetBindingSource;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(47, 451);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "IMPRIMIR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(167, 451);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(600, 360);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(174, 26);
            this.txtDireccion.TabIndex = 18;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(218, 359);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(174, 26);
            this.txtDescripcion.TabIndex = 17;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(600, 313);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(174, 26);
            this.txtCantidad.TabIndex = 16;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(218, 313);
            this.txtProvincia.Multiline = true;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(174, 26);
            this.txtProvincia.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "CANTIDAD  LOTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "DESCRIPCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "DIRECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "PROVINCIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(75, 272);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(43, 26);
            this.txtId.TabIndex = 20;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(292, 451);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            // centrosVacunasBindingSource1
            // 
            this.centrosVacunasBindingSource1.DataMember = "CentrosVacunas";
            this.centrosVacunasBindingSource1.DataSource = this.vacunacionDataSet1BindingSource;
            // 
            // centrosVacunasTableAdapter
            // 
            this.centrosVacunasTableAdapter.ClearBeforeFill = true;
            // 
            // tablacentros
            // 
            this.tablacentros.AutoGenerateColumns = false;
            this.tablacentros.BackgroundColor = System.Drawing.Color.White;
            this.tablacentros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablacentros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cenCodigoDataGridViewTextBoxColumn,
            this.cenProvinciaDataGridViewTextBoxColumn,
            this.cenCantidadLotesDataGridViewTextBoxColumn,
            this.cenDescripcionDataGridViewTextBoxColumn,
            this.cenDireccionDataGridViewTextBoxColumn});
            this.tablacentros.DataSource = this.centrosVacunasBindingSource2;
            this.tablacentros.GridColor = System.Drawing.Color.Silver;
            this.tablacentros.Location = new System.Drawing.Point(47, 102);
            this.tablacentros.Name = "tablacentros";
            this.tablacentros.Size = new System.Drawing.Size(727, 151);
            this.tablacentros.TabIndex = 22;
            // 
            // cenCodigoDataGridViewTextBoxColumn
            // 
            this.cenCodigoDataGridViewTextBoxColumn.DataPropertyName = "Cen_Codigo";
            this.cenCodigoDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cenCodigoDataGridViewTextBoxColumn.Name = "cenCodigoDataGridViewTextBoxColumn";
            this.cenCodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cenProvinciaDataGridViewTextBoxColumn
            // 
            this.cenProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Cen_Provincia";
            this.cenProvinciaDataGridViewTextBoxColumn.HeaderText = "PROVINCIA";
            this.cenProvinciaDataGridViewTextBoxColumn.Name = "cenProvinciaDataGridViewTextBoxColumn";
            // 
            // cenCantidadLotesDataGridViewTextBoxColumn
            // 
            this.cenCantidadLotesDataGridViewTextBoxColumn.DataPropertyName = "Cen_CantidadLotes";
            this.cenCantidadLotesDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cenCantidadLotesDataGridViewTextBoxColumn.Name = "cenCantidadLotesDataGridViewTextBoxColumn";
            // 
            // cenDescripcionDataGridViewTextBoxColumn
            // 
            this.cenDescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Cen_Descripcion";
            this.cenDescripcionDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.cenDescripcionDataGridViewTextBoxColumn.Name = "cenDescripcionDataGridViewTextBoxColumn";
            // 
            // cenDireccionDataGridViewTextBoxColumn
            // 
            this.cenDireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenDireccionDataGridViewTextBoxColumn.DataPropertyName = "Cen_Direccion";
            this.cenDireccionDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.cenDireccionDataGridViewTextBoxColumn.Name = "cenDireccionDataGridViewTextBoxColumn";
            // 
            // centrosVacunasBindingSource2
            // 
            this.centrosVacunasBindingSource2.DataMember = "CentrosVacunas";
            this.centrosVacunasBindingSource2.DataSource = this.vacunacionDataSet1BindingSource;
            // 
            // FrmCentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 576);
            this.Controls.Add(this.tablacentros);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCentros";
            this.Text = "FrmCentros";
            this.Load += new System.EventHandler(this.FrmCentros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centrosVacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosVacunasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosVacunasBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.BindingSource vacunacionDataSetBindingSource;
        private System.Windows.Forms.BindingSource centrosVacunasBindingSource;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminar;
        private VacunacionDataSet1 vacunacionDataSet1;
        private System.Windows.Forms.BindingSource vacunacionDataSet1BindingSource;
        private System.Windows.Forms.BindingSource centrosVacunasBindingSource1;
        private VacunacionDataSet1TableAdapters.CentrosVacunasTableAdapter centrosVacunasTableAdapter;
        private System.Windows.Forms.DataGridView tablacentros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenProvinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenCantidadLotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource centrosVacunasBindingSource2;
    }
}