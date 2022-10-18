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
using Control_Vacunas_anti_Covid.Modelo;

namespace Control_Vacunas_anti_Covid
{
    public partial class Gestion_Usuarios : Form
    {
        usuarios conecc = new usuarios();
        bool crear;

        public Gestion_Usuarios(bool nuevoUsuario)
        {
            InitializeComponent();
            crear = nuevoUsuario;
        }

        private void Limpiar()
        {
            textBoxUsuario.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxPassword.Text = "";
            comboBoxTipoUsuario.SelectedIndex = 0;
            textBoxUsuario.Focus();
        }

        private void Gestion_Usuarios_Load(object sender, EventArgs e)
        {
            if (crear)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.StartPosition = FormStartPosition.CenterScreen;
                dataGridView1.DataSource = conecc.GetUsuarios();

            }
        }

        private void Gestion_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (crear)
            {
                login frm = new login();
                this.Hide();
                frm.Show();
            }
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string co = textBoxUsuario.Text.Trim();
                List<Usuarios> datos = conecc.Encontrar(co);

                if (co != "" && co != null)
                {
                    if (conecc.ValidarID(textBoxUsuario.Text.Trim()) != true)
                    {
                        MessageBox.Show("Usuario no existe");
                        textBoxNombre.Enabled = true;
                        textBoxApellido.Enabled = true;
                        textBoxPassword.Enabled = true;
                        comboBoxTipoUsuario.Enabled = true;
                        buttonAgregar.Enabled = true;
                        buttonModificar.Enabled = false;
                        buttonEliminar.Enabled = false;
                    }
                    else
                    {
                        textBoxNombre.Enabled = true;
                        textBoxApellido.Enabled = true;
                        textBoxPassword.Enabled = true;
                        comboBoxTipoUsuario.Enabled = true;
                        buttonAgregar.Enabled = false;
                        buttonModificar.Enabled = true;
                        buttonEliminar.Enabled = true;
                        foreach (var p in datos)
                        {
                            textBoxNombre.Text = p.Nombre;
                            textBoxApellido.Text = p.Apellido;
                            textBoxPassword.Text = p.Password;
                            comboBoxTipoUsuario.Text = p.Tipo_Usuario;
                        }
                    }
                }
                dataGridView1.DataSource = conecc.GetUsuarios();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                conecc.GuardarUsuario(textBoxUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxPassword.Text, comboBoxTipoUsuario.Text);
                MessageBox.Show("El registro se guardo correctamente");
                Limpiar();
                dataGridView1.DataSource = conecc.GetUsuarios();
                dataGridView1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conecc.ActualizarUsuario(textBoxUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxPassword.Text, comboBoxTipoUsuario.Text);
                MessageBox.Show("El registro se actualizo correctamente");
                Limpiar();
                dataGridView1.DataSource = conecc.GetUsuarios();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conecc.EliminarUsuario(textBoxUsuario.Text);
                MessageBox.Show("El registro se elimino correctamente");
                Limpiar();
                dataGridView1.DataSource = conecc.GetUsuarios();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (crear)
            {
                login frm = new login();
                this.Hide();
                frm.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
