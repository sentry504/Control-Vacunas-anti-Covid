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

namespace Control_Vacunas_anti_Covid
{
    public partial class login : Form
    {
        //Instancia de la clase 'usuarios'
        usuarios usuariosClass = new usuarios();

        public login()
        {
            InitializeComponent();
        }

        //Metodo para refrescar los objetos del formulario
        private void Limpiar()
        {
            textBoxCodigo.Text = "";
            textBoxPassword.Text = "";
            textBoxCodigo.Focus();
        }

        public void confirmar()
        {
            try
            {
                if (usuariosClass.validar(textBoxCodigo.Text, textBoxPassword.Text) != false)
                {
                    Principal frm = new Principal(usuariosClass.sesion);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            confirmar();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal frm = new Principal(null);
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gestion_Usuarios frm = new Gestion_Usuarios(true);
            frm.Show();
            this.Hide();
        }

        //En caso que el usuario presione la tecla ENTER teniendo el foco el textbox de password, ejecuta el metodo 'confirmar()' para validar las credenciales
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char)Keys.Enter) == e.KeyChar)
            {
                confirmar();
            }
        }
    }
}
