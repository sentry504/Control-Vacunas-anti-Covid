using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Vacunas_anti_Covid.Clases;
using Control_Vacunas_anti_Covid.Modelo;

namespace Control_Vacunas_anti_Covid.Clases
{
    class Vacunas
    {
        Covid_Vacunas_DBEntities db = new Covid_Vacunas_DBEntities();

        public Vacunas()
        {
        }

        public List<Modelo.Vacunas> GetVacunas()
        {
            var Query = from varVacunas in db.Vacunas select varVacunas;
            return Query.ToList();
        }

        public void GuardarVacunas(string registro, DateTime fecha, string vacuna, int cantidad, string tipoRegistro, string origen, string destino)
        {
            Modelo.Vacunas guardarVacuna = new Modelo.Vacunas()
            {
                Registro = registro,
                Fecha_registro = fecha,
                ID_Vacuna = vacuna,
                Cantidad = cantidad,
                Tipo_registro = tipoRegistro,
                Origen = origen,
                Destino = destino,
            };
            db.Vacunas.Add(guardarVacuna);
            db.SaveChanges();
        }

        public void ActualizarVacunas(string registro, DateTime fecha, string vacuna, int cantidad, string tipoRegistro, string origen, string destino)
        {
            Modelo.Vacunas actualizarVacunas = (from e in db.Vacunas where e.Registro == registro select e).FirstOrDefault();
            actualizarVacunas.Fecha_registro = fecha;
            actualizarVacunas.ID_Vacuna = vacuna;
            actualizarVacunas.Cantidad = cantidad;
            actualizarVacunas.Tipo_registro = tipoRegistro;
            actualizarVacunas.Origen = origen;
            actualizarVacunas.Destino=destino;
            db.SaveChanges();
        }

        public void EliminarVacunas(string registro)
        {
            Modelo.Vacunas actualizarVacunas = (from e in db.Vacunas where e.Registro == registro select e).FirstOrDefault();
            db.Vacunas.Remove(actualizarVacunas);
            db.SaveChanges();
        }

        public List<Modelo.Vacunas> Encontrar(string registro)
        {
            var Query = from varVacuna in db.Vacunas select varVacuna;
            return Query.Where(e=> e.Registro==registro).ToList();
        }
    }
}
