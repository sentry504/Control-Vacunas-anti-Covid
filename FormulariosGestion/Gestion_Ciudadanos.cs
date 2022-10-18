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

namespace Control_Vacunas_anti_Covid.FormulariosGestion
{
    public partial class Gestion_Ciudadanos : Form
    {
        ciudadanos conecc= new ciudadanos();
        vacunasciudadano conecc2 = new vacunasciudadano();

        public Gestion_Ciudadanos(string user)
        {
            InitializeComponent();
            if (user.Equals("Administrador")){
                textBoxIdVacuna.Enabled = true;
                textBoxDosis.Enabled = true;
                dateTimePickerFecha.Enabled = true;
            }
        }

        private void Limpiar()
        {
            textBoxIdentidad.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEdad.Text = "";
            textBoxResidencia.Text = "";
            textBoxIdVacuna.Text = "";
            textBoxDosis.Text = "";
            dateTimePickerFecha.Text = "";
            textBoxIdentidad.Focus();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ciudadanos> lista = conecc.EncontrarCiudadano(textBoxIdentidad.Text.Trim());

                if (lista.Count > 0)
                {
                    textBoxIdentidad.Enabled=true;
                    textBoxNombre.Enabled = true;
                    textBoxApellido.Enabled = true;
                    textBoxEdad.Enabled = true;
                    textBoxResidencia.Enabled = true;
                    buttonModificar.Enabled = true;
                    buttonEliminar.Enabled = true;
                    buttonVerRegistro.Enabled = true;
                    foreach(var item in lista)
                    {
                        textBoxIdentidad.Text = item.Identidad;
                        textBoxNombre.Text = item.Nombre;
                        textBoxApellido.Text = item.Apellido;
                        textBoxEdad.Text = item.Edad.ToString();
                        textBoxResidencia.Text = item.Residencia;
                        textBoxIdVacuna.Text = item.ID_Vacuna;
                        textBoxDosis.Text = item.Vacunas.ToString();
                        dateTimePickerFecha.Text = item.Fecha_Ultima_Dosis.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro el registro", "Id incorrecto",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVerRegistro_Click(object sender, EventArgs e)
        {
            Reportes.ReportVacunasCiudadano frm= new Reportes.ReportVacunasCiudadano();
            frm.Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conecc.ActualizarCiudadanos(textBoxIdentidad.Text.Trim(), textBoxNombre.Text.Trim(), textBoxApellido.Text.Trim(),
                    Convert.ToInt32(textBoxEdad.Text.Trim()), textBoxResidencia.Text.Trim(), Convert.ToInt32(textBoxDosis.Text.Trim()),
                    textBoxIdVacuna.Text.Trim(), Convert.ToDateTime(dateTimePickerFecha.Text.Trim()).Date);
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
                conecc.EliminarCiudadanos(textBoxIdentidad.Text.Trim());
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
