//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTITY
{
    using System;
    using System.Collections.Generic;
    
    public partial class REGISTRARE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGISTRARE()
        {
            this.EMPLEADO = new HashSet<EMPLEADO>();
        }
    
        public int ID { get; set; }
        public string NUSUARIO { get; set; }
        public string CONTRASENA { get; set; }
        public Nullable<int> IDEMPLEADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }
        public virtual EMPLEADO EMPLEADO1 { get; set; }
    }
}
