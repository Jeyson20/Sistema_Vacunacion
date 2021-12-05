
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
            this.vCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vExpiracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunacionDataSet1 = new Presentacion.VacunacionDataSet1();
            this.vacunasTableAdapter = new Presentacion.VacunacionDataSet1TableAdapters.VacunasTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.tablacentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1)).BeginInit();
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
            this.vCodigoDataGridViewTextBoxColumn,
            this.vLaboratorioDataGridViewTextBoxColumn,
            this.vMarcaDataGridViewTextBoxColumn,
            this.vExpiracionDataGridViewTextBoxColumn,
            this.vLoteDataGridViewTextBoxColumn,
            this.vCantidadDataGridViewTextBoxColumn});
            this.tablacentros.DataSource = this.vacunasBindingSource;
            this.tablacentros.Location = new System.Drawing.Point(45, 111);
            this.tablacentros.Name = "tablacentros";
            this.tablacentros.ReadOnly = true;
            this.tablacentros.Size = new System.Drawing.Size(725, 162);
            this.tablacentros.TabIndex = 44;
            // 
            // vCodigoDataGridViewTextBoxColumn
            // 
            this.vCodigoDataGridViewTextBoxColumn.DataPropertyName = "V_Codigo";
            this.vCodigoDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.vCodigoDataGridViewTextBoxColumn.Name = "vCodigoDataGridViewTextBoxColumn";
            this.vCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vLaboratorioDataGridViewTextBoxColumn
            // 
            this.vLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "V_Laboratorio";
            this.vLaboratorioDataGridViewTextBoxColumn.HeaderText = "LABORATORIO";
            this.vLaboratorioDataGridViewTextBoxColumn.Name = "vLaboratorioDataGridViewTextBoxColumn";
            this.vLaboratorioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vMarcaDataGridViewTextBoxColumn
            // 
            this.vMarcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vMarcaDataGridViewTextBoxColumn.DataPropertyName = "V_Marca";
            this.vMarcaDataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.vMarcaDataGridViewTextBoxColumn.Name = "vMarcaDataGridViewTextBoxColumn";
            this.vMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vExpiracionDataGridViewTextBoxColumn
            // 
            this.vExpiracionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vExpiracionDataGridViewTextBoxColumn.DataPropertyName = "V_Expiracion";
            this.vExpiracionDataGridViewTextBoxColumn.HeaderText = "FECHA DE EXPIRACION";
            this.vExpiracionDataGridViewTextBoxColumn.Name = "vExpiracionDataGridViewTextBoxColumn";
            this.vExpiracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vLoteDataGridViewTextBoxColumn
            // 
            this.vLoteDataGridViewTextBoxColumn.DataPropertyName = "V_Lote";
            this.vLoteDataGridViewTextBoxColumn.HeaderText = "LOTE";
            this.vLoteDataGridViewTextBoxColumn.Name = "vLoteDataGridViewTextBoxColumn";
            this.vLoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vCantidadDataGridViewTextBoxColumn
            // 
            this.vCantidadDataGridViewTextBoxColumn.DataPropertyName = "V_Cantidad";
            this.vCantidadDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.vCantidadDataGridViewTextBoxColumn.Name = "vCantidadDataGridViewTextBoxColumn";
            this.vCantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vacunasBindingSource
            // 
            this.vacunasBindingSource.DataMember = "Vacunas";
            this.vacunasBindingSource.DataSource = this.vacunacionDataSet1;
            // 
            // vacunacionDataSet1
            // 
            this.vacunacionDataSet1.DataSetName = "VacunacionDataSet1";
            this.vacunacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacunasTableAdapter
            // 
            this.vacunasTableAdapter.ClearBeforeFill = true;
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
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(167, 353);
            this.txtLaboratorio.Multiline = true;
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(174, 26);
            this.txtLaboratorio.TabIndex = 49;
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
            this.btnEliminar.Text = "ELIMINAR";
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
            // Vacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 576);
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
            this.Controls.Add(this.txtLaboratorio);
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
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunacionDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablacentros;
        private VacunacionDataSet1 vacunacionDataSet1;
        private System.Windows.Forms.BindingSource vacunasBindingSource;
        private VacunacionDataSet1TableAdapters.VacunasTableAdapter vacunasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vLaboratorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vExpiracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.TextBox txtLaboratorio;
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
    }
}