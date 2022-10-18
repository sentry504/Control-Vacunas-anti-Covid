
namespace Control_Vacunas_anti_Covid.Reportes
{
    partial class ReportCentrosAsistencia
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
            this.centrosAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covid_Vacunas_DBDataSet = new Control_Vacunas_anti_Covid.Covid_Vacunas_DBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.centros_AsistenciaTableAdapter = new Control_Vacunas_anti_Covid.Covid_Vacunas_DBDataSetTableAdapters.Centros_AsistenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.centrosAsistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid_Vacunas_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // centrosAsistenciaBindingSource
            // 
            this.centrosAsistenciaBindingSource.DataMember = "Centros_Asistencia";
            this.centrosAsistenciaBindingSource.DataSource = this.covid_Vacunas_DBDataSet;
            // 
            // covid_Vacunas_DBDataSet
            // 
            this.covid_Vacunas_DBDataSet.DataSetName = "Covid_Vacunas_DBDataSet";
            this.covid_Vacunas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetCentrosAsistencia";
            reportDataSource1.Value = this.centrosAsistenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Control_Vacunas_anti_Covid.Reportes.ReportCentrosAsistencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(946, 488);
            this.reportViewer1.TabIndex = 0;
            // 
            // centros_AsistenciaTableAdapter
            // 
            this.centros_AsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportCentrosAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportCentrosAsistencia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportCentrosAsistencia";
            this.Load += new System.EventHandler(this.ReportCentrosAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centrosAsistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid_Vacunas_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Covid_Vacunas_DBDataSet covid_Vacunas_DBDataSet;
        private System.Windows.Forms.BindingSource centrosAsistenciaBindingSource;
        private Covid_Vacunas_DBDataSetTableAdapters.Centros_AsistenciaTableAdapter centros_AsistenciaTableAdapter;
    }
}