using System;
using System.Collections.Generic;
using System.Linq;
using Control_Vacunas_anti_Covid.Modelo;


namespace Control_Vacunas_anti_Covid.Clases
{
    class ciudadanos
    {
        private Covid_Vacunas_DBEntities db = new Covid_Vacunas_DBEntities();

        public ciudadanos()
        {

        }

        public List<Ciudadanos> GetCiudadanos()
        {
            var Query = from varCiudadanos in db.Ciudadanos select varCiudadanos;
            return Query.ToList();
        }

        public void GuardarCiudadano(string identidad, string nombre, string ape, int edad, string Residencia, int vacunas, string idVacunas, DateTime fecha_ultima_dosis)
        {
            Ciudadanos nuevoCiudadano = new Ciudadanos()
            {
                Identidad = identidad,
                Nombre = nombre,
                Apellido = ape,
                Edad = edad,
                Residencia = Residencia,
                Vacunas = vacunas,
                ID_Vacuna = idVacunas,
                Fecha_Ultima_Dosis = fecha_ultima_dosis
            };
            db.Ciudadanos.Add(nuevoCiudadano);
            db.SaveChanges();
        }

        public void EliminarCiudadanos(string identidad)
        {
            Ciudadanos eliminar = (from e in db.Ciudadanos where e.Identidad == identidad select e).FirstOrDefault();
            db.Ciudadanos.Remove(eliminar);
            db.SaveChanges();
        }

        public void ActualizarCiudadanos(string identidad, string nombre, string ape, int edad, string Residencia, int vacunas, string idVacunas, DateTime fecha_ultima_dosis)
        {
            Ciudadanos eliminar = (from e in db.Ciudadanos where e.Identidad.Equals(identidad) select e).FirstOrDefault();
            eliminar.Identidad = identidad;
            eliminar.Nombre = nombre;
            eliminar.Apellido = ape;
            eliminar.Edad = edad;
            eliminar.Vacunas = vacunas;
            eliminar.Residencia = Residencia;
            eliminar.ID_Vacuna = idVacunas;
            eliminar.Fecha_Ultima_Dosis = fecha_ultima_dosis;
            db.SaveChanges();
        }

        public List<Ciudadanos> EncontrarCiudadano(string identidad)
        {
            var Query = from e in db.Ciudadanos select e;
            return Query.Where(e=> e.Identidad.Equals(identidad)).ToList();
        }
    }
}
