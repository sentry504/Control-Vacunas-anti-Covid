using System;
using System.Windows.Forms;
using Control_Vacunas_anti_Covid.Reportes;
using Control_Vacunas_anti_Covid.FormulariosGestion;

namespace Control_Vacunas_anti_Covid
{
    public partial class Principal : Form
    {
        readonly string Usuario;

        //Constructor con parametro que indica el tipo de usuario de la sesion actual
        public Principal( string user)
        {
            InitializeComponent();
            this.Usuario = user; //El atributo Usuario toma el valor del parametro user
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            switch (Usuario) //Se configuran las opciones que seran visibles dependiendo del tipo de usuario actual
            {
                case "Administrador":
                    this.Text = this.Text + " -- " + Usuario; //Agrega al texto del formulario el tipo de usuario actual

                    //Habilita los archivos que seran visibles para el usuario
                    gestorDeUsuariosToolStripMenuItem.Visible = true;
                    registroCentrosDeAtencionToolStripMenuItem.Visible = true;
                    registroVacunasToolStripMenuItem.Visible = true;
                    vacunaToolStripMenuItem.Visible = true;
                    registroCiudadanosToolStripMenuItem.Visible = true;
                    aPIDigitadoresToolStripMenuItem.Visible = true;

                    //Habilita los reportes que seran visibles para el usuario
                    reporteCentrosDeAsistenciaToolStripMenuItem.Visible = true;
                    reporteCiudadanosToolStripMenuItem.Visible = true;
                    reporteDeVacunasToolStripMenuItem.Visible = true;
                    reporteVacunasPorCiudadanosToolStripMenuItem.Visible = true;
                    break;
                case "Oficial medico":
                    this.Text = this.Text + " -- " + Usuario;

                    // Habilita los archivos que seran visibles para el usuario
                    gestorDeUsuariosToolStripMenuItem.Visible = true;
                    registroCentrosDeAtencionToolStripMenuItem.Visible = true;
                    registroVacunasToolStripMenuItem.Visible = true;
                    vacunaToolStripMenuItem.Visible = true;
                    aPIDigitadoresToolStripMenuItem.Visible=true;

                    //Habilita los reportes que seran visibles para el usuario
                    reporteCentrosDeAsistenciaToolStripMenuItem.Visible = true;
                    reporteCiudadanosToolStripMenuItem.Visible = true;
                    reporteDeVacunasToolStripMenuItem.Visible = true;
                    reporteVacunasPorCiudadanosToolStripMenuItem.Visible = true;
                    break;
                default:
                    this.Text += " -- Invitado";

                    //Se restringe el acceso, no se permite realizar cambios en la base de datos
                    reporteCentrosDeAsistenciaToolStripMenuItem.Visible = true;
                    reporteCiudadanosToolStripMenuItem.Visible = true;
                    reporteDeVacunasToolStripMenuItem.Visible = true;
                    reporteVacunasPorCiudadanosToolStripMenuItem.Visible = true;
                    break;
            }
        }
        
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Metodos para los gestores

        private void GestorDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Usuarios frm = new Gestion_Usuarios(false);
            frm.MdiParent = this;
            frm.Show();
        }

        
        private void RegistroCentrosDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Centros_Atencion frm = new Gestion_Centros_Atencion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void registroVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVacunas frm = new GestionVacunas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void VacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vacuna frm = new vacuna();
            frm.MdiParent = this;
            frm.Show();
        }

        private void registroCiudadanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Ciudadanos frm = new Gestion_Ciudadanos(this.Usuario);
            frm.MdiParent = this;
            frm.Show();
        }

        //Metodos para los reportes

        private void ReporteCentrosDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCentrosAsistencia frm = new ReportCentrosAsistencia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteCiudadanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCiudadanos frm = new ReportCiudadanos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDeVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportVacunas frm = new ReportVacunas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteVacunasPorCiudadanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportVacunasCiudadano frm = new ReportVacunasCiudadano();
            frm.MdiParent = this;
            frm.Show();
        }

        //Metodos para las vistas de los formularios MDI secundarios

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void aPIDigitadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
