using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Vacunas_anti_Covid.Reportes
{
    public partial class ReportVacunas : Form
    {
        public ReportVacunas()
        {
            InitializeComponent();
        }

        private void ReportVacunas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'covid_Vacunas_DBDataSet.Vacunas' Puede moverla o quitarla según sea necesario.
            this.vacunasTableAdapter.Fill(this.covid_Vacunas_DBDataSet.Vacunas);

            this.reportViewer1.RefreshReport();
        }
    }
}
