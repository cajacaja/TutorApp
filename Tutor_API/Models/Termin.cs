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
    
    public partial class Termin
    {
        public int TerminId { get; set; }
        public int UcionicaId { get; set; }
        public string PocetakCasa { get; set; }
        public string Dan { get; set; }
    
        public virtual Ucionica Ucionica { get; set; }
    }
}
