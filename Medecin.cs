//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalNL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medecin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medecin()
        {
            this.DossierAdmission = new HashSet<DossierAdmission>();
        }
    
        public int IdMedecin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Specialite { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DossierAdmission> DossierAdmission { get; set; }
    }
}
