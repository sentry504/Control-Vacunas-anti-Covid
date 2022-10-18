
namespace Control_Vacunas_anti_Covid.Reportes
{
    partial class ReportVacunasCiudadano
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
            this.covid_Vacunas_DBDataSet = new Control_Vacunas_anti_Covid.Covid_Vacunas_DBDataSet();
            this.vacunasCiudadanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunasCiudadanoTableAdapter = new Control_Vacunas_anti_Covid.Covid_Vacunas_DBDataSetTableAdapters.VacunasCiudadanoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.covid_Vacunas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasCiudadanoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vacunasCiudadanoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Control_Vacunas_anti_Covid.Reportes.ReportVacunasCiudadanos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(528, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // covid_Vacunas_DBDataSet
            // 
            this.covid_Vacunas_DBDataSet.DataSetName = "Covid_Vacunas_DBDataSet";
            this.covid_Vacunas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacunasCiudadanoBindingSource
            // 
            this.vacunasCiudadanoBindingSource.DataMember = "VacunasCiudadano";
            this.vacunasCiudadanoBindingSource.DataSource = this.covid_Vacunas_DBDataSet;
            // 
            // vacunasCiudadanoTableAdapter
            // 
            this.vacunasCiudadanoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportVacunasCiudadano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(526, 244);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportVacunasCiudadano";
            this.Text = "ReportVacunasCiudadano";
            this.Load += new System.EventHandler(this.ReportVacunasCiudadano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.covid_Vacunas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasCiudadanoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Covid_Vacunas_DBDataSet covid_Vacunas_DBDataSet;
        private System.Windows.Forms.BindingSource vacunasCiudadanoBindingSource;
        private Covid_Vacunas_DBDataSetTableAdapters.VacunasCiudadanoTableAdapter vacunasCiudadanoTableAdapter;
    }
}