//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Control_Vacunas_anti_Covid.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vacunas
    {
        public string Registro { get; set; }
        public Nullable<System.DateTime> Fecha_registro { get; set; }
        public string ID_Vacuna { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public string Tipo_registro { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    
        public virtual Vacuna Vacuna { get; set; }
    }
}
