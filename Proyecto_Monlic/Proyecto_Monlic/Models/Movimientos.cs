//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Monlic.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movimientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movimientos()
        {
            this.Entradas_Salidas = new HashSet<Entradas_Salidas>();
        }
    
        public int IdMovimiento { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdTipoM { get; set; }
        public Nullable<int> IdContacto { get; set; }
        public string Estado { get; set; }
    
        public virtual Contactos Contactos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entradas_Salidas> Entradas_Salidas { get; set; }
        public virtual TiposMovimientos TiposMovimientos { get; set; }
    }
}
