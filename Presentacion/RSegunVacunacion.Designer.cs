
namespace Presentacion
{
    partial class RSegunVacunacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VacunacionDataSet1 = new Presentacion.VacunacionDataSet1();
            this.P_PRIMERABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.P_PRIMERATableAdapter = new Presentacion.VacunacionDataSet1TableAdapters.P_PRIMERATableAdapter();
            this.P_SEGUNDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.P_SEGUNDATableAdapter = new Presentacion.VacunacionDataSet1TableAdapters.P_SEGUNDATableAdapter();
            this.P_TERCERABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.P_TERCERATableAdapter = new Presentacion.VacunacionDataSet1TableAdapters.P_TERCERATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VacunacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_PRIMERABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_SEGUNDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_TERCERABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.P_PRIMERABindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.P_SEGUNDABindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.P_TERCERABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.1ERA.rdlc";
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
            // P_PRIMERABindingSource
            // 
            this.P_PRIMERABindingSource.DataMember = "P_PRIMERA";
            this.P_PRIMERABindingSource.DataSource = this.VacunacionDataSet1;
            // 
            // P_PRIMERATableAdapter
            // 
            this.P_PRIMERATableAdapter.ClearBeforeFill = true;
            // 
            // P_SEGUNDABindingSource
            // 
            this.P_SEGUNDABindingSource.DataMember = "P_SEGUNDA";
            this.P_SEGUNDABindingSource.DataSource = this.VacunacionDataSet1;
            // 
            // P_SEGUNDATableAdapter
            // 
            this.P_SEGUNDATableAdapter.ClearBeforeFill = true;
            // 
            // P_TERCERABindingSource
            // 
            this.P_TERCERABindingSource.DataMember = "P_TERCERA";
            this.P_TERCERABindingSource.DataSource = this.VacunacionDataSet1;
            // 
            // P_TERCERATableAdapter
            // 
            this.P_TERCERATableAdapter.ClearBeforeFill = true;
            // 
            // RSegunVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 537);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RSegunVacunacion";
            this.Text = "RSegunVacunacion";
            this.Load += new System.EventHandler(this.RSegunVacunacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VacunacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_PRIMERABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_SEGUNDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_TERCERABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource P_PRIMERABindingSource;
        private VacunacionDataSet1 VacunacionDataSet1;
        private System.Windows.Forms.BindingSource P_SEGUNDABindingSource;
        private System.Windows.Forms.BindingSource P_TERCERABindingSource;
        private VacunacionDataSet1TableAdapters.P_PRIMERATableAdapter P_PRIMERATableAdapter;
        private VacunacionDataSet1TableAdapters.P_SEGUNDATableAdapter P_SEGUNDATableAdapter;
        private VacunacionDataSet1TableAdapters.P_TERCERATableAdapter P_TERCERATableAdapter;
    }
}