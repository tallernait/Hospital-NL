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
    
    public partial class Lit
    {
        public int NumeroLit { get; set; }
        public Nullable<bool> Occupe { get; set; }
        public int NumeroType { get; set; }
        public string IdDepartement { get; set; }
    
        public virtual Departement Departement { get; set; }
        public virtual TypeLit TypeLit { get; set; }
    }
}