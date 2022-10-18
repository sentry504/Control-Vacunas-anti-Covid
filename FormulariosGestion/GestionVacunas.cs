using Control_Vacunas_anti_Covid.Clases;
using Control_Vacunas_anti_Covid.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Vacunas_anti_Covid
{
    public partial class GestionVacunas : Form
    {
        Clases.Vacunas conecc = new Clases.Vacunas();
        private string var;

        public GestionVacunas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            textBoxRegistro.Text = "";
            textBoxCantidad.Text = "";
            textBoxOrigen.Text = "";
            dateTimePickerFechaRegistro.Text = "";
            comboBoxVacuna.SelectedIndex = 0;
            comboBoxDestino.SelectedIndex = 0;
            radioButtonCompras.Checked = true;
            radioButtonDonaciones.Checked = false;
        }

        private void GestionVacunas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'covid_Vacunas_DBDataSet.Vacuna' Puede moverla o quitarla según sea necesario.
            this.vacunaTableAdapter.Fill(this.covid_Vacunas_DBDataSet.Vacuna);
            // TODO: esta línea de código carga datos en la tabla 'covid_Vacunas_DBDataSet.Centros_Asistencia' Puede moverla o quitarla según sea necesario.
            this.centros_AsistenciaTableAdapter.Fill(this.covid_Vacunas_DBDataSet.Centros_Asistencia);

        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelo.Vacunas> lista = conecc.Encontrar(textBoxRegistro.Text.Trim());

                if (lista.Count > 0)
                {
                    textBoxRegistro.Enabled = true;
                    textBoxOrigen.Enabled = true;
                    textBoxCantidad.Enabled = true;
                    dateTimePickerFechaRegistro.Enabled = true;
                    comboBoxVacuna.Enabled = true;
                    comboBoxDestino.Enabled = true;
                    radioButtonCompras.Enabled = true;
                    radioButtonDonaciones.Enabled = true;
                    buttonAgregar.Enabled = false;
                    buttonModificar.Enabled = true;
                    buttonEliminar.Enabled = true;
                    foreach (var item in lista)
                    {
                        textBoxCantidad.Text = item.Cantidad.ToString();
                        textBoxOrigen.Text = item.Origen;
                        dateTimePickerFechaRegistro.Text = Convert.ToDateTime(item.Fecha_registro).Date.ToString();
                        comboBoxVacuna.SelectedText= item.ID_Vacuna;
                        comboBoxDestino.SelectedText = item.Destino;
                        if (item.Tipo_registro.Equals("Compras"))
                            radioButtonCompras.Checked = true;
                        else
                            radioButtonDonaciones.Checked = true;
                    }
                }
                else
                {
                    textBoxRegistro.Enabled = true;
                    textBoxOrigen.Enabled = true;
                    textBoxCantidad.Enabled = true;
                    dateTimePickerFechaRegistro.Enabled = true;
                    comboBoxVacuna.Enabled = true;
                    comboBoxDestino.Enabled = true;
                    radioButtonCompras.Enabled = true;
                    radioButtonDonaciones.Enabled = true;
                    buttonAgregar.Enabled = true;
                    buttonModificar.Enabled = false;
                    buttonEliminar.Enabled = false;
                }
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
                var = radioButtonCompras.Checked.Equals(true) ? "Compras" : "Donaciones";
                conecc.GuardarVacunas(textBoxRegistro.Text.Trim(), Convert.ToDateTime(dateTimePickerFechaRegistro.Text.Trim()).Date,
                    comboBoxVacuna.Text, Convert.ToInt32(textBoxCantidad.Text), var, textBoxOrigen.Text, comboBoxDestino.Text);
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
                var = radioButtonCompras.Checked.Equals(true) ? "Compras" : "Donaciones";
                conecc.ActualizarVacunas(textBoxRegistro.Text.Trim(), Convert.ToDateTime(dateTimePickerFechaRegistro.Text.Trim()).Date,
                    comboBoxVacuna.Text, Convert.ToInt32(textBoxCantidad.Text), var, textBoxOrigen.Text, comboBoxDestino.Text);
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
                conecc.EliminarVacunas(textBoxRegistro.Text);
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
