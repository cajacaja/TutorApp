//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tutor_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TerminCasa
    {
        public int TerminId { get; set; }
        public int ZahtjevId { get; set; }
        public System.DateTime DatumCasa { get; set; }
        public System.TimeSpan VrijemePocetka { get; set; }
        public string DanNaziv { get; set; }
    
        public virtual Zahtjev Zahtjev { get; set; }
    }
}