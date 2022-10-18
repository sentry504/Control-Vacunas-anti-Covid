using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Vacunas_anti_Covid.Clases;

namespace Control_Vacunas_anti_Covid.Reportes
{
    public partial class Reporte_Centros_Asistencia : Form
    {
        readonly centros_Atencion reporte = new centros_Atencion();

        public Reporte_Centros_Asistencia()
        {
            InitializeComponent();
        }

        private void Reporte_Centros_Asistencia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reporte.GetCentrosAtencionAscendente("Codigo");
        }

        private void    Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reporte.GetCentrosAtencionAscendente(comboBox1.Text);
            dataGridView1.Refresh();
        }

        private void    Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reporte.GetCentrosAtencionDescendente(comboBox1.Text);
            dataGridView1.Refresh();
        }
    }
}
