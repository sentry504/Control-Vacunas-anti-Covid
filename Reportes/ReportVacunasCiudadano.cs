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
    public partial class ReportVacunasCiudadano : Form
    {
        public ReportVacunasCiudadano()
        {
            InitializeComponent();
        }

        private void ReportVacunasCiudadano_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'covid_Vacunas_DBDataSet.VacunasCiudadano' Puede moverla o quitarla según sea necesario.
            this.vacunasCiudadanoTableAdapter.Fill(this.covid_Vacunas_DBDataSet.VacunasCiudadano);
            // TODO: esta línea de código carga datos en la tabla 'covid_Vacunas_DBDataSet.Vacunas' Puede moverla o quitarla según sea necesario.
            this.reportViewer1.RefreshReport();
        }
    }
}
