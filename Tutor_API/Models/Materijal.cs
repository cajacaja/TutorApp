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
    
    public partial class Materijal
    {
        public int MaterijalId { get; set; }
        public int UcionicaId { get; set; }
        public string Naslov { get; set; }
        public System.DateTime DatumPostavljanja { get; set; }
        public byte[] Materijal1 { get; set; }
        public string TipFila { get; set; }
    
        public virtual Ucionica Ucionica { get; set; }
    }
}
