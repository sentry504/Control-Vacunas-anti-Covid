using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Vacunas_anti_Covid.Modelo;

namespace Control_Vacunas_anti_Covid.Clases
{
    internal class vacunasciudadano
    {
        private Covid_Vacunas_DBEntities db = new Covid_Vacunas_DBEntities();

        public vacunasciudadano()
        {

        }

        public List<VacunasCiudadano> GetVacunasCiudadano()
        {
            var Query = from varVacunasCiudadano in db.VacunasCiudadano select varVacunasCiudadano;
            return Query.ToList();
        }

        public void GuardarVacunasCiudadano(string identidad, DateTime fecha_ultima_dosis)
        {
            VacunasCiudadano nuevoVacunasCiudadano = new VacunasCiudadano()
            {
                Identidad = identidad,
                fecha = fecha_ultima_dosis
            };
            db.VacunasCiudadano.Add(nuevoVacunasCiudadano);
            db.SaveChanges();
        }

        public void EliminarVacunasCiudadano(string identidad)
        {
            try
            {
                do
                {
                    VacunasCiudadano eliminar = (from e in db.VacunasCiudadano where e.Identidad == identidad select e).FirstOrDefault();
                    db.VacunasCiudadano.Remove(eliminar);
                    db.SaveChanges();
                } while ((from e in db.VacunasCiudadano where e.Identidad != identidad select e).Equals(null));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarVacunasCiudadano(string identidad, DateTime fecha_ultima_dosis)
        {
            VacunasCiudadano eliminar = (from e in db.VacunasCiudadano where e.Identidad.Equals(identidad) select e).FirstOrDefault();
            eliminar.Identidad = identidad;
            eliminar.fecha = fecha_ultima_dosis;
            db.SaveChanges();
        }

        public List<VacunasCiudadano> EncontrarVacunasCiudadano(string identidad)
        {
            var Query = from e in db.VacunasCiudadano select e;
            return Query.Where(e => e.Identidad.Equals(identidad)).ToList();
        }
    }
}
