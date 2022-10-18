using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Vacunas_anti_Covid.Modelo;

namespace Control_Vacunas_anti_Covid.Clases
{
    class Digitadores
    {
        Covid_Vacunas_DBEntities db = new Covid_Vacunas_DBEntities();
        public Digitadores()
        {
        }

        public List<Ciudadanos> Encontrar(string codigo)
        {
            var Query = from varId in db.Ciudadanos
                        select varId;
            return Query.Where(e => e.Identidad == codigo).ToList();
        }
    }
}
