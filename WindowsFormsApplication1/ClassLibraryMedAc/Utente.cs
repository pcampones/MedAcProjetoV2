//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibraryMedAc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utente()
        {
            this.Valores = new HashSet<Valores>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        public System.DateTime Birthdate { get; set; }
        public int BI { get; set; }
        public int SNS { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public string Alergies { get; set; }
        public int Height { get; set; }
        public int NexOfKinContat { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Valores> Valores { get; set; }
    }
}
