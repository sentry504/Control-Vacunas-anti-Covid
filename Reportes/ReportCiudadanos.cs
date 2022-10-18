using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Vacunas_anti_Covid.Reportes
{
    public partial class ReportCiudadanos : Form
    {
        public ReportCiudadanos()
        {
            InitializeComponent();
        }

        private void ReportCiudadanos_Load(object sender, EventArgs e)
        {
            this.ciudadanosTableAdapter.Fill(this.covid_Vacunas_DBDataSet.Ciudadanos);
            this.reportViewer1.RefreshReport();
        }
    }
}
