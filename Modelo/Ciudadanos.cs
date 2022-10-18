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
    
    public partial class Ciudadanos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciudadanos()
        {
            this.VacunasCiudadano = new HashSet<VacunasCiudadano>();
        }
    
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Residencia { get; set; }
        public Nullable<int> Vacunas { get; set; }
        public string ID_Vacuna { get; set; }
        public Nullable<System.DateTime> Fecha_Ultima_Dosis { get; set; }
    
        public virtual Vacuna Vacuna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VacunasCiudadano> VacunasCiudadano { get; set; }
    }
}