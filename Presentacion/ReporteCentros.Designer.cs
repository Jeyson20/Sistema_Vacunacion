
namespace Presentacion
{
    partial class ReporteCentros
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
            this.VacunacionDataSet = new Presentacion.VacunacionDataSet();
            this.CentrosVacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CentrosVacunasTableAdapter = new Presentacion.VacunacionDataSetTableAdapters.CentrosVacunasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.VacunacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentrosVacunasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VacunacionDataSet
            // 
            this.VacunacionDataSet.DataSetName = "VacunacionDataSet";
            this.VacunacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CentrosVacunasBindingSource
            // 
            this.CentrosVacunasBindingSource.DataMember = "CentrosVacunas";
            this.CentrosVacunasBindingSource.DataSource = this.VacunacionDataSet;
            // 
            // CentrosVacunasTableAdapter
            // 
            this.CentrosVacunasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CentrosVacunasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(820, 576);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteCentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 537);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCentros";
            this.Text = "ReporteCentros";
            this.Load += new System.EventHandler(this.ReporteCentros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VacunacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentrosVacunasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource CentrosVacunasBindingSource;
        private VacunacionDataSet VacunacionDataSet;
        private VacunacionDataSetTableAdapters.CentrosVacunasTableAdapter CentrosVacunasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}