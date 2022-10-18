using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Vacunas_anti_Covid.Modelo;

namespace Control_Vacunas_anti_Covid.FormulariosGestion
{
    public partial class vacuna : Form
    {
        Covid_Vacunas_DBEntities db = new Covid_Vacunas_DBEntities();

        public vacuna()
        {
            InitializeComponent();
        }

        //Metodo para llamar a la tabla Vacuna y obtener sus registros
        public List<Vacuna> GetVacuna()
        {
            var Query = from a in db.Vacuna
                        select a;
            return Query.ToList();
        }

        public void GuardarCambioVacuna(string ID, string nombre)
        {
            try
            {
                var result = db.Vacuna.Where(e => e.ID_Vacuna == ID);
                int count = result.ToList().Count();

                if (count > 0)
                {
                    Vacuna varVacuna = (from a in db.Vacuna where a.ID_Vacuna == ID select a).FirstOrDefault();
                    varVacuna.ID_Vacuna = ID;
                    varVacuna.Nombre_Vacuna = nombre;
                    db.SaveChanges();
                }
                else
                {
                    Vacuna nuevaVacuna = new Vacuna()
                    {
                        ID_Vacuna = ID,
                        Nombre_Vacuna = nombre
                    };
                    db.Vacuna.Add(nuevaVacuna);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo guardar: "+ex.Message);
            }
        }

        public void EliminarVacuna(string ID)
        {
            try
            {
                Vacuna varVacuna = (from a in db.Vacuna where a.ID_Vacuna == ID select a).FirstOrDefault();
                db.Vacuna.Remove(varVacuna);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: "+ex.Message);
            }
        }

        //Carga inicial del formulario con el registro de la tabla Vacuna
        private void vacuna_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetVacuna();
        }

        //
        private void buttonValidar_Click(object sender, EventArgs e)
        {
            GuardarCambioVacuna(textBoxID.Text.Trim(), textBoxNombre.Text);
            dataGridView1.DataSource = this.GetVacuna();
            dataGridView1.Refresh();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarVacuna(textBoxID.Text.Trim());
            dataGridView1.DataSource = this.GetVacuna();
            dataGridView1.Refresh();
        }
    }
}
