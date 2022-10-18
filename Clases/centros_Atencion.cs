using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Vacunas_anti_Covid.Modelo;

namespace Control_Vacunas_anti_Covid.Clases
{
    class centros_Atencion
    {
        Covid_Vacunas_DBEntities db = new Covid_Vacunas_DBEntities();

        //constructor por defecto
        public centros_Atencion()
        {
        }

        public List<Centros_Asistencia> GetCentrosAtencionAscendente(string orderby)
        {
            var Query= from varCentroAtencion in db.Centros_Asistencia
                       select varCentroAtencion;
            switch (orderby)
            {
                case "Codigo":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                                orderby varCentroAtencion.Codigo_Centro_Medico
                                ascending
                                select varCentroAtencion;
                    return Query.ToList();
                case "Nombre":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            ascending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Capacidad":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            ascending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Numero de Medicos":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            ascending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Numero de Enfermeras":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            ascending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Numero de Pacientes":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            ascending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Tipo de centro Medico":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            ascending
                            select varCentroAtencion;
                    return Query.ToList();
                default:
                    Query = from varCentroAtencion in db.Centros_Asistencia
                                select varCentroAtencion;
                    return Query.ToList();
            }
        }

        public List<Centros_Asistencia> GetCentrosAtencionDescendente(string orderby)
        {
            var Query = from varCentroAtencion in db.Centros_Asistencia
                        select varCentroAtencion;
            switch (orderby)
            {
                case "Codigo":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Codigo_Centro_Medico
                            descending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Nombre":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            descending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Capacidad":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            descending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Numero de Medicos":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            descending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Numero de Enfermeras":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            descending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Numero de Pacientes":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            descending
                            select varCentroAtencion;
                    return Query.ToList();
                case "Tipo de centro Medico":
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            orderby varCentroAtencion.Nombre
                            descending
                            select varCentroAtencion;
                    return Query.ToList();
                default:
                    Query = from varCentroAtencion in db.Centros_Asistencia
                            select varCentroAtencion;
                    return Query.ToList();
            }
        }

        public void GuardarCentroAsistencia(string codigo_, string nombre_, int capacidad_, int medicos_, int enfermeras_, int pacientes_, string tipoCentroMedico_)
        {
            Centros_Asistencia guardarCentro = new Centros_Asistencia()
            {
                Codigo_Centro_Medico = codigo_,
                Nombre = nombre_,
                Capacidad= capacidad_,
                Numero_Medicos= medicos_,
                Numero_Enfermeras= enfermeras_,
                Numero_Pacientes=pacientes_,
                Tipo_Centro_Medico= tipoCentroMedico_,
            };
            db.Centros_Asistencia.Add(guardarCentro);
            db.SaveChanges();
        }

        public void EliminarCentroAtencion(string codigo)
        {
            Centros_Asistencia centroAsistencia = (from e in db.Centros_Asistencia where e.Codigo_Centro_Medico == codigo select e).FirstOrDefault();
            db.Centros_Asistencia.Remove(centroAsistencia);
            db.SaveChanges();
        }

        public void ActualizarCentroAtencion(string codigo_, string nombre_, int capacidad_, int medicos_, int enfermeras_, int pacientes_, string tipoCentroMedico_)
        {
            Centros_Asistencia actualizarCentro = (from e in db.Centros_Asistencia where e.Codigo_Centro_Medico == codigo_ select e).FirstOrDefault();
            actualizarCentro.Nombre = nombre_;
            actualizarCentro.Numero_Medicos = medicos_;
            actualizarCentro.Numero_Enfermeras = enfermeras_;
            actualizarCentro.Numero_Pacientes = pacientes_;
            actualizarCentro.Tipo_Centro_Medico = tipoCentroMedico_;
            db.SaveChanges();
        }

        public List<Centros_Asistencia> Encontrar(string codigo)
        {
            var Query = from varCentroAsistencia in db.Centros_Asistencia
                        select varCentroAsistencia;
            return Query.Where(e => e.Codigo_Centro_Medico == codigo).ToList();
        }
    }
}
