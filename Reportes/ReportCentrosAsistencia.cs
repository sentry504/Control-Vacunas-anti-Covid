﻿using System;
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
    public partial class ReportCentrosAsistencia : Form
    {
        public ReportCentrosAsistencia()
        {
            InitializeComponent();
        }

        private void ReportCentrosAsistencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'covid_Vacunas_DBDataSet.Centros_Asistencia' Puede moverla o quitarla según sea necesario.
            this.centros_AsistenciaTableAdapter.Fill(this.covid_Vacunas_DBDataSet.Centros_Asistencia);

            this.reportViewer1.RefreshReport();
        }
    }
}
