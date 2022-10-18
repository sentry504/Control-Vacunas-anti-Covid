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
    public partial class Gestion_Centros_Atencion : Form
    {
        centros_Atencion conecc = new centros_Atencion();

        public Gestion_Centros_Atencion()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxCapacidad.Text = "";
            textBoxMedicos.Text = "";
            textBoxEnfermeras.Text = "";
            textBoxPacientes.Text = "";
            comboBoxTipoCentroMedico.SelectedIndex = 0;
            textBoxCodigo.Focus();
        }
        
        private void buttonValidar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Centros_Asistencia> centroAtencion = conecc.Encontrar(textBoxCodigo.Text.Trim());
                if (centroAtencion.Count > 0)
                {
                    textBoxNombre.Enabled = true;
                    textBoxCapacidad.Enabled = true;
                    textBoxMedicos.Enabled = true;
                    textBoxEnfermeras.Enabled = true;
                    textBoxPacientes.Enabled = true;
                    comboBoxTipoCentroMedico.Enabled = true;
                    buttonAgregar.Enabled = false;
                    buttonModificar.Enabled = true;
                    buttonEliminar.Enabled = true;
                    foreach (var p in centroAtencion)
                    {
                        textBoxNombre.Text = p.Nombre;
                        textBoxCapacidad.Text = p.Capacidad.ToString();
                        textBoxMedicos.Text = p.Numero_Medicos.ToString();
                        textBoxEnfermeras.Text = p.Numero_Enfermeras.ToString();
                        textBoxPacientes.Text = p.Numero_Pacientes.ToString();
                        comboBoxTipoCentroMedico.Text = p.Tipo_Centro_Medico;
                    }
                }
                else
                {
                    textBoxNombre.Enabled = true;
                    textBoxCapacidad.Enabled = true;
                    textBoxMedicos.Enabled = true;
                    textBoxEnfermeras.Enabled = true;
                    textBoxPacientes.Enabled = true;
                    comboBoxTipoCentroMedico.Enabled = true;
                    buttonAgregar.Enabled = true;
                    buttonModificar.Enabled = false;
                    buttonEliminar.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                conecc.GuardarCentroAsistencia(textBoxCodigo.Text.Trim(), textBoxNombre.Text, Convert.ToInt32(textBoxCapacidad.Text.Trim()),
                    Convert.ToInt32(textBoxMedicos.Text.Trim()), Convert.ToInt32(textBoxEnfermeras.Text.Trim()), Convert.ToInt32(textBoxPacientes.Text.Trim()),comboBoxTipoCentroMedico.Text);
                MessageBox.Show("El registro se guardo correctamente");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conecc.ActualizarCentroAtencion(textBoxCodigo.Text.Trim(), textBoxNombre.Text, Convert.ToInt32(textBoxCapacidad.Text.Trim()),
                    Convert.ToInt32(textBoxMedicos.Text.Trim()), Convert.ToInt32(textBoxEnfermeras.Text.Trim()), Convert.ToInt32(textBoxPacientes.Text.Trim()), comboBoxTipoCentroMedico.Text);
                MessageBox.Show("El registro se actualizo correctamente");
                Limpiar();
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
                conecc.EliminarCentroAtencion(textBoxCodigo.Text);
                MessageBox.Show("El registro se elimino correctamente");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
