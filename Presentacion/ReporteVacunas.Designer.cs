
namespace Presentacion
{
    partial class ReporteVacunas
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
            this.VacunacionDataSet1 = new Presentacion.VacunacionDataSet1();
            this.VacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VacunasTableAdapter = new Presentacion.VacunacionDataSet1TableAdapters.VacunasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VacunacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VacunasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.ReportVacunas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(804, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // VacunacionDataSet1
            // 
            this.VacunacionDataSet1.DataSetName = "VacunacionDataSet1";
            this.VacunacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VacunasBindingSource
            // 
            this.VacunasBindingSource.DataMember = "Vacunas";
            this.VacunasBindingSource.DataSource = this.VacunacionDataSet1;
            // 
            // VacunasTableAdapter
            // 
            this.VacunasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 537);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVacunas";
            this.Text = "ReporteVacunas";
            this.Load += new System.EventHandler(this.ReporteVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VacunacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VacunasBindingSource;
        private VacunacionDataSet1 VacunacionDataSet1;
        private VacunacionDataSet1TableAdapters.VacunasTableAdapter VacunasTableAdapter;
    }
}