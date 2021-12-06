
namespace Presentacion
{
    partial class ReportesCentros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VacunacionDataSet = new Presentacion.VacunacionDataSet();
            this.P_BUSCAR_CENTROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.P_BUSCAR_CENTROTableAdapter = new Presentacion.VacunacionDataSetTableAdapters.P_BUSCAR_CENTROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VacunacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_BUSCAR_CENTROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.P_BUSCAR_CENTROBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // VacunacionDataSet
            // 
            this.VacunacionDataSet.DataSetName = "VacunacionDataSet";
            this.VacunacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // P_BUSCAR_CENTROBindingSource
            // 
            this.P_BUSCAR_CENTROBindingSource.DataMember = "P_BUSCAR_CENTRO";
            this.P_BUSCAR_CENTROBindingSource.DataSource = this.VacunacionDataSet;
            // 
            // P_BUSCAR_CENTROTableAdapter
            // 
            this.P_BUSCAR_CENTROTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesCentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesCentros";
            this.Text = "ReportesCentros";
            this.Load += new System.EventHandler(this.ReportesCentros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VacunacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_BUSCAR_CENTROBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource P_BUSCAR_CENTROBindingSource;
        private VacunacionDataSet VacunacionDataSet;
        private VacunacionDataSetTableAdapters.P_BUSCAR_CENTROTableAdapter P_BUSCAR_CENTROTableAdapter;
    }
}